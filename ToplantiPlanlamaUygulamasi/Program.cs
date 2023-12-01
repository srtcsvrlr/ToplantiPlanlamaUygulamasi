namespace ToplantiPlanlamaUygulamasi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // TO DO klasörleri kontrol et , dosyalarý kontrol et
            string aliPath = @"dosyalar\Ali";
            Directory.CreateDirectory(@aliPath);
            File.Create(Path.Combine(aliPath, "KullaniciBilgileri.txt"));

            Directory.CreateDirectory(@"dosyalar\Ayse");
            //File.Create(@"C:\Temp.txt");

            Directory.CreateDirectory(@"dosyalar\Mehmet");
            //File.Create(@"C:\Temp.txt");

            Directory.CreateDirectory(@"dosyalar\Merve");
            //File.Create(@"C:\Temp.txt");


            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmToplantiUygulamasi());
        }
    }
}