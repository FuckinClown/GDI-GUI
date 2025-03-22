using GDI_GUI.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace GDI_GUI
{
    public partial class frm_Main : Form
    {
        #region Custom Title Bar

        // This is the only way I could figure out how to do it
        // ik importing dlls is weird but it works
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        #endregion

        static AppDataHandler ADH = new AppDataHandler();
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_bak_Load(object sender, EventArgs e)
        {
            if (ADH.ReadCompilerLocation() == "g++")
                lbl_compiler_location.Text = "Default";
            else
                lbl_compiler_location.Text = ADH.ReadCompilerLocation();
        }

        private void chk_threadEverything_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_synchronis.Checked)
                lbl_time.Text = "Total Seconds";
            else
                lbl_time.Text = "Seconds Per Effect";
        }

        private void btn_build_Click(object sender, EventArgs e)
        {
            // Hey would you look at that I found a better way to do it
            var payloadBuilder = new PayloadBuilder((int)num_time.Value, chk_synchronis.Checked);

            // Regular Effects
            foreach (string payloadName in lst_timesheet.Items)
            {
                // No good way to do special cases, but there arent many
                if (payloadName == "DvDText")
                {
                    payloadBuilder.AddEffect(payloadName, $"\"{txt_dvdText.Text.Trim('"').Trim()}\", ");
                }
                else if (payloadName == "DvDBall")
                {
                    payloadBuilder.AddEffect(payloadName, $"{num_dvdball.Value}, ");
                }
                else if (payloadName == "RunawayScreen")
                {
                    payloadBuilder.AddEffect(payloadName, $"{num_runaway.Value}, ");
                }
                else if (payloadName == "FractalShader")
                {
                    payloadBuilder.AddThreadedEffect("thrd_fractal", "FractalShader");
                }
                else if (payloadName == "RainbowShader")
                {
                    payloadBuilder.AddThreadedEffect("thrd_rainbow", "RainbowShader");
                }
                else payloadBuilder.AddEffect(payloadName);
            }

            payloadBuilder.BuildFile();

            string extraArgs = "";
            if (chk_blockInput.Checked) extraArgs += "-DBLOCKINPUT ";
            if (chk_clear.Checked) extraArgs += "-DCLEAR_SCRN ";
            if (chk_killwalls.Checked) extraArgs += "-DKILL_WALLS";

            try
            {
                CompileCppCode($@"{Path.GetTempPath()}\GDI-GUI-CustomStub.cpp", extraArgs);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show(
                    "ERROR! A g++ compiler does not appear to be installed, please install MinGW so I can compile.\n\nIf a compiler is installed, please specify the location or add to PATH.",
                    "Compiler error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CompileCppCode(string CodePath, string extraArguments)
        {
            string outputFileName = "GDI-GUI-output.exe";
            string outputFilePath = Path.Combine(Directory.GetCurrentDirectory(), outputFileName);

            Process compiler = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ADH.ReadCompilerLocation(),
                    Arguments = $"\"{CodePath}\" -o \"{outputFilePath}\" -lgdi32 {extraArguments}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            compiler.Start();

            string output = compiler.StandardOutput.ReadToEnd();
            string error = compiler.StandardError.ReadToEnd();

            compiler.WaitForExit();

            if (!string.IsNullOrEmpty(error))
            {
                File.WriteAllText("error.txt", error);
                MessageBox.Show("Compiler Error! Dumped to file: error.txt\nPlease refer to the github repo for help");
            }
            else
            {
                DialogResult sucess = MessageBox.Show($"Compilation Suceeded! Do you want to open the file location?", "Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sucess == DialogResult.Yes)
                {
                    Process.Start("explorer.exe", "/select, " + outputFilePath);
                }
            }

            File.Delete(CodePath); // Remove temp file
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Directory.Delete(ADH.folderPath, true);
            lbl_compiler_location.Text = "Default";
        }

        private void lbl_compiler_location_Click(object sender, EventArgs e)
        {
            OpenFileDialog compilerFileSelect = new OpenFileDialog();
            compilerFileSelect.Title = "Select your g++ compiler";
            compilerFileSelect.InitialDirectory = @"C:\";
            compilerFileSelect.Filter = "Exe files (*.exe)|*.exe";
            compilerFileSelect.ShowDialog();
            if (compilerFileSelect.FileName != "")
            {
                lbl_compiler_location.Text = compilerFileSelect.FileName;
                ADH.WriteCompilerLocation(lbl_compiler_location.Text);
            }
            else
            {
                lbl_compiler_location.Text = "Default";
            }
        }

        // timesheet stuff
#pragma warning disable CS8600, CS8604 // ffs man ITS NOT NULL
        private void btn_up_Click(object sender, EventArgs e)
        {
            if (lst_timesheet.SelectedIndex > 0)
            {
                int selectedIndex = lst_timesheet.SelectedIndex;

                String selectedItem = lst_timesheet.SelectedItem as string;

                lst_timesheet.Items.RemoveAt(selectedIndex);
                lst_timesheet.Items.Insert(selectedIndex - 1, selectedItem);

                lst_timesheet.SelectedIndex = selectedIndex - 1;

                lst_timesheet.Refresh();
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (lst_timesheet.SelectedIndex > -1 &&
            lst_timesheet.SelectedIndex < lst_timesheet.Items.Count - 1)
            {
                int selectedIndex = lst_timesheet.SelectedIndex;

                String selectedItem = lst_timesheet.SelectedItem as string;

                lst_timesheet.Items.RemoveAt(selectedIndex);
                lst_timesheet.Items.Insert(selectedIndex + 1, selectedItem);

                lst_timesheet.SelectedIndex = selectedIndex + 1;

                lst_timesheet.Refresh();
            }
        }

#pragma warning restore CS8600, CS8604
        #region checkmark stuff

        // Yea again, idk a better way to do this without lag from a background worker
        private void chk_tunnel_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_tunnel.Checked) lst_timesheet.Items.Add("Tunnel");
            else lst_timesheet.Items.Remove("Tunnel");
        }

        private void chk_dvdball_CheckedChanged(object sender, EventArgs e)
        {
            lbl_dvdball_size.Visible = num_dvdball.Visible = chk_dvdball.Checked;

            if (chk_dvdball.Checked) lst_timesheet.Items.Add("DvDBall");
            else lst_timesheet.Items.Remove("DvDBall");
        }

        private void chk_dvdText_CheckedChanged(object sender, EventArgs e)
        {
            txt_dvdText.Visible = chk_dvdText.Checked;
            if (chk_dvdText.Checked) lst_timesheet.Items.Add("DvDText");
            else lst_timesheet.Items.Remove("DvDText");
        }

        private void chk_runaway_CheckedChanged(object sender, EventArgs e)
        {
            txt_runaway_speed.Visible = num_runaway.Visible = chk_runaway.Checked;

            if (chk_runaway.Checked) lst_timesheet.Items.Add("RunawayScreen");
            else lst_timesheet.Items.Remove("RunawayScreen");
        }

        private void chk_rainbowPuke_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_rainbowPuke.Checked) lst_timesheet.Items.Add("RainbowShader");
            else lst_timesheet.Items.Remove("RainbowShader");
        }

        private void chk_static_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_static.Checked) lst_timesheet.Items.Add("Static");
            else lst_timesheet.Items.Remove("Static");
        }

        private void chk_fractal_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_fractal.Checked) lst_timesheet.Items.Add("FractalShader");
            else lst_timesheet.Items.Remove("FractalShader");
        }

        private void chk_growingSquares_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_growingSquares.Checked) lst_timesheet.Items.Add("GrowingSquares");
            else lst_timesheet.Items.Remove("GrowingSquares");
        }

        private void chk_smear_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_smear.Checked) lst_timesheet.Items.Add("ScreenSmear");
            else lst_timesheet.Items.Remove("ScreenSmear");
        }

        private void chk_invertSquares_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_invertSquares.Checked) lst_timesheet.Items.Add("InvertSquares");
            else lst_timesheet.Items.Remove("InvertSquares");
        }

        private void chk_invertSpam_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_invertSpam.Checked) lst_timesheet.Items.Add("InvertSpam");
            else lst_timesheet.Items.Remove("InvertSpam");
        }

        private void chk_iconSpam_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_iconSpam.Checked) lst_timesheet.Items.Add("IconSpam");
            else lst_timesheet.Items.Remove("IconSpam");
        }

        private void chk_shake_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_shake.Checked) lst_timesheet.Items.Add("ScreenShake");
            else lst_timesheet.Items.Remove("ScreenShake");
        }

        #endregion
    }
}