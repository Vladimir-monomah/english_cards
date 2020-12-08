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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            this.InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрытие программы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            var loginCondition = $"логин = '{this.textBox_login.Text}' AND пароль = '{this.textBox_password.Text}' ";
            var user = EntityManager.FilterUsers(loginCondition).FirstOrDefault();
            if (user != null)
            { 
                Главная_форма главная_Форма = new Главная_форма();
                this.Hide();
                главная_Форма.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            Регистрация открыть = new Регистрация();
            открыть.ShowDialog();
        }
    }
}
