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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.практика1DataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Мастер". При необходимости она может быть перемещена или удалена.
            this.мастерTableAdapter.Fill(this.практика1DataSet.Мастер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.практика1DataSet.Услуга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Запись_в_салон". При необходимости она может быть перемещена или удалена.
            this.запись_в_салонTableAdapter.Fill(this.практика1DataSet.Запись_в_салон);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 gf1 = new Form2();
            gf1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            запись_в_салонTableAdapter.Update(практика1DataSet);
            мастерTableAdapter.Update(практика1DataSet);
            клиентTableAdapter.Update(практика1DataSet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            запись af = new запись();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            клиент af = new клиент();
            af.Owner = this;
            af.Show();
        }
    }   
}
