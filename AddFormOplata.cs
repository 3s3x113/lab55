using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС_Салон_красоты
{
    public partial class AddFormOplata : Form
    {
        public AddFormOplata()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Оплата_работы main = this.Owner as Оплата_работы;
            if (main != null)
            {
                DataRow nRow = main.практика1DataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                main.практика1DataSet.Tables[5].Rows.Add(nRow);
                main.оплата_работыTableAdapter.Update(main.практика1DataSet.Оплата_работы);
                main.практика1DataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
        }
    }
}
