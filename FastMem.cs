using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FAST_MEMORY
{
    public class FastMemory
    {
        #region WinAPI
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        private static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

        private const uint PROCESS_ALL_ACCESS = 0x1F0FFF;
        private const uint MEM_COMMIT = 0x1000;
        private const uint PAGE_READWRITE = 0x04;
        private const uint PAGE_EXECUTE_READWRITE = 0x40;

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public uint AllocationProtect;
            public IntPtr RegionSize;
            public uint State;
            public uint Protect;
            public uint Type;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            public ushort ProcessorArchitecture;
            public ushort Reserved;
            public uint PageSize;
            public IntPtr MinimumApplicationAddress;
            public IntPtr MaximumApplicationAddress;
            public IntPtr ActiveProcessorMask;
            public uint NumberOfProcessors;
            public uint ProcessorType;
            public uint AllocationGranularity;
            public ushort ProcessorLevel;
            public ushort ProcessorRevision;
        }
        #endregion

        public IntPtr ProcessHandle = IntPtr.Zero;
        public int ProcessId = 0;
        private bool is64Bit = false;

        // ==================== PROCESS ====================
        public bool OpenProcess(string processName)
        {
            var procs = Process.GetProcessesByName(processName);
            if (procs.Length == 0) return false;

            ProcessId = procs[0].Id;
            ProcessHandle = OpenProcess(PROCESS_ALL_ACCESS, false, ProcessId);
            is64Bit = Environment.Is64BitOperatingSystem;
            return ProcessHandle != IntPtr.Zero;
        }

        public bool OpenProcess(int pid)
        {
            ProcessId = pid;
            ProcessHandle = OpenProcess(PROCESS_ALL_ACCESS, false, pid);
            is64Bit = Environment.Is64BitOperatingSystem;
            return ProcessHandle != IntPtr.Zero;
        }

        public void CloseProcess()
        {
            if (ProcessHandle != IntPtr.Zero)
            {
                CloseHandle(ProcessHandle);
                ProcessHandle = IntPtr.Zero;
            }
        }

        // ==================== READ / WRITE ====================
        public byte[] ReadBytes(long address, int length)
        {
            byte[] buffer = new byte[length];
            ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, length, out _);
            return buffer;
        }

        public bool WriteBytes(long address, byte[] bytes)
        {
            return WriteProcessMemory(ProcessHandle, (IntPtr)address, bytes, bytes.Length, out _);
        }

        public bool WriteMemory(string address, string type, string value)
        {
            try
            {
                long addr = Convert.ToInt64(address, 16);
                byte[] data = null;

                switch (type.ToLower())
                {
                    case "int": data = BitConverter.GetBytes(int.Parse(value)); break;
                    case "float": data = BitConverter.GetBytes(float.Parse(value)); break;
                    case "double": data = BitConverter.GetBytes(double.Parse(value)); break;
                    case "long": data = BitConverter.GetBytes(long.Parse(value)); break;
                    case "bytes":
                        var parts = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        data = new byte[parts.Length];
                        for (int i = 0; i < parts.Length; i++)
                            data[i] = Convert.ToByte(parts[i], 16);
                        break;
                }

                if (data != null)
                    return WriteBytes(addr, data);
                return false;
            }
            catch { return false; }
        }

        // ==================== ULTRA FAST SCAN (5 SECOND) ====================
        public async Task<List<long>> ScanPattern(string pattern, bool writable = true, bool executable = false)
        {
            return await Task.Run(() =>
            {
                var results = new ConcurrentBag<long>();

                // Parse pattern
                var parts = pattern.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                byte[] patternBytes = new byte[parts.Length];
                byte[] mask = new byte[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i] == "??" || parts[i] == "?")
                    {
                        mask[i] = 0x00;
                        patternBytes[i] = 0x00;
                    }
                    else
                    {
                        mask[i] = 0xFF;
                        patternBytes[i] = Convert.ToByte(parts[i], 16);
                    }
                }

                // Get memory regions
                var regions = GetMemoryRegions(writable, executable);

                // Parallel scan - FAST!
                Parallel.ForEach(regions, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, (region) =>
                {
                    if (region.RegionSize.ToInt64() <= 0 || region.RegionSize.ToInt64() > int.MaxValue)
                        return;

                    int size = (int)region.RegionSize.ToInt64();
                    byte[] buffer = new byte[size];

                    if (ReadProcessMemory(ProcessHandle, region.BaseAddress, buffer, size, out _))
                    {
                        unsafe
                        {
                            fixed (byte* pBuffer = buffer)
                            fixed (byte* pPattern = patternBytes)
                            fixed (byte* pMask = mask)
                            {
                                int limit = size - patternBytes.Length;
                                for (int i = 0; i <= limit; i++)
                                {
                                    if (pMask[0] == 0xFF && pBuffer[i] != pPattern[0])
                                        continue;

                                    bool match = true;
                                    for (int j = 1; j < patternBytes.Length; j++)
                                    {
                                        if (pMask[j] == 0xFF && pBuffer[i + j] != pPattern[j])
                                        {
                                            match = false;
                                            break;
                                        }
                                    }

                                    if (match)
                                        results.Add((long)region.BaseAddress + i);
                                }
                            }
                        }
                    }
                });

                return results.ToList();
            });
        }

        // ==================== SCAN AND REPLACE (5 SECOND) ====================
        public async Task<(int count, List<long> addresses)> ScanAndReplace(
            string searchPattern,
            string replacePattern,
            bool writable = true,
            bool executable = false)
        {
            var addresses = await ScanPattern(searchPattern, writable, executable);

            if (addresses.Count == 0)
                return (0, addresses);

            byte[] replaceBytes = ParseHexToBytes(replacePattern);
            int successCount = 0;

            foreach (long addr in addresses)
            {
                if (WriteBytes(addr, replaceBytes))
                    successCount++;
            }

            return (successCount, addresses);
        }

        // ==================== SCAN AND REPLACE WITH BACKUP ====================
        public async Task<(int count, List<long> addresses, Dictionary<long, byte[]> originals, Dictionary<long, byte[]> replaced)>
            ScanAndReplaceWithBackup(string searchPattern, string replacePattern, bool writable = true, bool executable = false)
        {
            var addresses = await ScanPattern(searchPattern, writable, executable);
            var originals = new Dictionary<long, byte[]>();
            var replaced = new Dictionary<long, byte[]>();

            if (addresses.Count == 0)
                return (0, addresses, originals, replaced);

            byte[] replaceBytes = ParseHexToBytes(replacePattern);
            int patternLength = searchPattern.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int successCount = 0;

            foreach (long addr in addresses)
            {
                byte[] originalBytes = ReadBytes(addr, patternLength);
                originals[addr] = originalBytes;

                if (WriteBytes(addr, replaceBytes))
                {
                    replaced[addr] = replaceBytes;
                    successCount++;
                }
            }

            return (successCount, addresses, originals, replaced);
        }

        // ==================== RESTORE ====================
        public int Restore(Dictionary<long, byte[]> backup)
        {
            int count = 0;
            foreach (var kvp in backup)
            {
                if (WriteBytes(kvp.Key, kvp.Value))
                    count++;
            }
            return count;
        }

        // ==================== HELPERS ====================
        private List<MEMORY_BASIC_INFORMATION> GetMemoryRegions(bool writable, bool executable)
        {
            var regions = new List<MEMORY_BASIC_INFORMATION>();
            GetSystemInfo(out SYSTEM_INFO sysInfo);

            IntPtr address = sysInfo.MinimumApplicationAddress;

            while (address.ToInt64() < sysInfo.MaximumApplicationAddress.ToInt64())
            {
                MEMORY_BASIC_INFORMATION mbi;
                if (VirtualQueryEx(ProcessHandle, address, out mbi, (uint)Marshal.SizeOf(typeof(MEMORY_BASIC_INFORMATION))) == 0)
                    break;

                if (mbi.State == MEM_COMMIT)
                {
                    bool isWritable = (mbi.Protect & PAGE_READWRITE) == PAGE_READWRITE ||
                                      (mbi.Protect & PAGE_EXECUTE_READWRITE) == PAGE_EXECUTE_READWRITE;
                    bool isExecutable = (mbi.Protect & PAGE_EXECUTE_READWRITE) == PAGE_EXECUTE_READWRITE;

                    if ((writable && isWritable) || (executable && isExecutable))
                        regions.Add(mbi);
                }

                address = (IntPtr)(address.ToInt64() + mbi.RegionSize.ToInt64());
            }

            return regions;
        }

        private byte[] ParseHexToBytes(string hexString)
        {
            var parts = hexString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] bytes = new byte[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "??" || parts[i] == "?")
                    bytes[i] = 0x00;
                else
                    bytes[i] = Convert.ToByte(parts[i], 16);
            }
            return bytes;
        }
    }
}