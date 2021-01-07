using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    public class ErettsegiAttribute : Attribute
    {
        public int Year { get; }
        public int Month { get; }
        public string Title { get; }
        public int Difficulty { get; }

        public DateTime Date => new DateTime(Year, Month, 1);

        public ErettsegiAttribute(int year, int month, string title = "", int difficulty = 0)
        {
            Year = year;
            Month = month;
            Title = title;
            Difficulty = difficulty;
        }
    }
}
