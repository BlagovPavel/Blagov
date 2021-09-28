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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "яхтенная_ВерфьDataSet7.Менеджерыxlsx". При необходимости она может быть перемещена или удалена.
            this.менеджерыxlsxTableAdapter.Fill(this.яхтенная_ВерфьDataSet7.Менеджерыxlsx);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 s = new Form11();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 s = new Form9();
            s.Show();
            this.Hide();
        }
    }
}
