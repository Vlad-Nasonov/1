namespace Task_2__2_semestor_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileBt = new System.Windows.Forms.Button();
            this.mainBt = new System.Windows.Forms.Button();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.digitsListTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileBt
            // 
            this.openFileBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileBt.Location = new System.Drawing.Point(12, 12);
            this.openFileBt.Name = "openFileBt";
            this.openFileBt.Size = new System.Drawing.Size(93, 32);
            this.openFileBt.TabIndex = 0;
            this.openFileBt.Text = "Open File";
            this.openFileBt.UseVisualStyleBackColor = true;
            this.openFileBt.Click += new System.EventHandler(this.openFileBt_Click);
            // 
            // mainBt
            // 
            this.mainBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainBt.Location = new System.Drawing.Point(12, 76);
            this.mainBt.Name = "mainBt";
            this.mainBt.Size = new System.Drawing.Size(93, 32);
            this.mainBt.TabIndex = 1;
            this.mainBt.Text = "Count ";
            this.mainBt.UseVisualStyleBackColor = true;
            this.mainBt.Click += new System.EventHandler(this.mainBt_Click);
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(111, 83);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(100, 20);
            this.resultTB.TabIndex = 2;
            // 
            // digitsListTB
            // 
            this.digitsListTB.Location = new System.Drawing.Point(111, 19);
            this.digitsListTB.Name = "digitsListTB";
            this.digitsListTB.Size = new System.Drawing.Size(316, 20);
            this.digitsListTB.TabIndex = 3;
            this.digitsListTB.TextChanged += new System.EventHandler(this.digitsListTB_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 123);
            this.Controls.Add(this.digitsListTB);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.mainBt);
            this.Controls.Add(this.openFileBt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileBt;
        private System.Windows.Forms.Button mainBt;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.TextBox digitsListTB;
    }
}