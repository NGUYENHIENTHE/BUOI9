using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Ketnoi kn = new Ketnoi();
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            connsql = kn.connect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string insertString;
                insertString = "insert into KHOA values('" + textBox1.Text + "',N'" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString,connsql);
                cmd.ExecuteNonQuery();
                if(connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh cong cai gi");
            }
            catch (Exception ex)    
            {
                MessageBox.Show("That bai");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string deleteString;
                deleteString = "DELETE KHOA WHERE MAKHOA='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string updateString;
                updateString = "update KHOA set TENKHOA='" + textBox2.Text + "' where MAKHOA = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Vui long nhap ma khoa!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider2.SetError(textBox2, "Vui long nhap ten khoa!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, null);
            }
        }
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
    }
}
