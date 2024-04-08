using Accessibility;

namespace ListBox
{
    public partial class FormList : Form
    {
        int maxValue;
        int minValue;
        int size;
        int[] arr = new int[1];
        int[] sortArr = new int[1];
        Random rnd = new Random();

        public FormList()
        {
            InitializeComponent();
        }

        private void CreateNew_Click(object sender, EventArgs e)
        {
            try
            {
                size = Convert.ToInt32(SizeBox.Text);
                arr = new int[size];
                sortArr = new int[size];
                ResoltBox.Text = ". . .";
            }
            catch (Exception ex)
            {
                ResoltBox.Text = ex.ToString();
            }
        }

        private void FillRandom_Click(object sender, EventArgs e)
        {
            try
            {
                minValue = Convert.ToInt32(MinBox.Text);
                maxValue = Convert.ToInt32(MaxBox.Text);
                if (minValue > maxValue) throw (new Exception());

                for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(minValue, maxValue + 1);
                ResoltBox.Text = ". . .";
            }
            catch (Exception)
            {
                ResoltBox.Text = ". . .";
            }
        }

        private void CurrentState_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < arr.Length; i++) listBox1.Items.Add(arr[i]);
            ResoltBox.Text = ". . .";
        }

        private void Transformation_Click(object sender, EventArgs e) //Вариант 8
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == maxValue) sortArr[i] = 0;
                else sortArr[i] = arr[i];
            }
            ResoltBox.Text = ". . .";
        }

        private void CurrentState2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < sortArr.Length; i++) listBox2.Items.Add(sortArr[i]);
            ResoltBox.Text = ". . .";
        }
    }
}
