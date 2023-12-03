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


            string aysePath = @"dosyalar\Ayse";
            Directory.CreateDirectory(@aysePath);
            File.Create(Path.Combine(aysePath, "KullaniciBilgileri.txt"));


            string mehmetPath = @"dosyalar\Mehmet";
            Directory.CreateDirectory(@mehmetPath);
            File.Create(Path.Combine(mehmetPath, "KullaniciBilgileri.txt"));


            string mervePath = @"dosyalar\Merve";
            Directory.CreateDirectory(mervePath);
            File.Create(Path.Combine(mervePath, "KullaniciBilgileri.txt"));
            


            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmToplantiUygulamasi());
        }
    }
}