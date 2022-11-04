using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParantChildForms
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }
               
        public string TText
        {
            get
            {
                return textBox1.Text;
            }
        }      

        private void Child_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
