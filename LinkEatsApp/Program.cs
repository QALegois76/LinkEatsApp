using ConsoleAppEntityFramework;
using LinkEatsApp.UC;

namespace LinkEatsApp
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
            ApplicationConfiguration.Initialize();

            MainForm mainForm = new MainForm();

            MainFormController mainFormController;

            mainFormController= new MainFormController(mainForm, DatabaseMng.Instance);

            //Application.Run(mainForm);
            Application.Run(new FormTest());
        }
    }
}