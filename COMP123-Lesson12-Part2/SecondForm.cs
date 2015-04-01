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
    }
}
