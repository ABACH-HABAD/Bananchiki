using Treugolnik.classes;

namespace Treugolnik
{
    public partial class Form1 : Form
    {
        Treugolnikk ����������� = new Treugolnikk();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                �����������.K����1 = double.Parse(textBox1.Text);
                �����������.K����2 = double.Parse(textBox2.Text);

                label1.Text = �����������.�������().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������!\n��������� ������:\n" + ex.ToString());
            }
        }
    }
}
