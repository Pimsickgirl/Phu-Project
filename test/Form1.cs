using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input2 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input1 = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            main ma = new main();
            if (IsValidUser(username, password))
            {
                MessageBox.Show("ล็อกอินสำเร็จ!", "ล็อคอิน");
                this.Hide();
                ma.ShowDialog();
            }
            else
            {
                MessageBox.Show("ล็อกอินไม่สำเร็จ! กรุณาตรวจสอบชื่อผู้ใช้และรหัสผ่าน.","ล็อคอิน");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            string validUsername = "admin";
            string validPassword = "123456";
            return (username == validUsername && password == validPassword);
        }
    }
}
