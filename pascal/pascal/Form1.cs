namespace pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Faktorialis(int n)
        {
            int eredmeny = 1;
            for (int i = 0; i <= n; i++)
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Button button = new Button();
                    button.Text = (i * j).ToString();
                    button.Top = i*40;
                    button.Left = (j*40) - (i*(40/2)) + 300;
                    button.Height = 40;
                    button.Width = 40;
                    int x = Faktorialis(i) / (Faktorialis(j) * Faktorialis(i - j));
                    button.Text = x.ToString();
                    Controls.Add(button);
                }
            }
        }
    }
}