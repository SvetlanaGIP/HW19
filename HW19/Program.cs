using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19
{
    class Program
    {
        // Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,
        // типом  процессора,  частотой  работы  процессора,  объемом оперативной памяти,
        // объемом жесткого диска, объемом памяти видеокарты,
        // стоимостью компьютера в условных единицах и количеством экземпляров,
        // имеющихся в наличии. Создать список, содержащий 6-10 записей с различным набором значений характеристик.
        //        Определить:
        //- все компьютеры с указанным процессором.Название процессора запросить у пользователя;
        //- все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;
        //- вывести весь список, отсортированный по увеличению стоимости;
        //- вывести весь список, сгруппированный по типу процессора;
        //- найти самый дорогой и самый бюджетный компьютер;
        //- есть ли хотя бы один компьютер в количестве не менее 30 штук?
       

        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Code=123, Name="Acer", PrType="Intel1", PrChastota=100, VOM=5, VHD=1, VVC=3, Price=30, Quantity=11},
                new Computer(){Code=234, Name="Samsung", PrType="Intel2", PrChastota=200, VOM=4, VHD=2, VVC=6, Price=80, Quantity=23},
                new Computer(){Code=345, Name="Sony", PrType="Intel3", PrChastota=300, VOM=3, VHD=3, VVC=5, Price=300, Quantity=4},
                new Computer(){Code=456, Name="Apple", PrType="Intel1", PrChastota=400, VOM=5, VHD=4, VVC=3, Price=100, Quantity=9},
                new Computer(){Code=567, Name="Asus", PrType="Intel2", PrChastota=300, VOM=4, VHD=3, VVC=4, Price=210, Quantity=50},
                new Computer(){Code=678, Name="Lenovo", PrType="Intel", PrChastota=200, VOM=3, VHD=6, VVC=3, Price=90, Quantity=2},
                new Computer(){Code=789, Name="Xiaomi", PrType="Intel", PrChastota=100, VOM=2, VHD=5, VVC=4, Price=120, Quantity=100},
                
            };
            Console.WriteLine("Введите тип процессора");
            string prType = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.PrType == prType).ToList();
            Print(computers1);

            Console.WriteLine("Введите ОЗУ");
            int vom = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.VOM >= vom).ToList();
            Print(computers2);

            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

             IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.PrType);
             foreach (IGrouping<string, Computer> gr in computers4)
             {
                 Console.WriteLine(gr.Key);
                 foreach (Computer e in gr)
                 {
                     Console.WriteLine($"{e.Code} {e.Name} {e.PrType} {e.PrChastota} {e.VOM} {e.VHD} {e.VVC} {e.Price} {e.Quantity}");
                 }
             }

             Computer computer5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
             Console.WriteLine($"{computer5.Code} {computer5.Name} {computer5.PrType} {computer5.PrChastota}");

             Console.WriteLine(computers.Any(x => x.Quantity > 30));

            Console.ReadKey();

        }

        static void Print(List<Computer> employees)
        {
            foreach (Computer e in employees)
            {
                Console.WriteLine($"{e.Code} {e.Name} {e.PrType} {e.PrChastota} {e.VOM} {e.VHD} {e.VVC} {e.Price} {e.Quantity}");
            }
            Console.WriteLine();
        }
    }
}
