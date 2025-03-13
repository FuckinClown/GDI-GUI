namespace GDI_GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_Main());
        }
    }

    public class AppDataHandler
    {
        private string appDataPath;
        public string folderPath;
        private string filePath;

        public AppDataHandler()
        {
            appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            folderPath = Path.Combine(appDataPath, "gdi-gui");
            filePath = Path.Combine(folderPath, "compilerLocation.txt");

            EnsureDirectory(folderPath);
        }

        private void EnsureDirectory(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        public void WriteCompilerLocation(string location)
        {
            EnsureDirectory(folderPath);
            File.WriteAllText(filePath, location);
        }

        public string ReadCompilerLocation()
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            return "g++"; //default if everything is set up correctly
        }
    }
}