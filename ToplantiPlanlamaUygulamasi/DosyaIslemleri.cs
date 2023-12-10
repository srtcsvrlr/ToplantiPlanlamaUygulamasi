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
        public static void WriteData( string dosyaIsmi,string Icerik)
        {
            string dosyaKlasoru = @"dosyalar\";
           
            File.WriteAllText(Path.Combine(dosyaKlasoru, dosyaIsmi), Icerik);

        }
        public static string ReadData( string dosyaIsmi)
        {
            string dosyaKlasoru = @"dosyalar\";

            return File.ReadAllText(Path.Combine(dosyaKlasoru, dosyaIsmi));


        }
    }
}
