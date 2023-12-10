using Newtonsoft.Json;

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
            string aliPath = @"dosyalar";
            Directory.CreateDirectory(@aliPath);

            FileStream stream = File.Create(Path.Combine(aliPath, "YoneticiBilgileri.txt"));
            stream.Close();

            Kullanici aliKullanici = new Kullanici()
            {
                Name = "Ali",
                Password = "123ali"
            };

            var aliJson = JsonConvert.SerializeObject(aliKullanici);

            DosyaIslemleri.WriteData("YoneticiBilgileri.txt", aliJson);

            if (!File.Exists(Path.Combine(aliPath, "ToplantiBilgileri.txt")))
            {
                FileStream stream2 = File.Create(Path.Combine(aliPath, "ToplantiBilgileri.txt"));
                stream2.Close();
            }

            if (!File.Exists(Path.Combine(aliPath, "KatilimciBilgileri.txt")))
            {
                FileStream stream2 = File.Create(Path.Combine(aliPath, "KatilimciBilgileri.txt"));
                stream2.Close();
            }

            //string aysePath = @"dosyalar\Ayse";
            //Directory.CreateDirectory(@aysePath);
            //File.Create(Path.Combine(aysePath, "KullaniciBilgileri.txt"));
            //File.Create(Path.Combine(aysePath, "ToplantiBilgisi.txt"));


            //string mehmetPath = @"dosyalar\Mehmet";
            //Directory.CreateDirectory(@mehmetPath);
            //File.Create(Path.Combine(mehmetPath, "KullaniciBilgileri.txt"));
            //File.Create(Path.Combine(mehmetPath, "ToplantiBilgisi.txt"));


            //string mervePath = @"dosyalar\Merve";
            //Directory.CreateDirectory(mervePath);
            //File.Create(Path.Combine(mervePath, "KullaniciBilgileri.txt"));
            //File.Create(Path.Combine(mervePath, "ToplantiBilgisi.txt"));


            ApplicationConfiguration.Initialize();
            Application.Run(new frmToplantiUygulamasi());
        }
    }
}