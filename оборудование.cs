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
    public partial class оборудование : Form
    {
        public оборудование()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Оплата_работы main = this.Owner as Оплата_работы;
            if (main != null)
            {
                DataRow nRow = main.практика1DataSet.Tables[6].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
               
                main.практика1DataSet.Tables[6].Rows.Add(nRow);
                main.услугаTableAdapter.Update(main.практика1DataSet.Услуга);
                main.практика1DataSet.Tables[6].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox1.Text = "";
               

            }
        }
    }
}
