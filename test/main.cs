using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องการจะออกจากระบบใช่หรือไม่?", "ยืนยันการออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/suphakan.seeya/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string timeText = currentTime.ToString("HH:mm:ss");
            label1.Text = "เวลาปัจจุบัน: " + timeText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string timeText = currentTime.ToString("HH:mm:ss");
            MessageBox.Show("เวลาปัจจุบัน: " + timeText, "เวลาปัจจุบัน");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qrcodemain qr = new qrcodemain();
            qr.ShowDialog();
        }
    }
}
