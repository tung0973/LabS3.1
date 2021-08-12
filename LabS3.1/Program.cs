using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS3
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap So thu nhat :");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("nhap vao so thu 2 :");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("nhap vao so thu 3 :");
            int c = Int32.Parse(Console.ReadLine());

            bool th1 = a == b;
            bool th2 = b == c;
            bool th3 = c == a;
            int max = a;

            while (true)
            {
                if (th1 == true)
                {
                    if (th2 == true)
                    {
                        Console.WriteLine("a,b va c khong duoc bang nhau.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("a va b khong duoc bang nhau.");
                        break;
                    }
                }
                if (th2 == true)
                {
                    Console.WriteLine("b va c khong duoc bang nhau");
                    break;
                }
                if (th3 == true)
                {
                    Console.WriteLine("a va c khong duoc bang nhau");
                    break;
                }


                switch (max > b)
                {
                    case true:
                        switch (max > c)
                        {
                            case false:
                                max = c;
                                break;
                        }
                        break;
                    case false:
                        max = b;
                        break;
                }
                Console.WriteLine("Max trong 3 so {0}, {1}, {2} la {3} ", a, b, c, max);
                break;
            }
        }
    }
}

