namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = $"Main Ui {Thread.CurrentThread.ManagedThreadId}";
            Thread thread = new Thread(() =>
            {
                label3.Text = $"My Thread {Thread.CurrentThread.ManagedThreadId}";
                for (int i = 0; i < 10000; i++)
                {
                    label1.Text = i.ToString();
                    Thread.Sleep(10);
                }
            });
            thread.Start();

        }
    }
}