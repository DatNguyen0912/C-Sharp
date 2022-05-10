using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_DIEM_DANH_10_05.BaiDD
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] n114 = new int[10];
            Console.OutputEncoding = Encoding.UTF8;
            for (int i114 = 0; i114 < 10; i114++)
            {
                n114[i114] = int.Parse(Console.ReadLine());
            }
            Console.Write("Giá trị lớn nhất: {0}", lonnhat(n114));
            Console.Write("Giá trị nhỏ nhất: {0}", nhonhat(n114));
            Console.Write("Sắp xếp tăng dần");
            sapxeptangdan(ref n114);
            Console.Write("Sắp xếp giảm dần");
            sapxepgiamdan(ref n114);
            Console.ReadKey();

        }
        static int lonnhat(int[] a114)
        {
            int i114;
            int max = a114[0];
            for (i114 = 1; i114 < 10; i114++)
            {
                if (max < a114[i114])
                    max = a114[i114];
            }
            return max;
        }
        static int nhonhat(int[] a114)
        {
            int i114;
            int min114 = a114[0];
            for (i114 = 1; i114 < 10; i114++)
            {
                if (min114 > a114[i114])
                    min114 = a114[i114];
            }
            return min114;
        }
        static void sapxeptangdan(ref int[] a114)
        {
            int i114, j114, tmp114;
            for (i114 = 0; i114 < 10; i114++)
            {
                for (j114 = i114 + 1; j114 < 10; j114++)
                {
                    if (a114[j114] < a114[i114])
                    {

                        tmp114 = a114[i114];
                        a114[i114] = a114[j114];
                        a114[j114] = tmp114;
                    }
                }
            }
        }
        static void sapxepgiamdan(ref int[] a114)
        {
            int i114, j114, tmp114;
            for (i114 = 0; i114 < 10; i114++)
            {
                for (j114 = i114 + 1; j114 < 10; j114++)
                {
                    if (a114[j114] > a114[i114])
                    {

                        tmp114 = a114[i114];
                        a114[i114] = a114[j114];
                        a114[j114] = tmp114;
                    }
                }
            }
        }
    }
}
        