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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void Parent_Load(object sender, EventArgs e)
        {

       
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        
        private void Add_Click(object sender, EventArgs e)
        {
            Child form1 = new Child();
            Child parent = new Child();
            if (form1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form1.TText);
            }
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            Child form1 = new Child();
            if (form1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form1.TText);
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
