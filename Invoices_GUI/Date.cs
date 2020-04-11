using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices_GUI
{
    class Date : IComparable
    {
        private int year, month, day;
        private int[] daysOfMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private bool isLeapYear;

        public Date(int m, int d, int y)
        {
            Year = y;
            Month = m;
            Day = d;
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    //WriteLine($"Month is out of range, using 1 (January)");
                    month = 1;
                }
            }
        }

        public int Day
        {
            get { return day; }
            set
            {
                if (value <= daysOfMonth[month - 1])
                {
                    day = value;
                }
                else
                {
                    //WriteLine($"Day is out of bounds, using 1");
                    day = 1;
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                value = checkTwoDigitYear(value);

                if (value >= 1800 && value <= 2200)
                {
                    year = value;

                    checkLeapYear(value);
                }
                else
                {
                    //WriteLine($"Year {value} is invalid, using 2001");
                    year = 2001;
                }
            }
        }

        public int CompareTo(object obj)
        {
            Date date = (Date)obj;
            if (this.year > date.year)
            {
                return 1;
            }
            else if (this.year < date.year)
            {
                return -1;
            }
            else // same year
            {
                if (this.month > date.month)
                {
                    return 1;
                }
                else if (this.month < date.month)
                {
                    return -1;
                }
                else // same month
                {
                    if (this.day > date.day)
                    {
                        return 1;
                    }
                    else if (this.day < date.day)
                    {
                        return -1;
                    }
                    else // same day
                    {
                        return 0;
                    }
                }
            }
        }

        public override string ToString()
        {
            return ($"{month}/{day}/{year}");
        }

        // helper method to check if year is a leap year
        private void checkLeapYear(int y)
        {
            if (y % 400 == 0)
            {
                isLeapYear = true;
            }
            else if (y % 100 == 0)
            {
                isLeapYear = false;
            }
            else if (y % 4 == 0)
            {
                isLeapYear = true;
            }
            else
            {
                isLeapYear = false;
            }

            if (isLeapYear)
            {
                daysOfMonth[1] = 29;  // feb has 29 days
            }
            else
            {
                daysOfMonth[1] = 28;
            }
        }

        // helper method to check 2 digit year
        private int checkTwoDigitYear(int y)
        {
            if (y < 100)
            {
                y += 2000;
            }
            return y;
        }

        public void addDay()
        {
            day++;

            if (day > daysOfMonth[month - 1])
            {
                //WriteLine("Day is out of bounds, using 1");
                day = 1;
                month++;
            }

            if (month > 12)
            {
                //WriteLine("Month is out of range, using 1 (January)");
                month = 1;
                year++;
            }
        }

        /*
        public Date(int initialValue) => this.value = initialValue;
        public static Date operator +(Date lhs, Date rhs) => new Date(lhs.value + rhs.value);
        private int value;
        */

        // operator overload
        public static Date operator ++(Date arg)
        {
            arg.addDay();
            return arg;
        }

        // compound assignment
        public static Date operator +(Date lhs, int rhs)
        {
            Date newDate = new Date(lhs.Month, lhs.Day, lhs.Year);

            for (int i = 0; i < rhs; i++)
            {
                newDate.addDay();
            }
            return newDate;
        }

    }
}

