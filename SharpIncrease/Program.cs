using SharpIncrease;
using System;
using System.IO;

namespace DosyaPadding
{
    class Program
    {
        static void Main(string[] args)
        {
            Information.Banner();
            if (args.Length == 1 && args[0] == "-h")
            {

                Console.WriteLine("Usage of SharpIncrease.exe\n");
                Console.WriteLine("  -D string");
                Console.WriteLine("\tPath to orginal file");
                Console.WriteLine("  -S string");
                Console.WriteLine("\tHow many MBs to increase the file by");
                Console.WriteLine("  -O string");
                Console.WriteLine("\toutput file name");
                return;
            }

            if (args.Length < 6 || args.Length % 2 != 0 || args[0] != "-D" || args[2] != "-S" || args[args.Length - 2] != "-O")
            {

                Console.WriteLine("Usage: SharpIncrease.exe -D inpufile -S MB -O outputfile");
                return;
            }

            string eskiDosyaAdi = args[1];
            int mbSayisi = int.Parse(args[3]);
            string yeniDosyaAdi = args[args.Length - 1];

            if (!File.Exists(eskiDosyaAdi))
            {
                Console.WriteLine("Dosya bulunamadı.");
                return;
            }

            FileInfo fileInfo = new FileInfo(eskiDosyaAdi);
            long mevcutBoyut = fileInfo.Length;

            if (mbSayisi <= 0)
            {
                Console.WriteLine("Eklemek istediğiniz MB sayısı 0 veya negatif olamaz.");
                return;
            }

            long byteSayisi = mbSayisi * 1024 * 1024 - mevcutBoyut;
            byte[] paddingBytes = new byte[byteSayisi];

            using (FileStream eskiDosyaStream = new FileStream(eskiDosyaAdi, FileMode.Open, FileAccess.Read))
            using (FileStream yeniDosyaStream = new FileStream(yeniDosyaAdi, FileMode.Create, FileAccess.Write))
            {
                eskiDosyaStream.CopyTo(yeniDosyaStream);
                yeniDosyaStream.Write(paddingBytes, 0, (int)byteSayisi);
            }

            Console.WriteLine("{0} dosyasına {1} MB padding eklendi ve {2} adıyla kaydedildi.", eskiDosyaAdi, mbSayisi, yeniDosyaAdi);
        }
    }
}
