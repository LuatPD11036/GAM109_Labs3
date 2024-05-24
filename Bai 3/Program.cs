using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Bai_3
{
    internal class Program
    {
        static void create()
        {
            string dataDirectory = @"D:..\\..\\..\data\\";
            // tao floder
            Directory.CreateDirectory(dataDirectory);
            //ket hop duong dan file va thu muc
            string dataFilePath = Path.Combine(dataDirectory, "data.txt");

            //ghi noi dung vao file va streamWrite
            using (StreamWriter writer = new StreamWriter(dataFilePath))
            {
                writer.WriteLine("Du Lieu Duoc Ghi Vao File data.txt trong floder data");
            }
            Console.WriteLine("Đã ghi xong: " + dataFilePath);
        }
        static void copyData()
        {
            string sourceDirectory = @"..\\..\\..\data\\";
            string targetDirectory = @"..\\..\\..\data2\\";
            // Kiểm tra xem thư mục nguồn tồn tại không
            if (Directory.Exists(sourceDirectory))
            {
                // Tạo thư mục đích nếu nó chưa tồn tại
                Directory.CreateDirectory(targetDirectory);
                // Lấy danh sách các file trong thư mục nguồn
                string[] files = Directory.GetFiles(sourceDirectory);
                // Sao chép từng file sang thư mục đích
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string targetFile = Path.Combine(targetDirectory, fileName);
                    File.Copy(file, targetFile, true);
                }
                Console.WriteLine("Sao chép hoàn tất.");
            }
            else
            {
                Console.WriteLine("Thư mục nguồn không tồn tại.");
            }
        }
        static void Main()
        {
            create();
            copyData();
        }
    }
}
