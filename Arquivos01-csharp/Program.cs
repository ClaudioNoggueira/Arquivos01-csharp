using Entitites;
using System;
using System.IO;

namespace Arquivos01_csharp {
    class Program {
        private static string sourcePath;

        static void Main(string[] args) {
            Console.Write("Enter file full path: ");
            string sourcePath = Console.ReadLine();

            try {
                string[] lines = File.ReadAllLines(sourcePath);

                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath)) {
                    foreach (string line in lines) {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
