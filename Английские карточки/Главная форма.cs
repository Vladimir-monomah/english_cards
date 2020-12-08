using System;
using System.Drawing;
using System.Windows.Forms;

namespace Английские_карточки
{
    public partial class Главная_форма : Form
    {
        Dictionary dict;
        int curr = 0;

        public Главная_форма()
        {

            this.InitializeComponent();

            this.dict = new Dictionary();//экземляр объекта, который вызывает конструктор Dictionary
            this.ShowCard();//Вызывание метода при инициализации проекта
        }
        /// <summary>
        /// Отображение карточек на экране
        /// </summary>
        public void ShowCard()
        {
            if(this.dict.Image(this.curr)!="")
                this.picture_card.Image = Image.FromFile(this.dict.Image(this.curr));
            this.label_english.Text = this.dict.English(this.curr);
            this.label_russian.Text = this.dict.Russian(this.curr);
            this.label_video.Visible = this.dict.Video(this.curr) !="";

        }
        /// <summary>
        /// Предыдущая карточка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_prev_Click(object sender, EventArgs e)
        {
            if (this.curr <= 0) return;
            this.curr--;
            this.ShowCard();
        }
        /// <summary>
        /// Следующая карточка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_next_Click(object sender, EventArgs e)
        {
            if (this.curr >= this.dict.Total() - 1)
            {
                MessageBox.Show("Переходим к проверке знаний!","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Тестирование открыть = new Тестирование();
                this.Hide();
                открыть.ShowDialog();
                return;
            }
            this.curr++;
            this.ShowCard();
        }
        /// <summary>
        /// Воспроизведение звука
        /// </summary>
        /// <param name="filename"></param>
        private void play_mp3(string filename)
        {
            if (filename == "") return;
            this.player.Visible = false;
            this.player.URL = filename;
        }
        /// <summary>
        /// Воспроизведение видео
        /// </summary>
        /// <param name="filename"></param>
        private void play_mp4(string filename)
        {
            if (filename == "") return;
            this.player.Visible = true;
            this.player.uiMode = "none";
            this.player.URL = filename;
        }
        /// <summary>
        /// Воспроизведение русского перевода по нажатию на русское слово
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_russian_Click(object sender, EventArgs e)
        {
            this.play_mp3(this.dict.Audio_rus(this.curr));
        }
        /// <summary>
        /// Воспроизведение английского перевода по нажатию на английское слово
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_english_Click(object sender, EventArgs e)
        {
            this.play_mp3(this.dict.Audio_eng(this.curr));
        }
        /// <summary>
        /// Воспросизведение видео по нажатию на картинку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_video_Click(object sender, EventArgs e)
        {
            this.play_mp4(this.dict.Video(this.curr));
        }
        /// <summary>
        /// Событие на закрытие плеера при окончании видео
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
                this.player.Visible = false;
        }
        /// <summary>
        /// Закрытие программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Главная_форма_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите выйти?",
                    "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
            else Application.Exit();
        }
    }
}
