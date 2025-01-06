namespace GDI_GUI
{
    partial class Frm_Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_compiler_location = new Label();
            lbl_underline1 = new Label();
            btn_save = new Button();
            lbl_compiler_loc_title = new Label();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // lbl_compiler_location
            // 
            lbl_compiler_location.ForeColor = Color.DarkGray;
            lbl_compiler_location.Location = new Point(12, 28);
            lbl_compiler_location.Name = "lbl_compiler_location";
            lbl_compiler_location.Size = new Size(255, 23);
            lbl_compiler_location.TabIndex = 1;
            lbl_compiler_location.Text = "Choose File";
            lbl_compiler_location.TextAlign = ContentAlignment.MiddleCenter;
            lbl_compiler_location.Click += lbl_compiler_location_Click;
            // 
            // lbl_underline1
            // 
            lbl_underline1.ForeColor = Color.Silver;
            lbl_underline1.Location = new Point(12, 34);
            lbl_underline1.Name = "lbl_underline1";
            lbl_underline1.Size = new Size(255, 23);
            lbl_underline1.TabIndex = 2;
            lbl_underline1.Text = "________________________________________________";
            lbl_underline1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(17, 17, 17);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.DarkGray;
            btn_save.Location = new Point(12, 160);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 28);
            btn_save.TabIndex = 3;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_compiler_loc_title
            // 
            lbl_compiler_loc_title.AutoSize = true;
            lbl_compiler_loc_title.Location = new Point(12, 9);
            lbl_compiler_loc_title.Name = "lbl_compiler_loc_title";
            lbl_compiler_loc_title.Size = new Size(108, 15);
            lbl_compiler_loc_title.TabIndex = 4;
            lbl_compiler_loc_title.Text = "Compiler Location:";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(17, 17, 17);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.DarkGray;
            btn_clear.Location = new Point(192, 160);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 28);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // Frm_Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(279, 200);
            Controls.Add(btn_clear);
            Controls.Add(lbl_compiler_loc_title);
            Controls.Add(btn_save);
            Controls.Add(lbl_compiler_location);
            Controls.Add(lbl_underline1);
            ForeColor = Color.DarkGray;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Frm_Options";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Options";
            Load += Frm_Options_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_compiler_location;
        private Label lbl_underline1;
        private Button btn_save;
        private Label lbl_compiler_loc_title;
        private Button btn_clear;
    }
}