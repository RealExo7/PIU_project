//Construieste lista cu cheltuieli; *Administrare cheltuieli*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cheltuieli;
namespace Administrare_cheltuieli1
{
    public class Administrare_cheltuieli
    {
        private List<Cheltuieli1> expenses;
        private string filename;

        public Administrare_cheltuieli(string filename)
        {
            expenses = new List<Cheltuieli1>();
            this.filename = filename;
        }

        public List<Cheltuieli1> GetExpenses()
        {
            return expenses;
        }

        public void AddExpense(decimal amount, string category, DateTime date)
        {
            expenses.Add(new Cheltuieli1(amount, category, date));
        }

        public void EditExpense(int index, decimal amount, string category, DateTime date)
        {
            expenses[index] = new Cheltuieli1(amount, category, date);
        }

        public void DeleteExpense(int index)
        {
            expenses.RemoveAt(index);
        }
    }
}