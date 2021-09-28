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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "яхтенная_ВерфьDataSet9.Счет". При необходимости она может быть перемещена или удалена.
            this.счетTableAdapter.Fill(this.яхтенная_ВерфьDataSet9.Счет);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 s = new Form11();
            s.Show();
            this.Hide();
        }
    }
}
