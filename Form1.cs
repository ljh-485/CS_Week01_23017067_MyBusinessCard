namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            //0~255 사이의 R, G, B 값을 무작위로 생성하여 배경색을 변경
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/ljh-485",
                    UseShellExecute = true
                }
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.수원대7;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }
        
        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    } 
}
