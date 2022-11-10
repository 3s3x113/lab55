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
    public partial class Form2 : Form
    {
        public object оказание_услугTableAdapte { get; internal set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Оказание_услуг_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Мастер". При необходимости она может быть перемещена или удалена.
            this.мастерTableAdapter.Fill(this.практика1DataSet.Мастер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.практика1DataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Запись_в_салон". При необходимости она может быть перемещена или удалена.
            this.запись_в_салонTableAdapter.Fill(this.практика1DataSet.Запись_в_салон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.практика1DataSet.Услуга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Оказание_услуг". При необходимости она может быть перемещена или удалена.
            this.оказание_услугTableAdapter.Fill(this.практика1DataSet.Оказание_услуг);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFormOkazanie sf = new SearchFormOkazanie();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Оплата_работы gf1 = new Оплата_работы();
            gf1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddFormOkazanie af = new AddFormOkazanie();
            af.Owner = this;
            af.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddFormOborudovanie af = new AddFormOborudovanie();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            один af = new один();
            af.Owner = this;
            af.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            оказание_услугTableAdapter.Update(практика1DataSet);
            оборудованиеTableAdapter.Update(практика1DataSet);
            мастерTableAdapter.Update(практика1DataSet);    
        }
    }
}
