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
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Проверка заполненности полей
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (this.tbSername.Text == "" || this.tbName.Text == "" ||
                this.tbPatronomic.Text == "" || this.tbGr.Text == "" ||
                this.tbLogin.Text == "" || this.tbPassword.Text == "")
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Кнопка регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните все поля","Информация",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }

            var newUser = EntityManager.UserDataTable.NewПользователиRow();
            newUser.Фамилия = this.tbSername.Text;
            newUser.Имя = this.tbName.Text;
            newUser.Отчество = this.tbPatronomic.Text;
            newUser.Группа = this.tbGr.Text;
            newUser.Логин = this.tbLogin.Text;
            newUser.Пароль = this.tbPassword.Text;
            EntityManager.UserDataTable.AddПользователиRow(newUser);
            EntityManager.UpdateUsers();

            MessageBox.Show("Регистрация успешна","Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        /// <summary>
        /// Запрет на ввод цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
