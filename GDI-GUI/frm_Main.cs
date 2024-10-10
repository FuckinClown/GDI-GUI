using GDI_GUI.Properties;
using System.Diagnostics;
using System.IO;

namespace GDI_GUI
{
    public partial class frm_Main : Form
    {
        string allPayloads = "";
        public frm_Main()
        {
            InitializeComponent();
        }

        private void chk_threadEverything_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_threadEverything.Checked)
                lbl_time.Text = "Total Seconds";
            else
                lbl_time.Text = "Seconds Per Effect";
        }

        private void chk_dvdText_CheckedChanged(object sender, EventArgs e)
        {
            txt_dvdText.Visible = chk_dvdText.Checked;
        }

        private void btn_build_Click(object sender, EventArgs e)
        {
            allPayloads = $"int timePerEffect = {num_time.Value};";

            // whole lotta if statements coming up
            // Unless you have a better idea, just be happy that it works

            // the "Sleep(timeInBetween);" function is needed for it to work
            // I do not know why, it just needs to catch its breath ig?
            /// TODO: Experiment on how much time is needed

            if (chk_tunnel.Checked == true)
            {
                allPayloads += $"\n    Tunnel(timePerEffect);\n    Sleep(timeInBetween);";
            }
            if (chk_dvdball.Checked == true)
            {
                allPayloads += "\n    DvDBall(timePerEffect);\n    Sleep(timeInBetween);";
            }
            if (chk_dvdText.Checked == true)
            {
                allPayloads += $"\n    DvDText(\"{txt_dvdText.Text.Trim('"').Trim()}\", timePerEffect);\n    Sleep(timeInBetween);";
            }
            if (chk_fractal.Checked == true)
            {
                allPayloads += $"""

        HANDLE thrd_fractal = CreateThread(0, 0, FractalShader, 0, 0, 0);
        Sleep(timePerEffect * 1000);
        TerminateThread(thrd_fractal, 0);
        CloseHandle(thrd_fractal);
        Sleep(timeInBetween);
    """;
            }
            if (chk_growingShapes.Checked == true)
            {
                allPayloads += $"\n    GrowingShapes(timePerEffect);\n    Sleep(timeInBetween);";
            }
            if (chk_iconSpam.Checked == true)
            {
                allPayloads += $"\n    IconSpam(timePerEffect);\n    Sleep(timeInBetween);";
            }
            if (chk_invertSquares.Checked == true)
            {
                allPayloads += $"\n    InvertShapes(timePerEffect);\n    Sleep(timeInBetween);";
            }
            if (chk_invertSpam.Checked == true)
            {
                allPayloads += $"\n    InvertSpam(timePerEffect);\n    Sleep(timeInBetween);";
            }
            if (chk_rainbowPuke.Checked == true)
            {
                allPayloads += $"""

        HANDLE thrd_rainbow = CreateThread(0, 0, RainbowShader, 0, 0, 0);
        Sleep(timePerEffect * 1000);
        TerminateThread(thrd_rainbow, 0);
        CloseHandle(thrd_rainbow);
    """;
            }
            if (chk_shake.Checked == true)
            {
                allPayloads += $"\n    ScreenShake(timePerEffect);\n    Sleep(timeInBetween);";
            }
            if (chk_static.Checked == true)
            {
                allPayloads += $"\n    Static(timePerEffect);\n    Sleep(timeInBetween);";
            }

            //File.WriteAllText($"{Path.GetTempPath()}\\temp.txt", allPayloads);
            File.WriteAllText($"{Path.GetTempPath()}\\GDI-GUI-CustomStub.cpp", Resources.stub.Replace("//METHODSHERE", allPayloads));

            string extraArgs = "";
            if (chk_blockInput.Checked)
                extraArgs += "-DBLOCKINPUT ";
            if (chk_clear.Checked)
                extraArgs += "-DCLEAR_SCRN ";
            if (chk_killwalls.Checked)
                extraArgs += "-DKILL_WALLS";

            try
            {
                CompileCppCode($"{Path.GetTempPath()}\\GDI-GUI-CustomStub.cpp", extraArgs);
            }
            catch (System.ComponentModel.Win32Exception) 
            {
                MessageBox.Show("ERROR! A g++ compiler does not apear to be installed, please install minGW or Msys64 so I can compile.\n\nIf a compiler is installed, make sure it is in your environment variables so that I can acess it.\nThank you", "Compiler error!");
            }
        }

        public static void CompileCppCode(string CodePath, string extraArguments)
        {
            Process compiler = new Process();
            compiler.StartInfo.FileName = "g++";
            compiler.StartInfo.Arguments = $"{CodePath} -o GDI-GUI-output.exe -lgdi32 {extraArguments}";

            compiler.StartInfo.RedirectStandardOutput = true;
            compiler.StartInfo.RedirectStandardError = true;
            compiler.StartInfo.UseShellExecute = false;
            compiler.StartInfo.CreateNoWindow = true;

            compiler.Start();

            string output = compiler.StandardOutput.ReadToEnd();
            string error = compiler.StandardError.ReadToEnd();

            compiler.WaitForExit();

            if (!string.IsNullOrEmpty(error))
            {
                File.WriteAllText("error.txt", error);
                MessageBox.Show("Error! Dumped to file");
            }
            else
            {
                MessageBox.Show("Compilation Suceeded!");
            }
        }
    }
}










/*
 Shaders are weird and require threads to run, run like this:
==============================================================
 HANDLE thread = CreateThread(0, 0, ExampleShader, 0, 0, 0);
 Sleep(miliseconds);
 TerminateThread(thread1, 0);
 CloseHandle(thread1);
==============================================================

 Normal effects can be ran by just calling the method:
==============================================================
 MethodHere(miliseconds);
threaded:
 std::thread thread = std::thread(MethodHere, miliseconds);
==============================================================
 */