using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Bai_1
{
    class Program
    {
        static void readFile()
        {
            string filePath = "data.txt";

            // Mở file để đọc với FileStream và StreamReader
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                // Đọc và hiển thị nội dung từ file
                using (StreamWriter sw = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    sw.WriteLine("username: myUsername");
                    sw.WriteLine("password: myPassword");
                }
            }
        }
        static void writeFile()
        {
            string filePath = "output.txt";
            // Mở file để ghi với FileStream và StreamWriter
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fileStream, Encoding.UTF8)) 
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }   
        }
        static void Main()
        {
            readFile();
            writeFile();
        }
    }
}
