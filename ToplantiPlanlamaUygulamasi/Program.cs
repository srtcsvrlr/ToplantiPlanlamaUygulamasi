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
            string dosyaYolu = @"dosyalar";
            Directory.CreateDirectory(@dosyaYolu);

            FileStream stream = File.Create(Path.Combine(dosyaYolu, "YoneticiBilgileri.txt"));
            stream.Close();

            Kullanici aliKullanici = new Kullanici()
            {
                Name = "yonetici",
                Password = "yonetici123"
            };

            var aliJson = JsonConvert.SerializeObject(aliKullanici);

            DosyaIslemleri.WriteData("YoneticiBilgileri.txt", aliJson);

            if (!File.Exists(Path.Combine(dosyaYolu, "ToplantiBilgileri.txt")))
            {
                FileStream stream2 = File.Create(Path.Combine(dosyaYolu, "ToplantiBilgileri.txt"));
                stream2.Close();
            }

            if (!File.Exists(Path.Combine(dosyaYolu, "KatilimciBilgileri.txt")))
            {
                FileStream stream2 = File.Create(Path.Combine(dosyaYolu, "KatilimciBilgileri.txt"));
                stream2.Close();
            }


            ApplicationConfiguration.Initialize();
            Application.Run(new frmToplantiUygulamasi());
        }
    }
}