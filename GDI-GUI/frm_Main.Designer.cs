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
            chk_growingShapes = new CheckBox();
            chk_fractal = new CheckBox();
            chk_static = new CheckBox();
            chk_invertSquares = new CheckBox();
            chk_invertSpam = new CheckBox();
            chk_iconSpam = new CheckBox();
            lbl_time = new Label();
            num_time = new NumericUpDown();
            chk_threadEverything = new CheckBox();
            chk_blockInput = new CheckBox();
            chk_rainbowPuke = new CheckBox();
            chk_shake = new CheckBox();
            chk_killwalls = new CheckBox();
            chk_clear = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)num_time).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.DarkGray;
            lbl_Title.Location = new Point(12, 7);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(418, 29);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "----------GDI-GUI----------";
            // 
            // chk_tunnel
            // 
            chk_tunnel.AutoSize = true;
            chk_tunnel.Location = new Point(12, 39);
            chk_tunnel.Name = "chk_tunnel";
            chk_tunnel.Size = new Size(62, 19);
            chk_tunnel.TabIndex = 1;
            chk_tunnel.Text = "Tunnel";
            chk_tunnel.UseVisualStyleBackColor = true;
            // 
            // lbl_pleasedontremove
            // 
            lbl_pleasedontremove.AutoSize = true;
            lbl_pleasedontremove.Location = new Point(336, 1);
            lbl_pleasedontremove.Name = "lbl_pleasedontremove";
            lbl_pleasedontremove.Size = new Size(94, 15);
            lbl_pleasedontremove.TabIndex = 2;
            lbl_pleasedontremove.Text = "Made by Fclown";
            // 
            // chk_dvdball
            // 
            chk_dvdball.AutoSize = true;
            chk_dvdball.Location = new Point(12, 64);
            chk_dvdball.Name = "chk_dvdball";
            chk_dvdball.Size = new Size(71, 19);
            chk_dvdball.TabIndex = 3;
            chk_dvdball.Text = "DVD Ball";
            chk_dvdball.UseVisualStyleBackColor = true;
            // 
            // chk_dvdText
            // 
            chk_dvdText.AutoSize = true;
            chk_dvdText.Location = new Point(12, 89);
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
            txt_dvdText.Location = new Point(91, 87);
            txt_dvdText.Name = "txt_dvdText";
            txt_dvdText.Size = new Size(100, 23);
            txt_dvdText.TabIndex = 5;
            txt_dvdText.Text = "oops!";
            txt_dvdText.Visible = false;
            // 
            // btn_build
            // 
            btn_build.BackColor = Color.FromArgb(57, 57, 57);
            btn_build.FlatAppearance.BorderSize = 0;
            btn_build.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btn_build.FlatAppearance.MouseOverBackColor = Color.FromArgb(57, 57, 57);
            btn_build.FlatStyle = FlatStyle.Flat;
            btn_build.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_build.ForeColor = Color.Silver;
            btn_build.Location = new Point(165, 189);
            btn_build.Name = "btn_build";
            btn_build.Size = new Size(118, 27);
            btn_build.TabIndex = 6;
            btn_build.Text = "Build";
            btn_build.UseVisualStyleBackColor = false;
            btn_build.Click += btn_build_Click;
            // 
            // chk_growingShapes
            // 
            chk_growingShapes.AutoSize = true;
            chk_growingShapes.Location = new Point(194, 91);
            chk_growingShapes.Name = "chk_growingShapes";
            chk_growingShapes.Size = new Size(111, 19);
            chk_growingShapes.TabIndex = 9;
            chk_growingShapes.Text = "Growing Shapes";
            chk_growingShapes.UseVisualStyleBackColor = true;
            // 
            // chk_fractal
            // 
            chk_fractal.AutoSize = true;
            chk_fractal.Location = new Point(194, 66);
            chk_fractal.Name = "chk_fractal";
            chk_fractal.Size = new Size(61, 19);
            chk_fractal.TabIndex = 8;
            chk_fractal.Text = "Fractal";
            chk_fractal.UseVisualStyleBackColor = true;
            // 
            // chk_static
            // 
            chk_static.AutoSize = true;
            chk_static.Location = new Point(194, 41);
            chk_static.Name = "chk_static";
            chk_static.Size = new Size(55, 19);
            chk_static.TabIndex = 7;
            chk_static.Text = "Static";
            chk_static.UseVisualStyleBackColor = true;
            // 
            // chk_invertSquares
            // 
            chk_invertSquares.AutoSize = true;
            chk_invertSquares.Location = new Point(311, 39);
            chk_invertSquares.Name = "chk_invertSquares";
            chk_invertSquares.Size = new Size(100, 19);
            chk_invertSquares.TabIndex = 10;
            chk_invertSquares.Text = "Invert Squares";
            chk_invertSquares.UseVisualStyleBackColor = true;
            // 
            // chk_invertSpam
            // 
            chk_invertSpam.AutoSize = true;
            chk_invertSpam.Location = new Point(311, 66);
            chk_invertSpam.Name = "chk_invertSpam";
            chk_invertSpam.Size = new Size(89, 19);
            chk_invertSpam.TabIndex = 11;
            chk_invertSpam.Text = "Invert Spam";
            chk_invertSpam.UseVisualStyleBackColor = true;
            // 
            // chk_iconSpam
            // 
            chk_iconSpam.AutoSize = true;
            chk_iconSpam.Location = new Point(311, 91);
            chk_iconSpam.Name = "chk_iconSpam";
            chk_iconSpam.Size = new Size(82, 19);
            chk_iconSpam.TabIndex = 12;
            chk_iconSpam.Text = "Icon Spam";
            chk_iconSpam.UseVisualStyleBackColor = true;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(11, 150);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(104, 15);
            lbl_time.TabIndex = 13;
            lbl_time.Text = "Seconds Per Effect";
            // 
            // num_time
            // 
            num_time.BackColor = Color.FromArgb(17, 17, 17);
            num_time.ForeColor = Color.Silver;
            num_time.Location = new Point(11, 168);
            num_time.Name = "num_time";
            num_time.Size = new Size(86, 23);
            num_time.TabIndex = 14;
            num_time.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // chk_threadEverything
            // 
            chk_threadEverything.AutoSize = true;
            chk_threadEverything.Location = new Point(11, 197);
            chk_threadEverything.Name = "chk_threadEverything";
            chk_threadEverything.Size = new Size(146, 19);
            chk_threadEverything.TabIndex = 15;
            chk_threadEverything.Text = "Run selected together?";
            chk_threadEverything.UseVisualStyleBackColor = true;
            chk_threadEverything.CheckedChanged += chk_threadEverything_CheckedChanged;
            // 
            // chk_blockInput
            // 
            chk_blockInput.AutoSize = true;
            chk_blockInput.Location = new Point(304, 197);
            chk_blockInput.Name = "chk_blockInput";
            chk_blockInput.Size = new Size(126, 19);
            chk_blockInput.TabIndex = 16;
            chk_blockInput.Text = "Block input? (UAC)";
            chk_blockInput.UseVisualStyleBackColor = true;
            // 
            // chk_rainbowPuke
            // 
            chk_rainbowPuke.AutoSize = true;
            chk_rainbowPuke.Location = new Point(12, 114);
            chk_rainbowPuke.Name = "chk_rainbowPuke";
            chk_rainbowPuke.Size = new Size(101, 19);
            chk_rainbowPuke.TabIndex = 17;
            chk_rainbowPuke.Text = "Rainbow Puke";
            chk_rainbowPuke.UseVisualStyleBackColor = true;
            // 
            // chk_shake
            // 
            chk_shake.AutoSize = true;
            chk_shake.Location = new Point(194, 114);
            chk_shake.Name = "chk_shake";
            chk_shake.Size = new Size(57, 19);
            chk_shake.TabIndex = 18;
            chk_shake.Text = "Shake";
            chk_shake.UseVisualStyleBackColor = true;
            // 
            // chk_killwalls
            // 
            chk_killwalls.AutoSize = true;
            chk_killwalls.Location = new Point(304, 172);
            chk_killwalls.Name = "chk_killwalls";
            chk_killwalls.Size = new Size(98, 19);
            chk_killwalls.TabIndex = 19;
            chk_killwalls.Text = "Kill Wallpaper";
            chk_killwalls.UseVisualStyleBackColor = true;
            // 
            // chk_clear
            // 
            chk_clear.AutoSize = true;
            chk_clear.Location = new Point(304, 147);
            chk_clear.Name = "chk_clear";
            chk_clear.Size = new Size(91, 19);
            chk_clear.TabIndex = 20;
            chk_clear.Text = "Clear Screen";
            chk_clear.UseVisualStyleBackColor = true;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(434, 228);
            Controls.Add(chk_clear);
            Controls.Add(chk_killwalls);
            Controls.Add(chk_shake);
            Controls.Add(chk_rainbowPuke);
            Controls.Add(chk_blockInput);
            Controls.Add(chk_threadEverything);
            Controls.Add(num_time);
            Controls.Add(lbl_time);
            Controls.Add(chk_iconSpam);
            Controls.Add(chk_invertSpam);
            Controls.Add(chk_invertSquares);
            Controls.Add(chk_growingShapes);
            Controls.Add(chk_fractal);
            Controls.Add(chk_static);
            Controls.Add(btn_build);
            Controls.Add(txt_dvdText);
            Controls.Add(chk_dvdText);
            Controls.Add(chk_dvdball);
            Controls.Add(lbl_pleasedontremove);
            Controls.Add(chk_tunnel);
            Controls.Add(lbl_Title);
            ForeColor = Color.DarkGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_Main";
            Text = "GDI-GUI";
            ((System.ComponentModel.ISupportInitialize)num_time).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private CheckBox chk_tunnel;
        private Label lbl_pleasedontremove;
        private CheckBox chk_dvdball;
        private CheckBox chk_dvdText;
        private TextBox txt_dvdText;
        private Button btn_build;
        private CheckBox chk_growingShapes;
        private CheckBox chk_fractal;
        private CheckBox chk_static;
        private CheckBox chk_invertSquares;
        private CheckBox chk_invertSpam;
        private CheckBox chk_iconSpam;
        private Label lbl_time;
        private NumericUpDown num_time;
        private CheckBox chk_threadEverything;
        private CheckBox chk_blockInput;
        private CheckBox chk_rainbowPuke;
        private CheckBox chk_shake;
        private CheckBox chk_killwalls;
        private CheckBox chk_clear;
    }
}
