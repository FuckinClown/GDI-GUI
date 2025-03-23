namespace GDI_GUI
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Title = new Label();
            chk_tunnel = new CheckBox();
            lbl_pleasedontremove = new Label();
            chk_dvdball = new CheckBox();
            chk_dvdText = new CheckBox();
            txt_dvdText = new TextBox();
            btn_build = new Button();
            chk_growingSquares = new CheckBox();
            chk_fractal = new CheckBox();
            chk_static = new CheckBox();
            chk_invertSquares = new CheckBox();
            chk_invertSpam = new CheckBox();
            chk_iconSpam = new CheckBox();
            lbl_time = new Label();
            num_time = new NumericUpDown();
            chk_synchronis = new CheckBox();
            chk_blockInput = new CheckBox();
            chk_rainbowPuke = new CheckBox();
            chk_smear = new CheckBox();
            chk_killwalls = new CheckBox();
            chk_clear = new CheckBox();
            chk_shake = new CheckBox();
            box_options = new GroupBox();
            titleBar = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            box_timesheet = new GroupBox();
            btn_down = new Button();
            btn_up = new Button();
            lst_timesheet = new ListBox();
            box_build = new GroupBox();
            btn_clear = new Button();
            lbl_compiler_location = new Label();
            lbl_underline1 = new Label();
            lbl_compiler_loc_title = new Label();
            box_payloads = new GroupBox();
            num_runaway = new NumericUpDown();
            txt_runaway_speed = new Label();
            chk_runaway = new CheckBox();
            num_dvdball = new NumericUpDown();
            lbl_dvdball_size = new Label();
            chk_squarefractal = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)num_time).BeginInit();
            box_options.SuspendLayout();
            titleBar.SuspendLayout();
            box_timesheet.SuspendLayout();
            box_build.SuspendLayout();
            box_payloads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_runaway).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_dvdball).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.DarkGray;
            lbl_Title.Location = new Point(6, 1);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(85, 24);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "GDI-GUI";
            // 
            // chk_tunnel
            // 
            chk_tunnel.AutoSize = true;
            chk_tunnel.Location = new Point(5, 15);
            chk_tunnel.Name = "chk_tunnel";
            chk_tunnel.Size = new Size(62, 19);
            chk_tunnel.TabIndex = 1;
            chk_tunnel.Text = "Tunnel";
            chk_tunnel.UseVisualStyleBackColor = true;
            chk_tunnel.CheckedChanged += chk_tunnel_CheckedChanged;
            // 
            // lbl_pleasedontremove
            // 
            lbl_pleasedontremove.AutoSize = true;
            lbl_pleasedontremove.Location = new Point(82, 106);
            lbl_pleasedontremove.Name = "lbl_pleasedontremove";
            lbl_pleasedontremove.Size = new Size(94, 15);
            lbl_pleasedontremove.TabIndex = 2;
            lbl_pleasedontremove.Text = "Made by Fclown";
            // 
            // chk_dvdball
            // 
            chk_dvdball.AutoSize = true;
            chk_dvdball.Location = new Point(5, 138);
            chk_dvdball.Name = "chk_dvdball";
            chk_dvdball.Size = new Size(71, 19);
            chk_dvdball.TabIndex = 3;
            chk_dvdball.Text = "DVD Ball";
            chk_dvdball.UseVisualStyleBackColor = true;
            chk_dvdball.CheckedChanged += chk_dvdball_CheckedChanged;
            // 
            // chk_dvdText
            // 
            chk_dvdText.AutoSize = true;
            chk_dvdText.Location = new Point(5, 186);
            chk_dvdText.Name = "chk_dvdText";
            chk_dvdText.Size = new Size(73, 19);
            chk_dvdText.TabIndex = 4;
            chk_dvdText.Text = "DVD Text";
            chk_dvdText.UseVisualStyleBackColor = true;
            chk_dvdText.CheckedChanged += chk_dvdText_CheckedChanged;
            // 
            // txt_dvdText
            // 
            txt_dvdText.BackColor = Color.FromArgb(17, 17, 17);
            txt_dvdText.ForeColor = Color.Silver;
            txt_dvdText.Location = new Point(83, 184);
            txt_dvdText.Name = "txt_dvdText";
            txt_dvdText.Size = new Size(136, 23);
            txt_dvdText.TabIndex = 5;
            txt_dvdText.Text = "oops!";
            txt_dvdText.Visible = false;
            // 
            // btn_build
            // 
            btn_build.BackColor = Color.FromArgb(17, 17, 17);
            btn_build.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btn_build.FlatAppearance.MouseOverBackColor = Color.FromArgb(57, 57, 57);
            btn_build.FlatStyle = FlatStyle.Flat;
            btn_build.Font = new Font("Segoe UI", 9F);
            btn_build.ForeColor = Color.WhiteSmoke;
            btn_build.Location = new Point(6, 88);
            btn_build.Name = "btn_build";
            btn_build.Size = new Size(75, 28);
            btn_build.TabIndex = 6;
            btn_build.Text = "Build";
            btn_build.UseVisualStyleBackColor = false;
            btn_build.Click += btn_build_Click;
            // 
            // chk_growingSquares
            // 
            chk_growingSquares.AutoSize = true;
            chk_growingSquares.Location = new Point(209, 15);
            chk_growingSquares.Name = "chk_growingSquares";
            chk_growingSquares.Size = new Size(115, 19);
            chk_growingSquares.TabIndex = 9;
            chk_growingSquares.Text = "Growing Squares";
            chk_growingSquares.UseVisualStyleBackColor = true;
            chk_growingSquares.CheckedChanged += chk_growingSquares_CheckedChanged;
            // 
            // chk_fractal
            // 
            chk_fractal.AutoSize = true;
            chk_fractal.Location = new Point(5, 63);
            chk_fractal.Name = "chk_fractal";
            chk_fractal.Size = new Size(61, 19);
            chk_fractal.TabIndex = 8;
            chk_fractal.Text = "Fractal";
            chk_fractal.UseVisualStyleBackColor = true;
            chk_fractal.CheckedChanged += chk_fractal_CheckedChanged;
            // 
            // chk_static
            // 
            chk_static.AutoSize = true;
            chk_static.Location = new Point(207, 135);
            chk_static.Name = "chk_static";
            chk_static.Size = new Size(55, 19);
            chk_static.TabIndex = 7;
            chk_static.Text = "Static";
            chk_static.UseVisualStyleBackColor = true;
            chk_static.CheckedChanged += chk_static_CheckedChanged;
            // 
            // chk_invertSquares
            // 
            chk_invertSquares.AutoSize = true;
            chk_invertSquares.Location = new Point(209, 63);
            chk_invertSquares.Name = "chk_invertSquares";
            chk_invertSquares.Size = new Size(100, 19);
            chk_invertSquares.TabIndex = 10;
            chk_invertSquares.Text = "Invert Squares";
            chk_invertSquares.UseVisualStyleBackColor = true;
            chk_invertSquares.CheckedChanged += chk_invertSquares_CheckedChanged;
            // 
            // chk_invertSpam
            // 
            chk_invertSpam.AutoSize = true;
            chk_invertSpam.Location = new Point(208, 88);
            chk_invertSpam.Name = "chk_invertSpam";
            chk_invertSpam.Size = new Size(89, 19);
            chk_invertSpam.TabIndex = 11;
            chk_invertSpam.Text = "Invert Spam";
            chk_invertSpam.UseVisualStyleBackColor = true;
            chk_invertSpam.CheckedChanged += chk_invertSpam_CheckedChanged;
            // 
            // chk_iconSpam
            // 
            chk_iconSpam.AutoSize = true;
            chk_iconSpam.Location = new Point(208, 113);
            chk_iconSpam.Name = "chk_iconSpam";
            chk_iconSpam.Size = new Size(82, 19);
            chk_iconSpam.TabIndex = 12;
            chk_iconSpam.Text = "Icon Spam";
            chk_iconSpam.UseVisualStyleBackColor = true;
            chk_iconSpam.CheckedChanged += chk_iconSpam_CheckedChanged;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(6, 19);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(104, 15);
            lbl_time.TabIndex = 13;
            lbl_time.Text = "Seconds Per Effect";
            // 
            // num_time
            // 
            num_time.BackColor = Color.FromArgb(17, 17, 17);
            num_time.ForeColor = Color.Silver;
            num_time.Location = new Point(116, 17);
            num_time.Name = "num_time";
            num_time.Size = new Size(86, 23);
            num_time.TabIndex = 14;
            num_time.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // chk_synchronis
            // 
            chk_synchronis.AutoSize = true;
            chk_synchronis.Location = new Point(14, 47);
            chk_synchronis.Name = "chk_synchronis";
            chk_synchronis.Size = new Size(128, 19);
            chk_synchronis.TabIndex = 15;
            chk_synchronis.Text = "Run Synchronously";
            chk_synchronis.UseVisualStyleBackColor = true;
            chk_synchronis.CheckedChanged += chk_threadEverything_CheckedChanged;
            // 
            // chk_blockInput
            // 
            chk_blockInput.AutoSize = true;
            chk_blockInput.Location = new Point(141, 78);
            chk_blockInput.Name = "chk_blockInput";
            chk_blockInput.Size = new Size(121, 19);
            chk_blockInput.TabIndex = 16;
            chk_blockInput.Text = "Block input (UAC)";
            chk_blockInput.UseVisualStyleBackColor = true;
            // 
            // chk_rainbowPuke
            // 
            chk_rainbowPuke.AutoSize = true;
            chk_rainbowPuke.Location = new Point(5, 40);
            chk_rainbowPuke.Name = "chk_rainbowPuke";
            chk_rainbowPuke.Size = new Size(101, 19);
            chk_rainbowPuke.TabIndex = 17;
            chk_rainbowPuke.Text = "Rainbow Puke";
            chk_rainbowPuke.UseVisualStyleBackColor = true;
            chk_rainbowPuke.CheckedChanged += chk_rainbowPuke_CheckedChanged;
            // 
            // chk_smear
            // 
            chk_smear.AutoSize = true;
            chk_smear.Location = new Point(209, 40);
            chk_smear.Name = "chk_smear";
            chk_smear.Size = new Size(59, 19);
            chk_smear.TabIndex = 18;
            chk_smear.Text = "Smear";
            chk_smear.UseVisualStyleBackColor = true;
            chk_smear.CheckedChanged += chk_smear_CheckedChanged;
            // 
            // chk_killwalls
            // 
            chk_killwalls.AutoSize = true;
            chk_killwalls.Location = new Point(141, 47);
            chk_killwalls.Name = "chk_killwalls";
            chk_killwalls.Size = new Size(98, 19);
            chk_killwalls.TabIndex = 19;
            chk_killwalls.Text = "Kill Wallpaper";
            chk_killwalls.UseVisualStyleBackColor = true;
            // 
            // chk_clear
            // 
            chk_clear.AutoSize = true;
            chk_clear.Location = new Point(14, 78);
            chk_clear.Name = "chk_clear";
            chk_clear.Size = new Size(91, 19);
            chk_clear.TabIndex = 20;
            chk_clear.Text = "Clear Screen";
            chk_clear.UseVisualStyleBackColor = true;
            // 
            // chk_shake
            // 
            chk_shake.AutoSize = true;
            chk_shake.Location = new Point(5, 113);
            chk_shake.Name = "chk_shake";
            chk_shake.Size = new Size(57, 19);
            chk_shake.TabIndex = 21;
            chk_shake.Text = "Shake";
            chk_shake.UseVisualStyleBackColor = true;
            chk_shake.CheckedChanged += chk_shake_CheckedChanged;
            // 
            // box_options
            // 
            box_options.Controls.Add(lbl_time);
            box_options.Controls.Add(num_time);
            box_options.Controls.Add(lbl_pleasedontremove);
            box_options.Controls.Add(chk_clear);
            box_options.Controls.Add(chk_killwalls);
            box_options.Controls.Add(chk_synchronis);
            box_options.Controls.Add(chk_blockInput);
            box_options.ForeColor = Color.White;
            box_options.Location = new Point(5, 247);
            box_options.Name = "box_options";
            box_options.Size = new Size(268, 124);
            box_options.TabIndex = 22;
            box_options.TabStop = false;
            box_options.Text = "Options";
            // 
            // titleBar
            // 
            titleBar.Controls.Add(btn_minimize);
            titleBar.Controls.Add(btn_close);
            titleBar.Controls.Add(lbl_Title);
            titleBar.Dock = DockStyle.Top;
            titleBar.Location = new Point(0, 0);
            titleBar.Name = "titleBar";
            titleBar.Size = new Size(622, 25);
            titleBar.TabIndex = 23;
            titleBar.MouseDown += titleBar_MouseDown;
            // 
            // btn_minimize
            // 
            btn_minimize.BackgroundImage = Properties.Resources.minimize;
            btn_minimize.BackgroundImageLayout = ImageLayout.Center;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Location = new Point(579, 9);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(16, 16);
            btn_minimize.TabIndex = 24;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = Properties.Resources.close;
            btn_close.BackgroundImageLayout = ImageLayout.Center;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Location = new Point(601, 6);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(16, 16);
            btn_close.TabIndex = 24;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // box_timesheet
            // 
            box_timesheet.Controls.Add(btn_down);
            box_timesheet.Controls.Add(btn_up);
            box_timesheet.Controls.Add(lst_timesheet);
            box_timesheet.ForeColor = Color.WhiteSmoke;
            box_timesheet.Location = new Point(341, 24);
            box_timesheet.Name = "box_timesheet";
            box_timesheet.Size = new Size(276, 217);
            box_timesheet.TabIndex = 24;
            box_timesheet.TabStop = false;
            box_timesheet.Text = "Timesheet";
            // 
            // btn_down
            // 
            btn_down.BackColor = Color.FromArgb(30, 30, 30);
            btn_down.BackgroundImage = Properties.Resources.arrow_down;
            btn_down.BackgroundImageLayout = ImageLayout.Center;
            btn_down.FlatAppearance.BorderSize = 2;
            btn_down.FlatStyle = FlatStyle.Flat;
            btn_down.ForeColor = Color.White;
            btn_down.Location = new Point(244, 113);
            btn_down.Name = "btn_down";
            btn_down.Size = new Size(25, 25);
            btn_down.TabIndex = 2;
            btn_down.UseVisualStyleBackColor = false;
            btn_down.Click += btn_down_Click;
            // 
            // btn_up
            // 
            btn_up.BackColor = Color.FromArgb(30, 30, 30);
            btn_up.BackgroundImage = Properties.Resources.arrow_up;
            btn_up.BackgroundImageLayout = ImageLayout.Center;
            btn_up.FlatAppearance.BorderSize = 2;
            btn_up.FlatStyle = FlatStyle.Flat;
            btn_up.ForeColor = Color.White;
            btn_up.Location = new Point(244, 82);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(25, 25);
            btn_up.TabIndex = 1;
            btn_up.UseVisualStyleBackColor = false;
            btn_up.Click += btn_up_Click;
            // 
            // lst_timesheet
            // 
            lst_timesheet.BackColor = Color.FromArgb(17, 17, 17);
            lst_timesheet.BorderStyle = BorderStyle.FixedSingle;
            lst_timesheet.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lst_timesheet.ForeColor = SystemColors.ScrollBar;
            lst_timesheet.FormattingEnabled = true;
            lst_timesheet.ItemHeight = 18;
            lst_timesheet.Location = new Point(6, 15);
            lst_timesheet.Name = "lst_timesheet";
            lst_timesheet.Size = new Size(233, 200);
            lst_timesheet.TabIndex = 0;
            // 
            // box_build
            // 
            box_build.Controls.Add(btn_clear);
            box_build.Controls.Add(lbl_compiler_location);
            box_build.Controls.Add(lbl_underline1);
            box_build.Controls.Add(lbl_compiler_loc_title);
            box_build.Controls.Add(btn_build);
            box_build.ForeColor = Color.WhiteSmoke;
            box_build.Location = new Point(279, 247);
            box_build.Name = "box_build";
            box_build.Size = new Size(338, 124);
            box_build.TabIndex = 26;
            box_build.TabStop = false;
            box_build.Text = "Build";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(17, 17, 17);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.DarkGray;
            btn_clear.Location = new Point(256, 88);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 28);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // lbl_compiler_location
            // 
            lbl_compiler_location.ForeColor = Color.DarkGray;
            lbl_compiler_location.Location = new Point(6, 35);
            lbl_compiler_location.Name = "lbl_compiler_location";
            lbl_compiler_location.Size = new Size(325, 23);
            lbl_compiler_location.TabIndex = 8;
            lbl_compiler_location.Text = "Default";
            lbl_compiler_location.TextAlign = ContentAlignment.MiddleCenter;
            lbl_compiler_location.Click += lbl_compiler_location_Click;
            // 
            // lbl_underline1
            // 
            lbl_underline1.ForeColor = Color.Silver;
            lbl_underline1.Location = new Point(6, 43);
            lbl_underline1.Name = "lbl_underline1";
            lbl_underline1.Size = new Size(325, 23);
            lbl_underline1.TabIndex = 9;
            lbl_underline1.Text = "____________________________________________________________";
            lbl_underline1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_compiler_loc_title
            // 
            lbl_compiler_loc_title.AutoSize = true;
            lbl_compiler_loc_title.Location = new Point(6, 18);
            lbl_compiler_loc_title.Name = "lbl_compiler_loc_title";
            lbl_compiler_loc_title.Size = new Size(135, 15);
            lbl_compiler_loc_title.TabIndex = 7;
            lbl_compiler_loc_title.Text = "G++ Compiler Location:";
            // 
            // box_payloads
            // 
            box_payloads.Controls.Add(chk_squarefractal);
            box_payloads.Controls.Add(num_runaway);
            box_payloads.Controls.Add(txt_runaway_speed);
            box_payloads.Controls.Add(chk_runaway);
            box_payloads.Controls.Add(num_dvdball);
            box_payloads.Controls.Add(lbl_dvdball_size);
            box_payloads.Controls.Add(chk_tunnel);
            box_payloads.Controls.Add(chk_dvdball);
            box_payloads.Controls.Add(chk_dvdText);
            box_payloads.Controls.Add(txt_dvdText);
            box_payloads.Controls.Add(chk_rainbowPuke);
            box_payloads.Controls.Add(chk_static);
            box_payloads.Controls.Add(chk_shake);
            box_payloads.Controls.Add(chk_fractal);
            box_payloads.Controls.Add(chk_iconSpam);
            box_payloads.Controls.Add(chk_smear);
            box_payloads.Controls.Add(chk_invertSpam);
            box_payloads.Controls.Add(chk_growingSquares);
            box_payloads.Controls.Add(chk_invertSquares);
            box_payloads.ForeColor = Color.WhiteSmoke;
            box_payloads.Location = new Point(5, 24);
            box_payloads.Name = "box_payloads";
            box_payloads.Size = new Size(330, 217);
            box_payloads.TabIndex = 25;
            box_payloads.TabStop = false;
            box_payloads.Text = "Payloads";
            // 
            // num_runaway
            // 
            num_runaway.BackColor = Color.FromArgb(17, 17, 17);
            num_runaway.ForeColor = Color.Silver;
            num_runaway.Location = new Point(164, 160);
            num_runaway.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_runaway.Name = "num_runaway";
            num_runaway.Size = new Size(55, 23);
            num_runaway.TabIndex = 26;
            num_runaway.Value = new decimal(new int[] { 10, 0, 0, 0 });
            num_runaway.Visible = false;
            // 
            // txt_runaway_speed
            // 
            txt_runaway_speed.AutoSize = true;
            txt_runaway_speed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_runaway_speed.Location = new Point(118, 163);
            txt_runaway_speed.Name = "txt_runaway_speed";
            txt_runaway_speed.Size = new Size(45, 15);
            txt_runaway_speed.TabIndex = 25;
            txt_runaway_speed.Text = "Speed:";
            txt_runaway_speed.Visible = false;
            // 
            // chk_runaway
            // 
            chk_runaway.AutoSize = true;
            chk_runaway.Location = new Point(5, 161);
            chk_runaway.Name = "chk_runaway";
            chk_runaway.Size = new Size(112, 19);
            chk_runaway.TabIndex = 24;
            chk_runaway.Text = "Runaway Screen";
            chk_runaway.UseVisualStyleBackColor = true;
            chk_runaway.CheckedChanged += chk_runaway_CheckedChanged;
            // 
            // num_dvdball
            // 
            num_dvdball.BackColor = Color.FromArgb(17, 17, 17);
            num_dvdball.ForeColor = Color.Silver;
            num_dvdball.Location = new Point(112, 136);
            num_dvdball.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_dvdball.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_dvdball.Name = "num_dvdball";
            num_dvdball.Size = new Size(67, 23);
            num_dvdball.TabIndex = 23;
            num_dvdball.Value = new decimal(new int[] { 170, 0, 0, 0 });
            num_dvdball.Visible = false;
            // 
            // lbl_dvdball_size
            // 
            lbl_dvdball_size.AutoSize = true;
            lbl_dvdball_size.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_dvdball_size.Location = new Point(77, 139);
            lbl_dvdball_size.Name = "lbl_dvdball_size";
            lbl_dvdball_size.Size = new Size(33, 15);
            lbl_dvdball_size.TabIndex = 22;
            lbl_dvdball_size.Text = "Size:";
            lbl_dvdball_size.Visible = false;
            // 
            // chk_squarefractal
            // 
            chk_squarefractal.AutoSize = true;
            chk_squarefractal.Location = new Point(5, 88);
            chk_squarefractal.Name = "chk_squarefractal";
            chk_squarefractal.Size = new Size(100, 19);
            chk_squarefractal.TabIndex = 27;
            chk_squarefractal.Text = "Square Fractal";
            chk_squarefractal.UseVisualStyleBackColor = true;
            chk_squarefractal.CheckedChanged += chk_squarefractal_CheckedChanged;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(622, 383);
            Controls.Add(box_payloads);
            Controls.Add(box_timesheet);
            Controls.Add(box_build);
            Controls.Add(titleBar);
            Controls.Add(box_options);
            ForeColor = Color.DarkGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GDI-GUI";
            Load += frm_Main_bak_Load;
            ((System.ComponentModel.ISupportInitialize)num_time).EndInit();
            box_options.ResumeLayout(false);
            box_options.PerformLayout();
            titleBar.ResumeLayout(false);
            titleBar.PerformLayout();
            box_timesheet.ResumeLayout(false);
            box_build.ResumeLayout(false);
            box_build.PerformLayout();
            box_payloads.ResumeLayout(false);
            box_payloads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_runaway).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_dvdball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Title;
        private CheckBox chk_tunnel;
        private Label lbl_pleasedontremove;
        private CheckBox chk_dvdball;
        private CheckBox chk_dvdText;
        private TextBox txt_dvdText;
        private Button btn_build;
        private CheckBox chk_growingSquares;
        private CheckBox chk_fractal;
        private CheckBox chk_static;
        private CheckBox chk_invertSquares;
        private CheckBox chk_invertSpam;
        private CheckBox chk_iconSpam;
        private Label lbl_time;
        private NumericUpDown num_time;
        private CheckBox chk_synchronis;
        private CheckBox chk_blockInput;
        private CheckBox chk_rainbowPuke;
        private CheckBox chk_smear;
        private CheckBox chk_killwalls;
        private CheckBox chk_clear;
        private CheckBox chk_shake;
        private GroupBox box_options;
        private Panel titleBar;
        private Button btn_close;
        private Button btn_minimize;
        private GroupBox box_timesheet;
        private Button btn_down;
        private Button btn_up;
        private ListBox lst_timesheet;
        private GroupBox box_build;
        private GroupBox box_payloads;
        private Label lbl_compiler_loc_title;
        private Label lbl_compiler_location;
        private Label lbl_underline1;
        private Button btn_clear;
        private Label lbl_dvdball_size;
        private NumericUpDown num_dvdball;
        private CheckBox chk_runaway;
        private NumericUpDown num_runaway;
        private Label txt_runaway_speed;
        private CheckBox chk_squarefractal;
    }
}
