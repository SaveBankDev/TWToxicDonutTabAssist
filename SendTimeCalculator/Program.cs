using System.Xml.Linq;

namespace SendTimeCalculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static MainForm? MainForm { get; set; }

        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            ApplicationConfiguration.Initialize();
            MainForm = new MainForm();
            Application.Run(MainForm);
        }

    }
}