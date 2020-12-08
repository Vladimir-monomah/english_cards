using System.IO;

namespace Английские_карточки
{
    class Dictionary
    {
        int total = 0;
        string[] english;//apple
        string[] russian;//яблоко
        string[] audio_eng;//engish/apple.mp3
        string[] audio_rus;//english/apple.mp3
        string[] image;//image/apple.jpg
        string[] video;//video/apple.mp4 либо ""

        /// <summary>
        /// Конструктор Dictionary
        /// </summary>
        public Dictionary()
        {
            this.Init();
        }
        /// <summary>
        /// Возвращение количества исходных данных
        /// </summary>
        /// <returns></returns>
        public int Total()
        {
            return this.total;
        }

        public string English(int nr)
        {
            if (nr < 0 || nr >= this.total) return "";
            return this.english[nr];
        }

        public string Russian(int nr)
        {
            if (nr < 0 || nr >= this.total) return "";
            return this.russian[nr];
        }

        public string Audio_eng(int nr)
        {
            if (nr < 0 || nr >= this.total) return "";
            return this.audio_eng[nr];
        }

        public string Audio_rus(int nr)
        {
            if (nr < 0 || nr >= this.total) return "";
            return this.audio_rus[nr];
        }

        public string Image(int nr)
        {
            if (nr < 0 || nr >= this.total) return "";
            return this.image[nr];
        }

        public string Video (int nr)
        {
            if (nr < 0 || nr >= this.total) return "";
            return this.video[nr];
        }
        /// <summary>
        /// Доступ к файлам
        /// </summary>
        private void Init()
        {
            this.total = 0;
            DirectoryInfo di = new DirectoryInfo("data\\text\\");
            FileInfo[] info = di.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
            this.total = info.Length;

            this.english = new string[this.total];
            this.russian = new string[this.total];
            this.audio_eng = new string[this.total];
            this.audio_rus = new string[this.total];
            this.image = new string[this.total];
            this.video = new string[this.total];
            int j = 0;
            foreach(FileInfo file in info)
            {
                string filename = file.FullName;//data\\apple.txt
                string name = file.Name.Replace(".txt", "");//apple
                string[] lines = File.ReadAllLines(filename);//считывание элементов
                this.english[j] = lines[0];
                this.russian[j] = lines[1];
                this.audio_eng[j] = "data\\english\\" + name + ".mp3";
                this.audio_rus[j] = "data\\russian\\" + name + ".mp3";
                if (!File.Exists(this.audio_eng[j])) this.audio_eng[j] = "";
                if (!File.Exists(this.audio_rus[j])) this.audio_rus[j] = "";

                this.image[j] = "data\\images\\" + name + ".jpg";
                this.video[j] = "data\\video\\" + name + ".mp4";
                if (!File.Exists(this.image[j])) this.image[j] = "";
                if (!File.Exists(this.video[j])) this.video[j] = "";

                j++;
            }
        }
    }
}
