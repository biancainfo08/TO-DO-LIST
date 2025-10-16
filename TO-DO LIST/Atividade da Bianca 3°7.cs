using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TO_DO_LIST
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Lista = Convert.ToString(txtColocar.Text);

            listBox1.Items.Add(Lista);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string Lista = Convert.ToString(txtColocar.Text);

            listBox1.Items.Remove(Lista);
        }
    }
}
