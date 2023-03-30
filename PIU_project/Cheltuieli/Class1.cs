//Clasa care construieste cheltuielele; *Cheltuieli*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheltuieli
{
    public class Cheltuieli1
    {
        public decimal Suma { get; set; }
        public string Categoria { get; set; }
        public DateTime Data { get; set; }

        public Cheltuieli1(decimal amount, string category, DateTime date)
        {
            Suma = amount;
            Categoria = category;
            Data = date;
        }

        public Cheltuieli1()
        {
        }



        public override string ToString()
        {
            return $"{Data:d} - {Categoria}: {Suma:C}";
        }
    }
}
