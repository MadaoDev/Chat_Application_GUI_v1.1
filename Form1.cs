using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracer_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!(UsernameBox.Text == string.Empty))
            {
                if (!(PasswordBox.Text == string.Empty))
                {
                    Form2 f2 = new Form2(); //this is the change, code for redirect  
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" password empty", "login page");
                }
            }
            else
            {
                MessageBox.Show(" username empty", "login page");
            }
            // con.Close();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
