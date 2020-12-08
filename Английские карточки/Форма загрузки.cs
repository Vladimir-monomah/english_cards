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
    public partial class Форма_загрузки : Form
    {
        public Форма_загрузки()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Метод загрузки программы по прогресбару5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            if (this.progressBar.Value == 100)
            {
                this.timer.Stop();

                Авторизация открыть = new Авторизация();
                this.Hide();
                открыть.ShowDialog();
            }
        }
    }
}
