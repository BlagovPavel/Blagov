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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "яхтенная_ВерфьDataSet6.Лодки". При необходимости она может быть перемещена или удалена.
            this.лодкиTableAdapter.Fill(this.яхтенная_ВерфьDataSet6.Лодки);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 s = new Form10();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 s = new Form8();
            s.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
