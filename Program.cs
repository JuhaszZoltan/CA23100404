using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA23100404
{
    internal class Program
    {
        static void Main()
        {
            var bank = Beolvas("bank.txt");

            char input;
            bool siker;
            Console.WriteLine($"5. feladat: Karakterek száma: {bank.Count}");
            do
            {
                Console.Write("6. feladat: Kérek egy angol nagybetűt: ");
                siker = char.TryParse(Console.ReadLine(), out input);
            } while (!siker || input < 65 || input > 90);

            Console.Write("7. feladat: ");
            var mgj = bank.SingleOrDefault(k => k.Betu == input);
            Console.WriteLine(mgj is null ? "Nincs ilyen karakter a bankban!" : $"\n{mgj.Kep}");

            Console.WriteLine("9. feladat: Dekódolás:");

            Console.ReadKey(true);
        }

        static List<Karakter> Beolvas(string file)
        {
            var karakterek = new List<Karakter>();
            using (var sr = new StreamReader($@"..\..\src\{file}", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    char betu = char.Parse(sr.ReadLine());
                    bool[,] matrix = new bool[7, 4];
                    for (int r = 0; r < matrix.GetLength(0); r++)
                    {
                        string sor = sr.ReadLine();
                        for (int c = 0; c < matrix.GetLength(1); c++)
                        {
                            matrix[r, c] = sor[c] == '1';
                        }
                    }
                    karakterek.Add(new Karakter(betu, matrix));
                }
            }
            return karakterek;
        }

    }
}
