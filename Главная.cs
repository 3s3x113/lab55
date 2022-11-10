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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gf1 = new Form1();
            gf1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 gf2 = new Form2();
            gf2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Оплата_работы gf3 = new Оплата_работы();
            gf3.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
