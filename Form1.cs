using System;
using System.Drawing;
using System.Windows.Forms;

namespace Printscrin
{
    public partial class Form1 : Form
    {
        private int screenIndex = 2;
        
        Size size = new Size();
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementation
        }
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(this.groupBox1);
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (screenIndex == 2)
            {
                groupBox1.Show();
                groupBox1.Size = new Size(1, 1);
                groupBox1.Location = MousePosition;
                size = new Size(MousePosition.X, MousePosition.Y);

            screenIndex = 1;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (screenIndex == 1)
            {
                if (MousePosition.X > groupBox1.Location.X && MousePosition.Y > groupBox1.Location.Y)//правый нижний
                {
                    groupBox1.Size = new Size()
                    {
                        Width = MousePosition.X - size.Width,
                        Height = MousePosition.Y - size.Height
                    };
                }
                if (MousePosition.X < groupBox1.Location.X && MousePosition.Y > groupBox1.Location.Y)//левый нижний
                {
                    groupBox1.Size = new Size(1, 1);
                    //groupBox1.Location = new ;
                }
                if (MousePosition.X > groupBox1.Location.X && MousePosition.Y < groupBox1.Location.Y) //правый верхний
                { 

                }
                if (MousePosition.X < groupBox1.Location.X && MousePosition.Y < groupBox1.Location.Y) //левый верхний
                { 

                }

                //groupBox.Hide();

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            screenIndex = 0;

        }
    }
}
