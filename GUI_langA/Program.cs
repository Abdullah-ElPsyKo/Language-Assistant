using project;

namespace GUI_langA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            createFiles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        static void createFiles()
        {
            bool run = true;
            FileClass fileClass = new FileClass();

            FileClass.CreateFile(fileClass.Translated);
            FileClass.CreateFile(fileClass.ToTranslate);

            string fileTranslated = Path.Combine(FileClass.path, fileClass.Translated);
            string fileToTranslate = Path.Combine(FileClass.path, fileClass.ToTranslate);
        }
    }
}