using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace painT_project
{
    public partial class Form2 : Form
    {
        ButtonHandler buttonHandler = new ButtonHandler();
        public Point lastPoint;
        public Color color { get; private set; }
        public Bitmap myBitmap;
        public int value;
        public int mouseXLast = 0;
        public int mouseYLast = 0;
        public bool moving = false;
        Graphics graphics;
        Pen myPen = new Pen(Color.Black, 10);
        public Form2()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = myBitmap;
        }
        
        private void clrpick_btn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.ShowDialog();
            color = cd.Color;
            crrnt_clr.BackColor = color;
            if (buttonHandler.pcXsc == true)
                pc_btn.BackColor = color;
            else
                sc_btn.BackColor = color;
        }

        private void pc_btn_Click(object sender, EventArgs e)
        {
            buttonHandler.Pc_btn_Click(pc_btn, sc_btn, crrnt_clr);
        }
        private void sc_btn_Click(object sender, EventArgs e)
        {
            buttonHandler.Sc_btn_Click(pc_btn, sc_btn, crrnt_clr);
        }
        private void c1_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }
        private void c2_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }
        private void c3_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c4_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c5_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c6_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c7_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c8_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c9_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c10_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c11_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c12_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c13_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c14_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c15_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c16_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c17_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c18_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c19_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c20_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c21_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c22_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c23_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void c24_Click(object sender, EventArgs e)
        {
            buttonHandler.ColorButton_Click(sender, e, pc_btn, sc_btn, crrnt_clr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            value = trackBar1.Value + 1;
            label3.Text = value.ToString() + " px";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int width = Screen.PrimaryScreen.Bounds.Width + 10;
            int height = Screen.PrimaryScreen.Bounds.Height;
            panel1.Width = width;
            button2.Location = new Point(width-32,4);
            pictureBox1.Width = width;
            pictureBox1.Height = height-105;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }
    }
}
