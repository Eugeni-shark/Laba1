using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1GitHub
{
    class Reka
    {
        public string naim { get; set; }
        public double plosh { get; set; }
        public double prot { get; set; }
        public void zapis()
        {
            Reka[] a = new Reka[1000];
            Console.Write("Введите кол-во записей: ");
            int n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new Reka();
                Console.Write("Название реки: ");
                a[i].naim = Console.ReadLine();
                Console.Write("Площадь реки: ");
                a[i].plosh = Convert.ToDouble(Console.ReadLine());
                Console.Write("Протяженность реки: ");
                a[i].prot = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
            Print(a, n);
        }

        public void Print(Reka[] a, int nz)
        {
            Console.WriteLine(" Название реки           Площадь реки           " +
    " Протяженность реки");
            for (int i = 0; i < nz; i++)
            {
                Console.WriteLine($"{a[i].naim,10} {a[i].plosh,15} {a[i].prot,13}");
            }
        }

        public void start()
        {
            Reka qa = new Reka();
            for (int z = 0; z < 99999; z++)
            {
                Console.WriteLine();
                Console.WriteLine($" ┌─────────────────────МЕНЮ─────────────────────┐");
                Console.WriteLine($" │ 1. Выполнить.                                │");
                Console.WriteLine($" │ 2. Очистить консоль.                         │");
                Console.WriteLine($" │ 3. Выйти из программы.                       │");
                Console.WriteLine($" └──────────────────────────────────────────────┘");
                Console.Write(" Выберите команду: ");
                int x1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                switch (x1)
                {
                    case 1: qa.zapis(); break;
                    case 2: Console.Clear(); break;
                    case 3: Environment.Exit(0); break;
                }
            }
        }
    }
}
