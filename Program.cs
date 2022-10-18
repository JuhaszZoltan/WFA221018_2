namespace WFA221018_2
{
    internal static class Program
    {
        public static string ConnectionString =
            @"Server = (localdb)\MSSQLLocalDB;" +
            "Database = jadijasok;";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}