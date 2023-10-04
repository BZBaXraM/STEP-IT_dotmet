namespace CancelationTokenWinform
{
    public partial class Form1 : Form
    {

        static CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token1 = cts.Token;

        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ThreadPool.QueueUserWorkItem(o =>
            {
                Counter(token1);
            });
        }

        private void Counter(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                count++;
                Thread.Sleep(100);
                label1.Text = count.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}