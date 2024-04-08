using DataIVremya.classes;
using System.Text.RegularExpressions;

namespace DataIVremya
{
    public partial class Form1 : Form
    {
        Date new_date = new Date(1, 1, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new_date = new Date(1, 1, 1);
            UpdateDate();
        }

        private void Today_Click(object sender, EventArgs e)
        {
            string[] dates = Regex.Split(DateTime.UtcNow.ToString(),"[.  ]");
            new_date.ChangeTime(int.Parse(dates[0]), int.Parse(dates[1]), int.Parse(dates[2]));
            UpdateDate();
        }

        private void Year_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new_date.Year = int.Parse(Year.Text);
            }
            catch
            {
                MessageBox.Show("Неправильный год");
            }
        }

        private void Month_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new_date.Month = int.Parse(Month.Text);
            }
            catch
            {
                MessageBox.Show("Неправильный месяц");
            }
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new_date.Day = int.Parse(Day.Text);
            }
            catch
            {
                MessageBox.Show("Неправильный день");
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            new_date.AddTime(1, 0, 0);
            UpdateDate();
        }

        private void UpdateDate()
        {
            Day.Text = new_date.Day.ToString();
            Month.Text = new_date.Month.ToString();
            Year.Text = new_date.Year.ToString();
        }
    }
}
