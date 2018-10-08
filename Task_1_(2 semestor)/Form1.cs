using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_logic_3_;


namespace Task_1__2_semestor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_LoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Work_with_Files f = new Work_with_Files(openFileDialog1.FileName);
               textBox_ShowText.Lines = f.Lines;
                openFileDialog1.Dispose();
            }
        }

        private void textBox_ShowText_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                Work_with_Files.WriteToFileAllLines(path, textBox1.Lines);
            }
        }
        private void button_down_Click(object sender, EventArgs e)
        {
            Work_with_Files f = new Work_with_Files(openFileDialog1.FileName);
            textBox1.Lines = f.ChangeLines(Convert.ToInt32(textBox_K.Text), false);
        }

        private void button_high_Click(object sender, EventArgs e)
        {
            Work_with_Files f = new Work_with_Files(openFileDialog1.FileName);
            
            textBox1.Lines = (f.ChangeLines(Convert.ToInt32(textBox_K.Text), true));
        }


    }
}
