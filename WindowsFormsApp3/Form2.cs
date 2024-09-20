using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void buttom1_dangnhap(object sender, EventArgs e)
        {
            Form1 form = new Form1();   
            form.ShowDialog();
        }

        private void buttom1_dangki(object sender, EventArgs e)
        {
            Form3 fo=new Form3();
            fo.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
