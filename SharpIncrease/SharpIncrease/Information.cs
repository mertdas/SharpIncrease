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

                Console.WriteLine("Usage: SharpIncrease.exe -D inputfile -S MB -O outputfile");
                return;
            }

            string formerFileName = args[1];
            int mbSize = int.Parse(args[3]);
            string newFileName = args[args.Length - 1];

            if (!File.Exists(formerFileName))
            {
                Console.WriteLine("File dont exist..");
                return;
            }

            FileInfo fileInfo = new FileInfo(formerFileName);
            long size = fileInfo.Length;

            if (mbSize <= 0)
            {
                Console.WriteLine("Size cannot be negative");
                return;
            }

            long byteSize = mbSize * 1024 * 1024 - size;
            byte[] paddingBytes = new byte[byteSize];

            using (FileStream oldFileStream = new FileStream(formerFileName, FileMode.Open, FileAccess.Read))
            using (FileStream newFileStream = new FileStream(newFileName, FileMode.Create, FileAccess.Write))
            {
                oldFileStream.CopyTo(newFileStream);
                newFileStream.Write(paddingBytes, 0, (int)byteSize);
            }

            Console.WriteLine("Added {1} MB of padding to the {0} file, saved as {2}", formerFileName, mbSize, newFileName);
        }
    }
}
