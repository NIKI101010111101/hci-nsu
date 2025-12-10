using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
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
            if (year < 1) year = 1;
            if (month < 1) month = 1;
            if (day < 1) day = 1;

            DateTime dt = new DateTime(year, 1, 1)
                .AddMonths(month - 1)
                .AddDays(day - 1);

            day = dt.Day;
            month = dt.Month;
            year = dt.Year;
        }

        public ClassDate Next()
        {
            DateTime dt = new DateTime(year, month, day).AddDays(1);
            return new ClassDate(dt.Day, dt.Month, dt.Year);
        }

        public ClassDate Previous()
        {
            DateTime dt = new DateTime(year, month, day).AddDays(-1);
            if (dt < new DateTime(1, 1, 1))
                return new ClassDate(1, 1, 1);
            return new ClassDate(dt.Day, dt.Month, dt.Year);
        }

        public string Print()
        {
            string dayOfWeek = new DateTime(year, month, day).ToString("dddd", CultureInfo.InvariantCulture);
            string monthName = new DateTime(year, month, 1).ToString("MMMM", CultureInfo.InvariantCulture);
            return $"The {day} of {monthName} {year}";
        }

        public string PrintForward(int n)
        {
            if (n <= 0) return "";
            var result = "";
            var current = this;
            for (int i = 0; i < n; i++)
            {
                current = current.Next();
                result += current.Print() + Environment.NewLine;
            }
            return result.TrimEnd();
        }

        public string PrintBackward(int n)
        {
            if (n <= 0) return "";
            var result = "";
            var current = this;
            var dates = new string[n];
            for (int i = 0; i < n; i++)
            {
                current = current.Previous();
                dates[n - 1 - i] = current.Print();
            }
            return string.Join(Environment.NewLine, dates);
        }
    }
}
