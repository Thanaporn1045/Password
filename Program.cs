using System;

namespace รหัสผ่าน
{
    class Program
    {
        static void Main(string[] args)
        {
            int password, a, b, c, d, e, f;
            string work;
            bool T = true, F = false;

            Console.Write("Password : ");
            password = int.Parse(Console.ReadLine());
            Console.Write("Agency : ");
            work = Console.ReadLine();
            
            a = password / 100000;
            b = (password / 10000) % 10;
            c = (password / 1000) % 10;
            d = (password / 100) % 10;
            e = (password / 10) % 10;
            f = password %10;

            if (work == "CIA" || work == "FBI" || work == "NSA")
            {
                if (work == "CIA")
                {
                    if (f % 3 == 0 && e != 1 && e != 3 && e != 5 && c >= 6 && c != 8)
                        Console.WriteLine(" {0} WELCOME!",T);
                    else Console.WriteLine(" {0} GET OUT!",F);
                }
                
                if (work == "FBI")
                {
                    if (a >= 4 && a <= 7 && d % 3 == 0 && d != 6 && b % 2 == 1)
                        Console.WriteLine("{0} WELCOME!",T);
                    else Console.WriteLine("{0} GET OUT!",F);
                }
                
                if (work == "NSA")
                {
                    if (30 % f == 0 && d % 3 == 0 && d % 2 != 0 && (a == 7 || b == 7 || c == 7 || d == 7 || e == 7 || f == 7))
                        Console.WriteLine(" {0} WELCOME!",T);
                    else Console.WriteLine("{0} GET OUT!",F);
                }
            }
            else Console.WriteLine(" {0} GET OUT!",F);
        }
    }
}
