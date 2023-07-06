using System.Security.Cryptography;
using System.Xml;


namespace Abramov_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //33Даны действительные числа х, у. Получить:
            //а) max(x, y);
            //б) min(x, y);

            byte x, y;
            Console.Write("X: ");
            x = Convert.ToByte(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToByte(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("Max value is X = " + x);
                Console.WriteLine("Min value is Y = " + y);
            }
            else if (y > x)
            {
                Console.WriteLine("Max value is Y = " + y);
                Console.WriteLine("Mix value is X = " + x);
            }
            else Console.WriteLine("Equal");




            //34.Даны действительные числа x, y, z.Получить:
            //а) max(x, y, z);
            //б) min(x, y, z),
            /*int x, y, z;
            Console.Write("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y && x > z && y > z)
            {
                Console.WriteLine("Max value is X = " + x);
                Console.WriteLine("Mid value is Y = " + y);
                Console.WriteLine("Min value is Z = " + z);
            }
            else if (x > y && x > z && y < z)
            {
                Console.WriteLine("Max value is X = " + x);
                Console.WriteLine("Mid value is Z = " + z);
                Console.WriteLine("Min value is Y = " + y);
            }
            
            else if (y > x&& y > z && x > z)
            {
                Console.WriteLine("Max value is Y = " + y);
                Console.WriteLine("Mid value is X = " + x);
                Console.WriteLine("Mid value is Z = " + z);
            }
            else if (x < y && y > z && x < z)
            {
                Console.WriteLine("Max value is Y = " + y);
                Console.WriteLine("Mid value is Z = " + z);
                Console.WriteLine("Min value is X = " + x);
            }
            else if (z > x && z > y && x > y)
            {
                Console.WriteLine("Max value is Z = " + z);
                Console.WriteLine("Mid value is X = " + x);
                Console.WriteLine("Mid value is Y = " + y);
            }
            else if (z > x && z > y && x < y)
            {
                Console.WriteLine("Max value is Z = " + z);
                Console.WriteLine("Mid value is Y = " + y);
                Console.WriteLine("Mid value is X = " + x);
            }
            else Console.WriteLine("Equal");*/



            //35.Даны действительные числа x, y, z.Вычислить:
            //а) max(x + y + z, xyz);

            /*int x, y, z;
            Console.Write("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z: ");
            z = Convert.ToInt32(Console.ReadLine());
            int a = x + y + z;
            int b = x * y * z;
            if (a > b)
            {
                Console.WriteLine("Max value A = " + a);
                Console.WriteLine("Min value B = " + b);
            }
            else if (a < b)
            {
                Console.WriteLine("Max value B = " + b);
                Console.WriteLine("Min value A = " + a);
            }
            else Console.WriteLine("Equal");*/



            // 38.Даны действительные числа х, у.Вычислить z:
            //     z ={x-y если    x > y
            //        {y - x + 1   в противном случае.
            /*int x, y, z;
            Console.Write("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                z = x - y;
                Console.WriteLine("X bigger than Y:  " + z);
            }
            else 
            {
                z = y - x +1;
                Console.WriteLine("Y bigger than X:  " + z);
            }*/


            //48.Даны действительные числа a, b, с(а ≠ 0).Выяснить, имеет
            //    ли уравнение
            //    аx^2+ bx + c = 0 действительные корни. Если действительные корни
            //    имеются, то найти их. В противном случае ответом должно служить
            //    сообщение, что действительных корней нет.

            /*int a, b, c;
            Console.Write("A: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("B: ");
            b= Convert.ToInt16(Console.ReadLine());
            Console.Write("C: ");
            c = Convert.ToInt16(Console.ReadLine());
            //d = b^2 - 4 * a * c;
            int d = (b * b) - 4 * a * c;
            if (d > 0)
            {
                double x1 = -b - Math.Sqrt(d)/2*a;
                double x2 = -b + Math.Sqrt(d)/2*a;
                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
            }else
                Console.WriteLine("There are no real roots.");*/

            //49.Дано действительное число h.Выяснить, имеет ли
            //    уравнение ax^2 + bx + c = 0 действительные корни, если
            //     
            //    формулы а, б, с;
            //    
            //    Если действительные корни существуют, то найти их. В противном
            //    случае ответом должно служить сообщение, что действительных
            //    корней нет.
            /*int h;
            Console.Write("Enter value for h:  ");
            h = Convert.ToInt32(Console.ReadLine());
            double a = Math.Sqrt(Math.Abs(Math.Sin(8 * h) + 17) / Math.Pow((1 -
                Math.Sin(4 * h) * Math.Cos(Math.Pow(h, 2) + 18)), 2));
            double b = 1 - Math.Sqrt(3 / 3 + Math.Abs(Math.Tan(a * 
                Math.Pow(h, 2)) - Math.Sin(a * h)));
            double c = a * Math.Pow(h, 2) * Math.Sin(b * h) + b * Math.Pow(h, 3) * Math.Cos(a * h);
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                double x1 = -b - Math.Sqrt(d) / 2 * a;
                double x2 = -b + Math.Sqrt(d) / 2 * a;
                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
            }
            else
                Console.WriteLine("There are no real roots.");*/

            //57.Дано действительное число a.Вычислить f(a), если   б

            /*int x;
            Console.Write("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x <= 2)
            {
                int f = (x * x) + 4 * x + 5;
                Console.Write("F " + f);
            }
            else if (x >= 2)
            {
                int f1 = 1 / (x * x) + 4 * x + 5;
                Console.Write("F1 " + f1);
            }*/

        }
        
    }
}