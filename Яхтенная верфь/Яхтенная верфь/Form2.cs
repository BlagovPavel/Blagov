using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Яхтенная_верфь
{
    public partial class Form2 : Form
    {
        private const string V = "wsr1";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "wsrX" && textBox2.Text == "wsrX")
            {
                Form3 s = new Form3();
                s.Show();
                this.Hide();
            }
        }
    }
}
