namespace Farma_Joko
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Diagnostics.Debug.WriteLine("Welcome");
            // Pipik
            // 2cm mato
            // marek hrabovsky
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }
    }
}