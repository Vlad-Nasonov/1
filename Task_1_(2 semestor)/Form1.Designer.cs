namespace Task_1__2_semestor_
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_LoadFile = new System.Windows.Forms.Button();
            this.textBox_ShowText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_high = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_K = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button_LoadFile
            // 
            this.button_LoadFile.Location = new System.Drawing.Point(24, 21);
            this.button_LoadFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_LoadFile.Name = "button_LoadFile";
            this.button_LoadFile.Size = new System.Drawing.Size(87, 44);
            this.button_LoadFile.TabIndex = 0;
            this.button_LoadFile.Text = "Загрузить текст";
            this.button_LoadFile.UseVisualStyleBackColor = true;
            this.button_LoadFile.Click += new System.EventHandler(this.button_LoadFile_Click);
            // 
            // textBox_ShowText
            // 
            this.textBox_ShowText.Location = new System.Drawing.Point(24, 110);
            this.textBox_ShowText.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ShowText.Multiline = true;
            this.textBox_ShowText.Name = "textBox_ShowText";
            this.textBox_ShowText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ShowText.Size = new System.Drawing.Size(190, 243);
            this.textBox_ShowText.TabIndex = 2;
            this.textBox_ShowText.TextChanged += new System.EventHandler(this.textBox_ShowText_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_high
            // 
            this.button_high.Location = new System.Drawing.Point(139, 21);
            this.button_high.Name = "button_high";
            this.button_high.Size = new System.Drawing.Size(75, 44);
            this.button_high.TabIndex = 3;
            this.button_high.Text = "Удалить сверху";
            this.button_high.UseVisualStyleBackColor = true;
            this.button_high.Click += new System.EventHandler(this.button_high_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(250, 22);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(75, 43);
            this.button_down.TabIndex = 4;
            this.button_down.Text = "Удалить снизу";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(181, 243);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(356, 21);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 44);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Сохранить текст";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = " K :";
            // 
            // textBox_K
            // 
            this.textBox_K.Location = new System.Drawing.Point(50, 80);
            this.textBox_K.Name = "textBox_K";
            this.textBox_K.Size = new System.Drawing.Size(61, 20);
            this.textBox_K.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 295);
            this.Controls.Add(this.textBox_K);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_high);
            this.Controls.Add(this.textBox_ShowText);
            this.Controls.Add(this.button_LoadFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LoadFile;
        private System.Windows.Forms.TextBox textBox_ShowText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_high;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_K;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

