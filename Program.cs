using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //lệnh viết tiếng việt trong c#
            Console.Write("Nhập một số bất kỳ: ");
            string so = Console.ReadLine();
            int sobk = Convert.ToInt32(so);
            if(sobk > 0)
            {
                Console.Write("só nguyên dương");
            }
            else
            if(sobk == 0)
            {
                Console.Write("số 0");
            }
            else
            {
                Console.Write("số nguyên âm");
            }
            Console.ReadKey();
        }
    }
}
