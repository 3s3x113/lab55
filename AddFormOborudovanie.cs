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
    public partial class AddFormOborudovanie : Form
    {
        public AddFormOborudovanie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main.практика1DataSet.Tables[3].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
              
                main.практика1DataSet.Tables[3].Rows.Add(nRow);
                main.оборудованиеTableAdapter.Update(main.практика1DataSet.Оборудование);
                main.практика1DataSet.Tables[3].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox1.Text = "";
               
            }
        }
    }
}
