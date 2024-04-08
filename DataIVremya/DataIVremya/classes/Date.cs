using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataIVremya.classes
{
    internal class Date
    {
        int day = 1;
        int month = 1;
        int year = 1;

        public int Day
        {
            get => day;
            set
            {
                if (value < 1)
                {
                    MessageBox.Show("Неправильный день");
                    return;
                }
                if (Month == 2)
                {
                    if (((Year % 4 == 0) && (value <= 29)) || (value <= 28)) day = value;
                    else
                    {
                        MessageBox.Show("Неправильный день");
                        return;
                    }
                }
                int[] дней31 = { 1, 3, 5, 7, 8, 10, 12 };
                int[] дней30 = { 4, 6, 9, 11 };
                for (int i = 0; i < дней30.Length; i++)
                {
                    if (Month == дней30[i])
                    {
                        if (value <= 30) day = value;
                        else
                        {
                            MessageBox.Show("Неправильный день");
                            return;
                        }
                    }
                }
                for (int i = 0; i < дней31.Length; i++)
                {
                    if (Month == дней31[i])
                    {
                        if (value <= 31) day = value;
                        else
                        {
                            MessageBox.Show("Неправильный день");
                            return;
                        }
                    }
                }

            }
        }
        public int Month
        {
            get => month;
            set
            {
                if ((value < 1) || (value > 12))
                {

                    MessageBox.Show("Неправильный месяц");
                    return;

                }
                else { month = value; }
            }
        }
        public int Year
        {
            get => year;
            set => year = value;
        }

        public void ChangeTime(int d, int m, int y)
        {
            Day = d;
            Month = m;
            Year = y;
        }

        public Date(int day)
        {
            Day = day;
        }

        public Date(int day, int month)
        {
            Day = day;
            Month = month;
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void AddTime(int d, int m, int y)
        {

            if (Month == 2)
            {
                if (Year % 4 == 0)
                {
                    if (d + Day > 29)
                    {
                        AddTime(0, (int)Math.Ceiling(d / 29f), 0);
                        Day = d % 29;
                    }
                    else Day += d;
                }
                else
                {
                    if (d + Day > 28)
                    {
                        AddTime(0, (int)Math.Ceiling(d / 28f), 0);
                        Day = d % 28;
                    }
                    else Day += d;
                }
            }
            int[] дней31 = { 1, 3, 5, 7, 8, 10, 12 };
            int[] дней30 = { 4, 6, 9, 11 };
            for (int i = 0; i < дней30.Length; i++)
            {
                if (Month == дней30[i])
                {
                    if (d + Day > 30)
                    {
                        AddTime(0, (int)Math.Ceiling(d / 30f), 0);
                        Day = d % 30;
                    }
                    else Day += d;
                }
            }
            for (int i = 0; i < дней31.Length; i++)
            {
                if (Month == дней31[i])
                {
                    if (d + Day > 31)
                    {
                        AddTime(0, (int)Math.Ceiling(d / 31f), 0);
                        Day = d % 31;
                    }
                    else Day += d;
                }
            }

            if (m + Month > 12)
            {
                AddTime(0, 0, (int)Math.Ceiling(m / 12f));
                Month = m % 12;
            }
            else Month += m;

            Year += y;


        }

    }
}
