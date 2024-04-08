using Treugolnik.classes;

namespace Treugolnik
{
    public partial class Form1 : Form
    {
        Treugolnikk треугольник = new Treugolnikk();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                треугольник.Kатет1 = double.Parse(textBox1.Text);
                треугольник.Kатет2 = double.Parse(textBox2.Text);

                label1.Text = треугольник.Рассчёт().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание!\nПроизошла ошибка:\n" + ex.ToString());
            }
        }
    }
}
