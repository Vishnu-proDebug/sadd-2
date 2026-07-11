// Form1.Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PhantomXiters
{
    partial class Form1
    {
        private IContainer components = null;
        private Label S;
        private Guna2BorderlessForm guna2BorderlessForm1;
        private Guna2Elipse guna2Elipse1;
        private Guna2ShadowForm guna2ShadowForm1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.S = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AimBotMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SniperPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox2 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox3 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox4 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox5 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox10 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.KeyPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.MouseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.EspPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox6 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SettingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox7 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox8 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel14 = new Guna.UI2.WinForms.Guna2Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox9 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Panel15 = new Guna.UI2.WinForms.Guna2Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LoginPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl5 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl6 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl7 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl8 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.AimBotMenu.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SniperPanel.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            this.KeyPanel.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.EspPanel.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.guna2Panel12.SuspendLayout();
            this.guna2Panel13.SuspendLayout();
            this.guna2Panel14.SuspendLayout();
            this.guna2Panel15.SuspendLayout();
            this.LoginPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.S.ForeColor = System.Drawing.Color.Gray;
            this.S.Location = new System.Drawing.Point(11, 297);
            this.S.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(37, 16);
            this.S.TabIndex = 3;
            this.S.Text = "Logs :";
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationInterval = 100;
            this.guna2BorderlessForm1.BorderRadius = 14;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.5D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2Panel1.Controls.Add(this.guna2Button5);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 53);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(101, 241);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.guna2Button5.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.Location = new System.Drawing.Point(0, 137);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(101, 25);
            this.guna2Button5.TabIndex = 7;
            this.guna2Button5.Text = "  Setting";
            this.guna2Button5.UseTransparentBackground = true;
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Location = new System.Drawing.Point(0, 111);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(101, 25);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "Esp";
            this.guna2Button4.UseTransparentBackground = true;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.Checked = true;
            this.guna2Button3.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.guna2Button3.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(0, 86);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(101, 25);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "  AimBot";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(101, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Animated = true;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.LightGray;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(352, 3);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(12, 12);
            this.guna2CircleButton2.TabIndex = 10;
            this.guna2CircleButton2.Text = "guna2CircleButton2";
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(370, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(12, 12);
            this.guna2CircleButton1.TabIndex = 9;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(218, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 8;
            // 
            // AimBotMenu
            // 
            this.AimBotMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AimBotMenu.Controls.Add(this.guna2Panel5);
            this.AimBotMenu.Controls.Add(this.SniperPanel);
            this.AimBotMenu.Controls.Add(this.guna2Panel7);
            this.AimBotMenu.Controls.Add(this.guna2Panel3);
            this.AimBotMenu.Controls.Add(this.guna2Panel8);
            this.AimBotMenu.Controls.Add(this.guna2Panel11);
            this.AimBotMenu.Controls.Add(this.KeyPanel);
            this.AimBotMenu.Controls.Add(this.guna2Panel4);
            this.AimBotMenu.Location = new System.Drawing.Point(126, 53);
            this.AimBotMenu.Name = "AimBotMenu";
            this.AimBotMenu.Size = new System.Drawing.Size(250, 235);
            this.AimBotMenu.TabIndex = 6;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel5.Controls.Add(this.guna2CustomCheckBox1);
            this.guna2Panel5.Controls.Add(this.guna2Button2);
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.Location = new System.Drawing.Point(9, 38);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel5.TabIndex = 7;
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox1.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(205, 7);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox1.TabIndex = 14;
            this.guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox1.UseTransparentBackground = true;
            this.guna2CustomCheckBox1.Click += new System.EventHandler(this.guna2CustomCheckBox1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2Button2.BorderRadius = 2;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.DarkRed;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2Button2.Location = new System.Drawing.Point(132, 6);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(67, 20);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Load";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "AIMBOT NECK";
            // 
            // SniperPanel
            // 
            this.SniperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.SniperPanel.Controls.Add(this.label6);
            this.SniperPanel.Controls.Add(this.guna2CustomCheckBox2);
            this.SniperPanel.Controls.Add(this.guna2Button8);
            this.SniperPanel.Location = new System.Drawing.Point(9, 76);
            this.SniperPanel.Name = "SniperPanel";
            this.SniperPanel.Size = new System.Drawing.Size(233, 32);
            this.SniperPanel.TabIndex = 9;
            this.SniperPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SniperPanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "SNIPER SCOPE";
            // 
            // guna2CustomCheckBox2
            // 
            this.guna2CustomCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox2.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox2.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox2.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox2.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox2.Name = "guna2CustomCheckBox2";
            this.guna2CustomCheckBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox2.TabIndex = 7;
            this.guna2CustomCheckBox2.Text = "guna2CustomCheckBox2";
            this.guna2CustomCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox2.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox2.UseTransparentBackground = true;
            this.guna2CustomCheckBox2.Click += new System.EventHandler(this.guna2CustomCheckBox2_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2Button8.BorderRadius = 2;
            this.guna2Button8.BorderThickness = 1;
            this.guna2Button8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.guna2Button8.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button8.HoverState.CustomBorderColor = System.Drawing.Color.DarkRed;
            this.guna2Button8.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2Button8.Location = new System.Drawing.Point(132, 7);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(67, 20);
            this.guna2Button8.TabIndex = 14;
            this.guna2Button8.Text = "-";
            this.guna2Button8.UseTransparentBackground = true;
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel7.Controls.Add(this.label7);
            this.guna2Panel7.Controls.Add(this.guna2CustomCheckBox3);
            this.guna2Panel7.Location = new System.Drawing.Point(9, 114);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel7.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(10, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "SNIPER SWITCH";
            // 
            // guna2CustomCheckBox3
            // 
            this.guna2CustomCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox3.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox3.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox3.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox3.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox3.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox3.Name = "guna2CustomCheckBox3";
            this.guna2CustomCheckBox3.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox3.TabIndex = 7;
            this.guna2CustomCheckBox3.Text = "guna2CustomCheckBox3";
            this.guna2CustomCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox3.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox3.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox3.UseTransparentBackground = true;
            this.guna2CustomCheckBox3.Click += new System.EventHandler(this.guna2CustomCheckBox3_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel3.Controls.Add(this.label8);
            this.guna2Panel3.Controls.Add(this.guna2CustomCheckBox4);
            this.guna2Panel3.Location = new System.Drawing.Point(9, 152);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(10, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "GLITCH FIRE";
            // 
            // guna2CustomCheckBox4
            // 
            this.guna2CustomCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox4.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox4.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox4.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox4.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox4.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox4.Name = "guna2CustomCheckBox4";
            this.guna2CustomCheckBox4.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox4.TabIndex = 7;
            this.guna2CustomCheckBox4.Text = "guna2CustomCheckBox4";
            this.guna2CustomCheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox4.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox4.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox4.UseTransparentBackground = true;
            this.guna2CustomCheckBox4.Click += new System.EventHandler(this.guna2CustomCheckBox4_Click);
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel8.Controls.Add(this.label9);
            this.guna2Panel8.Controls.Add(this.guna2CustomCheckBox5);
            this.guna2Panel8.Location = new System.Drawing.Point(9, 190);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel8.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(10, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "VISION HACK ";
            // 
            // guna2CustomCheckBox5
            // 
            this.guna2CustomCheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox5.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox5.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox5.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox5.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox5.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox5.Name = "guna2CustomCheckBox5";
            this.guna2CustomCheckBox5.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox5.TabIndex = 7;
            this.guna2CustomCheckBox5.Text = "guna2CustomCheckBox5";
            this.guna2CustomCheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox5.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox5.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox5.UseTransparentBackground = true;
            this.guna2CustomCheckBox5.Click += new System.EventHandler(this.guna2CustomCheckBox5_Click);
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel11.Controls.Add(this.label20);
            this.guna2Panel11.Controls.Add(this.guna2CustomCheckBox10);
            this.guna2Panel11.Location = new System.Drawing.Point(9, 228);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel11.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(10, 7);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 16);
            this.label20.TabIndex = 12;
            this.label20.Text = "NO RECOIL";
            // 
            // guna2CustomCheckBox10
            // 
            this.guna2CustomCheckBox10.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox10.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox10.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox10.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox10.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox10.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox10.Name = "guna2CustomCheckBox10";
            this.guna2CustomCheckBox10.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox10.TabIndex = 7;
            this.guna2CustomCheckBox10.Text = "guna2CustomCheckBox10";
            this.guna2CustomCheckBox10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox10.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox10.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox10.UseTransparentBackground = true;
            this.guna2CustomCheckBox10.Click += new System.EventHandler(this.guna2CustomCheckBox10_Click);
            // 
            // KeyPanel
            // 
            this.KeyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.KeyPanel.Controls.Add(this.label18);
            this.KeyPanel.Controls.Add(this.MouseBtn);
            this.KeyPanel.Controls.Add(this.guna2Button6);
            this.KeyPanel.Location = new System.Drawing.Point(9, 76);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(233, 32);
            this.KeyPanel.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label18.ForeColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(10, 7);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "SNIPER KEY";
            // 
            // MouseBtn
            // 
            this.MouseBtn.BackColor = System.Drawing.Color.Transparent;
            this.MouseBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.MouseBtn.BorderThickness = 2;
            this.MouseBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.MouseBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MouseBtn.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.MouseBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.MouseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MouseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MouseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MouseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MouseBtn.FillColor = System.Drawing.Color.Transparent;
            this.MouseBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.MouseBtn.ForeColor = System.Drawing.Color.Gray;
            this.MouseBtn.HoverState.CustomBorderColor = System.Drawing.Color.DarkRed;
            this.MouseBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MouseBtn.Location = new System.Drawing.Point(86, 6);
            this.MouseBtn.Name = "MouseBtn";
            this.MouseBtn.Size = new System.Drawing.Size(67, 20);
            this.MouseBtn.TabIndex = 13;
            this.MouseBtn.Text = "🖱️";
            this.MouseBtn.UseTransparentBackground = true;
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2Button6.BorderRadius = 2;
            this.guna2Button6.BorderThickness = 1;
            this.guna2Button6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.guna2Button6.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button6.HoverState.CustomBorderColor = System.Drawing.Color.DarkRed;
            this.guna2Button6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2Button6.Location = new System.Drawing.Point(159, 6);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(67, 20);
            this.guna2Button6.TabIndex = 7;
            this.guna2Button6.Text = "⌨";
            this.guna2Button6.UseTransparentBackground = true;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel4.Controls.Add(this.label3);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(250, 31);
            this.guna2Panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(56, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "MENU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "AIMBOT";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl2.DragStartTransparencyValue = 1D;
            this.guna2DragControl2.TargetControl = this.guna2PictureBox1;
            this.guna2DragControl2.TransparentWhileDrag = false;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl3.DragStartTransparencyValue = 1D;
            this.guna2DragControl3.TargetControl = this.AimBotMenu;
            this.guna2DragControl3.TransparentWhileDrag = false;
            // 
            // EspPanel
            // 
            this.EspPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EspPanel.Controls.Add(this.guna2Panel9);
            this.EspPanel.Controls.Add(this.guna2Panel10);
            this.EspPanel.Location = new System.Drawing.Point(413, 12);
            this.EspPanel.Name = "EspPanel";
            this.EspPanel.Size = new System.Drawing.Size(250, 282);
            this.EspPanel.TabIndex = 7;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel9.Controls.Add(this.label10);
            this.guna2Panel9.Controls.Add(this.guna2CustomCheckBox6);
            this.guna2Panel9.Location = new System.Drawing.Point(9, 38);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel9.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "CHAMS MENU | ONE TIME INJECT";
            // 
            // guna2CustomCheckBox6
            // 
            this.guna2CustomCheckBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox6.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox6.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox6.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox6.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox6.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox6.Name = "guna2CustomCheckBox6";
            this.guna2CustomCheckBox6.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox6.TabIndex = 7;
            this.guna2CustomCheckBox6.Text = "guna2CustomCheckBox6";
            this.guna2CustomCheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox6.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox6.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox6.UseTransparentBackground = true;
            this.guna2CustomCheckBox6.Click += new System.EventHandler(this.guna2CustomCheckBox6_Click);
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel10.Controls.Add(this.label11);
            this.guna2Panel10.Controls.Add(this.label12);
            this.guna2Panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel10.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Size = new System.Drawing.Size(250, 31);
            this.guna2Panel10.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(36, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "MENU";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(11, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "ESP";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SettingsPanel.Controls.Add(this.guna2Panel12);
            this.SettingsPanel.Controls.Add(this.guna2Panel13);
            this.SettingsPanel.Controls.Add(this.guna2Panel14);
            this.SettingsPanel.Controls.Add(this.guna2Panel15);
            this.SettingsPanel.Location = new System.Drawing.Point(669, 12);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(250, 282);
            this.SettingsPanel.TabIndex = 8;
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel12.Controls.Add(this.label13);
            this.guna2Panel12.Controls.Add(this.guna2CustomCheckBox7);
            this.guna2Panel12.Location = new System.Drawing.Point(9, 114);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel12.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(10, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "PIN ON TOP";
            // 
            // guna2CustomCheckBox7
            // 
            this.guna2CustomCheckBox7.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox7.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox7.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox7.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox7.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox7.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox7.Name = "guna2CustomCheckBox7";
            this.guna2CustomCheckBox7.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox7.TabIndex = 7;
            this.guna2CustomCheckBox7.Text = "guna2CustomCheckBox7";
            this.guna2CustomCheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox7.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox7.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox7.UseTransparentBackground = true;
            this.guna2CustomCheckBox7.Click += new System.EventHandler(this.guna2CustomCheckBox7_Click);
            // 
            // guna2Panel13
            // 
            this.guna2Panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel13.Controls.Add(this.label14);
            this.guna2Panel13.Controls.Add(this.guna2CustomCheckBox8);
            this.guna2Panel13.Location = new System.Drawing.Point(9, 76);
            this.guna2Panel13.Name = "guna2Panel13";
            this.guna2Panel13.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel13.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(10, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "RESET GUEST";
            // 
            // guna2CustomCheckBox8
            // 
            this.guna2CustomCheckBox8.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox8.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox8.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox8.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox8.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox8.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox8.Name = "guna2CustomCheckBox8";
            this.guna2CustomCheckBox8.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox8.TabIndex = 7;
            this.guna2CustomCheckBox8.Text = "guna2CustomCheckBox8";
            this.guna2CustomCheckBox8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox8.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox8.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox8.UseTransparentBackground = true;
            this.guna2CustomCheckBox8.Click += new System.EventHandler(this.guna2CustomCheckBox8_Click);
            // 
            // guna2Panel14
            // 
            this.guna2Panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel14.Controls.Add(this.label15);
            this.guna2Panel14.Controls.Add(this.guna2CustomCheckBox9);
            this.guna2Panel14.Location = new System.Drawing.Point(9, 38);
            this.guna2Panel14.Name = "guna2Panel14";
            this.guna2Panel14.Size = new System.Drawing.Size(233, 32);
            this.guna2Panel14.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(10, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "STREAMER MODE";
            // 
            // guna2CustomCheckBox9
            // 
            this.guna2CustomCheckBox9.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox9.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox9.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox9.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomCheckBox9.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox9.Location = new System.Drawing.Point(205, 6);
            this.guna2CustomCheckBox9.Name = "guna2CustomCheckBox9";
            this.guna2CustomCheckBox9.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox9.TabIndex = 7;
            this.guna2CustomCheckBox9.Text = "guna2CustomCheckBox9";
            this.guna2CustomCheckBox9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.guna2CustomCheckBox9.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox9.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2CustomCheckBox9.UseTransparentBackground = true;
            this.guna2CustomCheckBox9.Click += new System.EventHandler(this.guna2CustomCheckBox9_Click);
            // 
            // guna2Panel15
            // 
            this.guna2Panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.guna2Panel15.Controls.Add(this.label16);
            this.guna2Panel15.Controls.Add(this.label17);
            this.guna2Panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel15.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel15.Name = "guna2Panel15";
            this.guna2Panel15.Size = new System.Drawing.Size(250, 31);
            this.guna2Panel15.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(64, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "MENU";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label17.Location = new System.Drawing.Point(11, 7);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "SETTINGS";
            // 
            // LoginPnl
            // 
            this.LoginPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LoginPnl.Controls.Add(this.guna2ImageButton1);
            this.LoginPnl.Controls.Add(this.label1);
            this.LoginPnl.Controls.Add(this.guna2CircleButton2);
            this.LoginPnl.Controls.Add(this.guna2CircleButton1);
            this.LoginPnl.Controls.Add(this.password);
            this.LoginPnl.Controls.Add(this.username);
            this.LoginPnl.Controls.Add(this.guna2Button1);
            this.LoginPnl.Location = new System.Drawing.Point(12, 8);
            this.LoginPnl.Name = "LoginPnl";
            this.LoginPnl.Size = new System.Drawing.Size(388, 289);
            this.LoginPnl.TabIndex = 9;
            this.LoginPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPnl_Paint);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(0, 4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(72, 51);
            this.guna2ImageButton1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(67, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "VXC CORPORATION";
            // 
            // password
            // 
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.password.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.password.Location = new System.Drawing.Point(73, 153);
            this.password.Name = "password";
            this.password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password.PlaceholderText = "PASSWORD";
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(240, 32);
            this.password.TabIndex = 11;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.username.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.username.Location = new System.Drawing.Point(73, 109);
            this.username.Name = "username";
            this.username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.username.PlaceholderText = "USERNAME";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(240, 32);
            this.username.TabIndex = 10;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(73, 209);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(240, 30);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "LOGIN";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl4.DragStartTransparencyValue = 1D;
            this.guna2DragControl4.TransparentWhileDrag = false;
            // 
            // guna2DragControl5
            // 
            this.guna2DragControl5.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl5.DragStartTransparencyValue = 1D;
            this.guna2DragControl5.TargetControl = this.EspPanel;
            this.guna2DragControl5.TransparentWhileDrag = false;
            // 
            // guna2DragControl6
            // 
            this.guna2DragControl6.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl6.DragStartTransparencyValue = 1D;
            this.guna2DragControl6.TargetControl = this.SettingsPanel;
            this.guna2DragControl6.TransparentWhileDrag = false;
            // 
            // guna2DragControl7
            // 
            this.guna2DragControl7.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl7.DragStartTransparencyValue = 1D;
            this.guna2DragControl7.TargetControl = this.LoginPnl;
            this.guna2DragControl7.TransparentWhileDrag = false;
            // 
            // guna2DragControl8
            // 
            this.guna2DragControl8.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl8.DragStartTransparencyValue = 1D;
            this.guna2DragControl8.TargetControl = this.guna2Panel1;
            this.guna2DragControl8.TransparentWhileDrag = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(408, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.EspPanel);
            this.Controls.Add(this.S);
            this.Controls.Add(this.LoginPnl);
            this.Controls.Add(this.AimBotMenu);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhantomXiters";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.AimBotMenu.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.SniperPanel.ResumeLayout(false);
            this.SniperPanel.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.guna2Panel11.ResumeLayout(false);
            this.guna2Panel11.PerformLayout();
            this.KeyPanel.ResumeLayout(false);
            this.KeyPanel.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.EspPanel.ResumeLayout(false);
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel9.PerformLayout();
            this.guna2Panel10.ResumeLayout(false);
            this.guna2Panel10.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.guna2Panel12.ResumeLayout(false);
            this.guna2Panel12.PerformLayout();
            this.guna2Panel13.ResumeLayout(false);
            this.guna2Panel13.PerformLayout();
            this.guna2Panel14.ResumeLayout(false);
            this.guna2Panel14.PerformLayout();
            this.guna2Panel15.ResumeLayout(false);
            this.guna2Panel15.PerformLayout();
            this.LoginPnl.ResumeLayout(false);
            this.LoginPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Guna2Panel guna2Panel1;
        private Guna2Button guna2Button3;
        private Guna2PictureBox guna2PictureBox1;
        private Guna2Panel AimBotMenu;
        private Guna2Button guna2Button5;
        private Guna2Button guna2Button4;
        private Guna2Panel guna2Panel4;
        private Guna2Panel guna2Panel5;
        private Guna2Panel guna2Panel7;
        private Guna2CustomCheckBox guna2CustomCheckBox3;
        private Guna2Panel SniperPanel;
        private Guna2CustomCheckBox guna2CustomCheckBox2;
        private Guna2Button guna2Button6;
        private Guna2DragControl guna2DragControl1;
        private Guna2DragControl guna2DragControl2;
        private Guna2DragControl guna2DragControl3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Guna2CircleButton guna2CircleButton2;
        private Guna2CircleButton guna2CircleButton1;
        private Guna2Panel SettingsPanel;
        private Guna2Panel guna2Panel12;
        private Label label13;
        private Guna2CustomCheckBox guna2CustomCheckBox7;
        private Guna2Panel guna2Panel13;
        private Label label14;
        private Guna2CustomCheckBox guna2CustomCheckBox8;
        private Guna2Panel guna2Panel14;
        private Label label15;
        private Guna2CustomCheckBox guna2CustomCheckBox9;
        private Guna2Panel guna2Panel15;
        private Label label16;
        private Label label17;
        private Guna2Panel EspPanel;
        private Guna2Panel guna2Panel9;
        private Label label10;
        private Guna2CustomCheckBox guna2CustomCheckBox6;
        private Guna2Panel guna2Panel10;
        private Label label11;
        private Label label12;
        private Guna2Panel guna2Panel8;
        private Label label9;
        private Guna2CustomCheckBox guna2CustomCheckBox5;
        private Guna2Panel guna2Panel11;
        private Label label20;
        private Guna2CustomCheckBox guna2CustomCheckBox10;
        private Guna2Panel guna2Panel3;
        private Label label8;
        private Guna2CustomCheckBox guna2CustomCheckBox4;
        private Guna2Panel LoginPnl;
        private Guna2Button guna2Button1;
        private Guna2TextBox username;
        private Guna2TextBox password;
        private Guna2DragControl guna2DragControl4;
        private Guna2DragControl guna2DragControl5;
        private Guna2DragControl guna2DragControl6;
        private Guna2DragControl guna2DragControl7;
        private Guna2DragControl guna2DragControl8;
        private Guna2Button guna2Button2;
        private Guna2Button MouseBtn;
        private Guna2Panel KeyPanel;
        private Label label18;
        private Guna2Button guna2Button8;
        private Guna2CustomCheckBox guna2CustomCheckBox1;
        private Label label1;
        private Guna2ImageButton guna2ImageButton1;
    }
}
