using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2__2_semestor_
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void openFileBt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        Sequence i = new Sequence(openFileDialog1.FileName);
                        digitsListTB.Text = Encoding.Default.GetString(i.Numbers);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void mainBt_Click(object sender, EventArgs e)
        {
            Sequence i = new Sequence(openFileDialog1.FileName);
            resultTB.Text = i.CountSequences().ToString();
        }

        private void digitsListTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
