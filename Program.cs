using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            string[] can = { "Canh" , "Tan" , "Nham" , "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi = {"Than", "Dau", "Tuat", "Hoi", "Ti", "Suu","Dan", "Meo", "Thin", "Ty", "Ngo", "Mui"};
                 Console.WriteLine( "Nhap nam: " );
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine( "{0} - {1} {2}\n" , n, can[n % 10], chi[n % 12] );
            Console.WriteLine( "{0} - {1} {2}\n", n + 60, can[n % 10], chi[n % 12] );
            Console.ReadLine();
        }
    }
}
