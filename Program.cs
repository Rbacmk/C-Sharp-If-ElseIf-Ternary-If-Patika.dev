using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ElseIf_Ternary_If
{
    class Program
    {
        static void Main(string[] args)
        {
# If-ElseIf-Ternary-If

            //If-ElseIf-Ternary-If
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın");
            }

            else if (time <= 18)
            {
                Console.WriteLine("iyi günler");
            }
            else
            {
                Console.WriteLine("İyi akşamlar");
            }

        }
    }
}
    }
}
