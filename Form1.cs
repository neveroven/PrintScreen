using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printscrin
{
    public partial class Form1 : Form
    {
        int screenIndex = 0;
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementation
        }
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (screenIndex == 0)
            {
                //MousePosition
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.TabIndex = 0;
            numericUpDown.Focus();
            numericUpDown.Select(0, numericUpDown.Value.ToString().Length);
        }
    }
}
