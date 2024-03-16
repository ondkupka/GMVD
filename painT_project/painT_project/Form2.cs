using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace painT_project
{
    public partial class Form2 : Form
    {
        ButtonHandler buttonHandler = new ButtonHandler();

        public Color color { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void clrpick_btn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
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
    }
}
