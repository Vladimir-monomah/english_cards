﻿namespace Английские_карточки
{
    partial class Главная_форма
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Главная_форма));
            this.label_russian = new System.Windows.Forms.Label();
            this.label_english = new System.Windows.Forms.Label();
            this.picture_card = new System.Windows.Forms.PictureBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.label_video = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picture_card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // label_russian
            // 
            this.label_russian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_russian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_russian.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_russian.ForeColor = System.Drawing.Color.Red;
            this.label_russian.Location = new System.Drawing.Point(92, 2);
            this.label_russian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_russian.Name = "label_russian";
            this.label_russian.Size = new System.Drawing.Size(322, 52);
            this.label_russian.TabIndex = 0;
            this.label_russian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_russian.Click += new System.EventHandler(this.label_russian_Click);
            // 
            // label_english
            // 
            this.label_english.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_english.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_english.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_english.ForeColor = System.Drawing.Color.Blue;
            this.label_english.Location = new System.Drawing.Point(92, 340);
            this.label_english.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_english.Name = "label_english";
            this.label_english.Size = new System.Drawing.Size(322, 55);
            this.label_english.TabIndex = 1;
            this.label_english.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_english.Click += new System.EventHandler(this.label_english_Click);
            // 
            // picture_card
            // 
            this.picture_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_card.Location = new System.Drawing.Point(92, 47);
            this.picture_card.Margin = new System.Windows.Forms.Padding(4);
            this.picture_card.Name = "picture_card";
            this.picture_card.Size = new System.Drawing.Size(322, 297);
            this.picture_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_card.TabIndex = 2;
            this.picture_card.TabStop = false;
            this.picture_card.Click += new System.EventHandler(this.label_video_Click);
            // 
            // button_next
            // 
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next.Location = new System.Drawing.Point(423, 174);
            this.button_next.Margin = new System.Windows.Forms.Padding(4);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(83, 70);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "»";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prev.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prev.Location = new System.Drawing.Point(1, 174);
            this.button_prev.Margin = new System.Windows.Forms.Padding(4);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(83, 70);
            this.button_prev.TabIndex = 4;
            this.button_prev.Text = "«";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // label_video
            // 
            this.label_video.AutoSize = true;
            this.label_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_video.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_video.Location = new System.Drawing.Point(419, 47);
            this.label_video.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_video.Name = "label_video";
            this.label_video.Size = new System.Drawing.Size(89, 20);
            this.label_video.TabIndex = 5;
            this.label_video.Text = "+ видео";
            this.label_video.Visible = false;
            this.label_video.Click += new System.EventHandler(this.label_video_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(69, 38);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(242, 242);
            this.player.TabIndex = 6;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // Главная_форма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 406);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label_video);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.picture_card);
            this.Controls.Add(this.label_english);
            this.Controls.Add(this.label_russian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Главная_форма";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Англйские карточки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Главная_форма_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picture_card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_russian;
        private System.Windows.Forms.Label label_english;
        private System.Windows.Forms.PictureBox picture_card;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Label label_video;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

