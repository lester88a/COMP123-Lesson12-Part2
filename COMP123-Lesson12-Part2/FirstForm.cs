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
    public partial class FirstForm : Form
    {
        
        //created a variable
        public SecondForm NextForm = new SecondForm();
        public FirstForm PrimaryForm;
        public FirstForm()
        {
            InitializeComponent();
        }
        
        //event handeler
        private void NextButton_Click(object sender, EventArgs e)
        {
            //convert activeForm to primaryForm
            this.PrimaryForm = (FirstForm)ActiveForm;

            //hide firstForm and show next form
            this.PrimaryForm.Hide();

            this.NextForm.Owner = this.PrimaryForm;
            NextForm.Show();
        }
    }
}
