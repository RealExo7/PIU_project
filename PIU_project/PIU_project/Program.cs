//Citire de la tast, salvare in fisier txt, afisare date fisier txt;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using Cheltuieli;
using Administrare;
using Administrare_cheltuieli1;

namespace PIU_PROIECT_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = "Cheltuieli.txt";

            List<Cheltuieli1> Pacanele = new List<Cheltuieli1>();
            Admin_txt Admin = new Admin_txt(numeFisier);
            Administrare_cheltuieli Cheltuieli = new Administrare_cheltuieli(numeFisier);


            //Citire de la tastatura
            /*
            Cheltuieli1 Date_tastatura = new Cheltuieli1();
            Console.WriteLine("Introduceti date cheltuieli:\n\n");
            Console.WriteLine("Introduceti Categoria: ");
            Date_tastatura.Categoria = Console.ReadLine();
            Console.WriteLine("Introduceti Suma: ");
            Date_tastatura.Suma = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduceti Data: ");
            Date_tastatura.Data = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Pacanele.Add(Date_tastatura);
            Admin.Save(Pacanele);
            */

            //Decomentam daca avem nevoie sa salvam in fisier txt
            //Cheltuieli.AddExpense(500, "Jocuri de noroc", new DateTime(2022, 07, 16));
            //Pacanele = Cheltuieli.GetExpenses();
            //Admin.Save(Pacanele);

            //Comentam daca decomentam cele de sus (ambele linii de cod)
            //Pacanele = Admin.Load();
            //Admin.PrintExpenses(Pacanele);

            Console.WriteLine("Introduceti categoria pentru cautare:\n");
            string categoria = Console.ReadLine();

            //Cautare dupa anumite criterii
            var searchResults = Admin.Search(cheltuiala =>
            (cheltuiala.Categoria.ToUpper() == categoria.ToUpper()));
            Admin.PrintCautari(searchResults);

            Console.ReadKey();
        }
    }
}
