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
    public partial class AddFormOkazanie : Form
    {
        public AddFormOkazanie()
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
                DataRow nRow = main.практика1DataSet.Tables[4].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                
               
                main.практика1DataSet.Tables[4].Rows.Add(nRow);
                main.оказание_услугTableAdapter.Update(main.практика1DataSet.Оказание_услуг);
                main.практика1DataSet.Tables[4].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                
              
            }
        }
    }
}
