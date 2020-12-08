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
    public partial class Задание_5 : Form
    {
        public Задание_5()
        {
            this.InitializeComponent();
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
        }

        public static bool o;
        public bool Data
        {
            get
            {
                return o;
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if ((!this.radioButton1.Checked) && (!this.radioButton2.Checked)
                && (!this.radioButton3.Checked))
                MessageBox.Show("Надо ответить на вопрос!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if ((!this.radioButton1.Checked) && (this.radioButton2.Checked) && (!this.radioButton3.Checked))
            {
                {
                    MessageBox.Show("Вы ответили правильно на данный вопрос!",
                        "Поздравление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    o = true;
                }
                this.radioButton1.Enabled = false;
                this.radioButton2.Enabled = false;
                this.radioButton3.Enabled = false;
            }
            else
            {
                {
                    MessageBox.Show("Вы неправильно ответили на данный вопрос!", "Печально",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    o = false;
                }
                this.radioButton1.Enabled = false;
                this.radioButton2.Enabled = false;
                this.radioButton3.Enabled = false;
            }
            Конец открыть = new Конец();
            this.Hide();
            открыть.ShowDialog();
        }
    }
}
