using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Английские_карточки
{
    public partial class Конец : Form
    {
        public Конец()
        {
            this.InitializeComponent();
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            int k = 0;
            Тестирование a = new Тестирование();
            //textBox1.Text = a.Data.ToString();
            this.textBox1.ForeColor = Color.White;
            Задание_2 b = new Задание_2();
            //textBox2.Text = b.Data.ToString();
            this.textBox2.ForeColor = Color.White;
            Задание_3 c = new Задание_3();
            //textBox3.Text = c.Data.ToString();
            this.textBox3.ForeColor = Color.White;
            Задание_4 d = new Задание_4();
            //textBox4.Text = d.Data.ToString();
            this.textBox4.ForeColor = Color.White;
            Задание_5 i = new Задание_5();
            //textBox5.Text = i.Data.ToString();
            this.textBox5.ForeColor = Color.White;
            if (a.Data)
            {
                k++;
                this.textBox1.BackColor = Color.Green;
                this.textBox1.Text = "Выполнено";
            }
            else
            {
                this.textBox1.BackColor = Color.Red;
                this.textBox1.Text = "Не выполнено";
            }
            if (b.Data)
            {
                k++;
                this.textBox2.BackColor = Color.Green;
                this.textBox2.Text = "Выполнено";
            }
            else
            {
                this.textBox2.BackColor = Color.Red;
                this.textBox2.Text = "Не выполнено";
            }
            if (c.Data)
            {
                k++;
                this.textBox3.BackColor = Color.Green;
                this.textBox3.Text = "Выполнено";
            }
            else
            {
                this.textBox3.BackColor = Color.Red;
                this.textBox3.Text = "Не выполнено";
            }
            if (d.Data)
            {
                k++;
                this.textBox4.BackColor = Color.Green;
                this.textBox4.Text = "Выполнено";
            }
            else
            {
                this.textBox4.BackColor = Color.Red;
                this.textBox4.Text = "Не выполнено";
            }
            if (i.Data)
            {
                k++;
                this.textBox5.BackColor = Color.Green;
                this.textBox5.Text = "Выполнено";
            }
            else
            {
                this.textBox5.BackColor = Color.Red;
                this.textBox5.Text = "Не выполнено";
            }
            if (k == 5) this.textBox6.Text = "Отлично";
            else if (k == 4) this.textBox6.Text = "Хорошо";
            else if (k == 3) this.textBox6.Text = "Удовлетворительно";
            else this.textBox6.Text = "Неудовлетворительно";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрытие программы",
               MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
