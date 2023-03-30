//Adaugare in fisier, citire din fisier, in fisier etc. *Administrare*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cheltuieli;


namespace Administrare
{
    public class Admin_txt
    {
        public string Nume_Fisier = "Cheltuieli.txt";
        public Admin_txt(string numeFisier)
        {
            this.Nume_Fisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void PrintCautari(IEnumerable<Cheltuieli1> chelt)
        {
            if (chelt.Count() == 0)
            {
                Console.WriteLine("Nu au fost gasite cautari dupa datele propuse");
            }
            else
            {
                foreach (Cheltuieli1 cheltuiala in chelt)
                {
                    Console.WriteLine(cheltuiala);
                }
            }
        }

        public void PrintExpenses(List<Cheltuieli1> expenses)
        {
            foreach (Cheltuieli1 expense in expenses)
            {
                Console.WriteLine(expense);
            }
        }

        public IEnumerable<Cheltuieli1> Search(Func<Cheltuieli1, bool> predicate)
        {
            {
                List<Cheltuieli1> vanzari = Load();
                foreach (Cheltuieli1 masina in vanzari)
                {
                    if (predicate(masina))
                    {
                        yield return masina;
                    }
                }

            }
        }
        public List<Cheltuieli1> Load()
        {
            List<Cheltuieli1> expenses = new List<Cheltuieli1>();
            expenses.Clear();

            if (File.Exists(Nume_Fisier))
            {
                using (StreamReader reader = new StreamReader(Nume_Fisier))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine().Split('|');
                        decimal amount = decimal.Parse(fields[0]);
                        string category = fields[1];
                        DateTime date = DateTime.Parse(fields[2]);
                        expenses.Add(new Cheltuieli1(amount, category, date));
                    }
                }
            }
            return expenses;
        }

        public void Save(List<Cheltuieli1> cheltuieli)
        {
            using (StreamWriter writer = new StreamWriter(Nume_Fisier))
            {
                foreach (Cheltuieli1 expense in cheltuieli)
                {
                    writer.WriteLine($"{expense.Suma}|{expense.Categoria}|{expense.Data:d}");
                }
            }
        }
    }
}
