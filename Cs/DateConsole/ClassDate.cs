using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConsole
{
    internal class ClassDate
    {
        private int day, month, year;

        public ClassDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            NormalizeDate();
        }

        private void NormalizeDate()
        {
            if (this.year < 1) this.year = 1;
            if (this.month < 1) this.month = 1;
            if (this.day < 1) this.day = 1;

            try
            {
                DateTime temp = new DateTime(this.year, 1, 1)
                    .AddMonths(this.month - 1)
                    .AddDays(this.day - 1);
                this.day = temp.Day;
                this.month = temp.Month;
                this.year = temp.Year;
            }
            catch
            {
                this.day = 1;
                this.month = 1;
                this.year = 1;
            }
        }

        public ClassDate Next()
        {
            DateTime current = new DateTime(year, month, day);
            DateTime next = current.AddDays(1);
            return new ClassDate(next.Day, next.Month, next.Year);
        }

        public ClassDate Previous()
        {
            DateTime current = new DateTime(year, month, day);
            if (current == new DateTime(1, 1, 1))
                return new ClassDate(1, 1, 1);

            DateTime prev = current.AddDays(-1);
            return new ClassDate(prev.Day, prev.Month, prev.Year);
        }

        public string Print()
        {
            DateTime dt = new DateTime(year, month, day);
            string monthName = dt.ToString("MMMM", CultureInfo.InvariantCulture);
            return $"The {day} of {monthName} {year}";
        }

        public void PrintForward(int n)
        {
            if (n <= 0) return;
            ClassDate current = this;
            for (int i = 0; i < n; i++)
            {
                current = current.Next();
                Console.WriteLine(current.Print());
            }
        }

        public void PrintBackward(int n)
        {
            if (n <= 0) return;
            ClassDate current = this;
            for (int i = 0; i < n; i++)
            {
                current = current.Previous();
                Console.WriteLine(current.Print());
            }
        }
    }
}
