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
    public partial class Оплата_работы : Form
    {
        public Оплата_работы()
        {
            InitializeComponent();
        }

        private void Оплата_работы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.практика1DataSet.Услуга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Оказание_услуг". При необходимости она может быть перемещена или удалена.
            this.оказание_услугTableAdapter.Fill(this.практика1DataSet.Оказание_услуг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Мастер". При необходимости она может быть перемещена или удалена.
            this.мастерTableAdapter.Fill(this.практика1DataSet.Мастер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.практика1DataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика1DataSet.Оплата_работы". При необходимости она может быть перемещена или удалена.
            this.оплата_работыTableAdapter.Fill(this.практика1DataSet.Оплата_работы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFormOplata sf = new SearchFormOplata();
            sf.Owner = this;
            sf.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddFormOplata af = new AddFormOplata();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            оборудование af = new оборудование();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            оплата_работыTableAdapter.Update(практика1DataSet);
            услугаTableAdapter.Update(практика1DataSet);
        }
    }
}
