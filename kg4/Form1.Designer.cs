namespace kg4
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.button7 = new System.Windows.Forms.Button();
            this.histogram5 = new kg4.Histogram();
            this.histogram4 = new kg4.Histogram();
            this.histogram3 = new kg4.Histogram();
            this.histogram2 = new kg4.Histogram();
            this.histogram1 = new kg4.Histogram();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 420);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 438);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(477, 420);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(725, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Однородный";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(833, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Гаусса";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(936, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Однородный М";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(614, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Эквализация";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(725, 450);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Контастирование";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(828, 512);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(239, 17);
            this.hScrollBar1.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(836, 450);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "HSL";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // histogram5
            // 
            this.histogram5.Location = new System.Drawing.Point(513, 482);
            this.histogram5.Name = "histogram5";
            this.histogram5.Size = new System.Drawing.Size(278, 165);
            this.histogram5.TabIndex = 12;
            this.histogram5.Text = "histogram5";
            // 
            // histogram4
            // 
            this.histogram4.Location = new System.Drawing.Point(779, 178);
            this.histogram4.Name = "histogram4";
            this.histogram4.Size = new System.Drawing.Size(260, 164);
            this.histogram4.TabIndex = 10;
            this.histogram4.Text = "histogram4";
            // 
            // histogram3
            // 
            this.histogram3.Location = new System.Drawing.Point(513, 178);
            this.histogram3.Name = "histogram3";
            this.histogram3.Size = new System.Drawing.Size(260, 164);
            this.histogram3.TabIndex = 9;
            this.histogram3.Text = "histogram3";
            // 
            // histogram2
            // 
            this.histogram2.Location = new System.Drawing.Point(779, 12);
            this.histogram2.Name = "histogram2";
            this.histogram2.Size = new System.Drawing.Size(260, 160);
            this.histogram2.TabIndex = 8;
            this.histogram2.Text = "histogram2";
            // 
            // histogram1
            // 
            this.histogram1.Location = new System.Drawing.Point(513, 12);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(260, 160);
            this.histogram1.TabIndex = 7;
            this.histogram1.Text = "histogram1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 857);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.histogram5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.histogram4);
            this.Controls.Add(this.histogram3);
            this.Controls.Add(this.histogram2);
            this.Controls.Add(this.histogram1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Histogram histogram1;
        private Histogram histogram2;
        private Histogram histogram3;
        private Histogram histogram4;
        private System.Windows.Forms.Button button5;
        private Histogram histogram5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button button7;
    }
}

