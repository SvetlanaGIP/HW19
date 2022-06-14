using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19
{
    class Computer
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string PrType { get; set; }
        public int PrChastota { get; set; } //частотой  работы  процессора
        public int VOM { get; set; } //объемом оперативной памяти
        public int VHD { get; set; } //объемом жесткого диска
        public int VVC { get; set; } //объемом памяти видеокарты
        public int Price { get; set; } //стоимостью компьютера в условных единицах
        public int Quantity { get; set; } //количеством экземпляров
    }
}
