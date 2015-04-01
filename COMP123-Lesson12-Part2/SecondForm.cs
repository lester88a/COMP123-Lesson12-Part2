using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson12_Part2
{
    public partial class SecondForm : Form
    {
        public SecondForm NextForm;
        public SecondForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.NextForm = (SecondForm)ActiveForm;
            this.NextForm.Hide();

            //this.Owner.Show();
            this.NextForm.Owner.Show();
        }

        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ActiveForm.BackColor = colorDialog1.Color;
            
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
    }
}
