namespace winfromcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,user", "Fist Message");
            MessageBox.Show("Hello,user", "Fist Message",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดจริงหรือไม่", "เเเเเเเเเน่ใจนะ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //ยกเลิกคำสั่งปิดฟอร์ม

            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {//เปิดไฟ
            this.BackColor = Color.AliceBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {//ปิดไฟ
            this.BackColor = Color.MediumVioletRed;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Lavender;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Bisque;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.RoyalBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LawnGreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "มหาวิทยาลัยราชฎัทอุดรธานี")
            {
                label1.Text = "Udonthani Rajaphat University";
            }
            else
            {
                label1.Text = "มหาวิทยาลัยราชฎัทอุดรธานี";
            }

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.AliceBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.BurlyWood;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);

            label1.ForeColor = Color.FromArgb(r, g, b);
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
        }
    }
}

