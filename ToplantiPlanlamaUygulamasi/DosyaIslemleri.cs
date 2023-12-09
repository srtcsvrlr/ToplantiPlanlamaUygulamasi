using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplantiPlanlamaUygulamasi
{
    public static class DosyaIslemleri
    {
        public static void WriteData(string kullanici, string dosyaIsmi,string Icerik)
        {
            string kullaniciDosyaYolu = @"dosyalar\" + kullanici;
            File.WriteAllText(Path.Combine(kullaniciDosyaYolu, dosyaIsmi), Icerik);

        }
        public static string ReadData(string kullanici, string dosyaIsmi)
        {
            string kullaniciDosyaYolu = @"dosyalar\" + kullanici;

            return File.ReadAllText(Path.Combine(kullaniciDosyaYolu, dosyaIsmi));


        }
    }
}
