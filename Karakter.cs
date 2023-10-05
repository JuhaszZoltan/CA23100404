using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA23100404
{
    internal class Karakter
    {
        public char Betu { get; set; }
        public bool[,] Matrix { get; set; }

        public string Kep
        {
            get
            {
                string kep = string.Empty;
                for (int r = 0; r < Matrix.GetLength(0); r++)
                {
                    for (int c = 0; c < Matrix.GetLength(1); c++)
                    {
                        kep += Matrix[r, c] ? 'X' : ' ';
                    }
                    kep += '\n';
                }
                return kep.Substring(0, kep.Length - 1);
            }
        }

        public Karakter(char betu, bool[,] matrix)
        {
            Betu = betu;
            Matrix = matrix;
        }
    }
}
