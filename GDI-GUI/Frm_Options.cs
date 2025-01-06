// Feeling cute, might add more options later idk
namespace GDI_GUI
{
    public partial class Frm_Options : Form
    {
        AppDataHandler ADH = new AppDataHandler();

        public Frm_Options()
        {
            InitializeComponent();
        }

        private void lbl_compiler_location_Click(object sender, EventArgs e)
        {
            OpenFileDialog compilerFileSelect = new OpenFileDialog();
            compilerFileSelect.Title = "Select your g++ compiler";
            compilerFileSelect.InitialDirectory = @"C:\";
            compilerFileSelect.Filter = "Exe files (*.exe)|*.exe";
            compilerFileSelect.ShowDialog();
            lbl_compiler_location.Text = compilerFileSelect.FileName;
        }

        private void Frm_Options_Load(object sender, EventArgs e)
        {
            if (ADH.ReadCompilerLocation() == "g++")
                lbl_compiler_location.Text = "Choose Location";
            else
                lbl_compiler_location.Text = ADH.ReadCompilerLocation();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (lbl_compiler_location.Text != "Choose Location")
                ADH.WriteCompilerLocation(lbl_compiler_location.Text);
            DialogResult = DialogResult.OK;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Directory.Delete(ADH.folderPath, true);
            DialogResult = DialogResult.OK;
        }
    }
}
