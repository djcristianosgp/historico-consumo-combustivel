using historico_consumo_combustivel.Classes;

namespace historico_consumo_combustivel
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
            new ClsUteis();
            Application.Run(new Form1());
        }
    }
}