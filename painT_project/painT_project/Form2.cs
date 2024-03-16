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
        public Form2()
        {
            InitializeComponent();
        }

        Color color = new Color();
        public bool pcXsc = true;
        private void clrpick_btn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            color = cd.Color;
            crrnt_clr.BackColor = color;
            if (pcXsc == true) 
                pc_btn.BackColor = color;
            else
                sc_btn.BackColor = color;
        }

        private void pc_btn_Click(object sender, EventArgs e)
        {
            pcXsc = true;
            checkMain();
        }
        public void checkMain()
        {
            
            if (pcXsc == true)
            {
                color = pc_btn.BackColor;
                crrnt_clr.BackColor = color;
                pc_btn.FlatAppearance.BorderColor = Color.Aqua;
                pc_btn.FlatAppearance.BorderSize = 1;
                sc_btn.FlatAppearance.BorderColor = Color.White;
                sc_btn.FlatAppearance.BorderSize = 3;
            }   
            else
            {
                pc_btn.FlatAppearance.BorderColor = Color.White;
                pc_btn.FlatAppearance.BorderSize = 3;
                sc_btn.FlatAppearance.BorderColor = Color.Aqua;
                sc_btn.FlatAppearance.BorderSize = 1;
                color = sc_btn.BackColor;
                crrnt_clr.BackColor = color;
            }
        }

        private void sc_btn_Click(object sender, EventArgs e)
        {
            pcXsc = false;
            checkMain();    
        }

        private void c1_Click(object sender, EventArgs e)
        {
            color = c1.BackColor;
            checkButton();
            
        }
        
        public void checkButton()
        {
            crrnt_clr.BackColor = color;
            if (pcXsc == true)
                pc_btn.BackColor= color;
            else
                sc_btn.BackColor = color;
        }

        private void c2_Click(object sender, EventArgs e)
        {
            color = c2.BackColor;
            checkButton();
        }

        private void c3_Click(object sender, EventArgs e)
        {
            color = c3.BackColor;
            checkButton();
        }

        private void c4_Click(object sender, EventArgs e)
        {
            color = c4.BackColor;
            checkButton();
        }

        private void c5_Click(object sender, EventArgs e)
        {
            color = c5.BackColor;
            checkButton();
        }

        private void c6_Click(object sender, EventArgs e)
        {
            color = c6.BackColor;
            checkButton();
        }

        private void c7_Click(object sender, EventArgs e)
        {
            color = c7.BackColor;
            checkButton();
        }

        private void c8_Click(object sender, EventArgs e)
        {
            color = c8.BackColor;
            checkButton();
        }

        private void c9_Click(object sender, EventArgs e)
        {
            color = c9.BackColor;
            checkButton();
        }

        private void c10_Click(object sender, EventArgs e)
        {
            color = c10.BackColor;
            checkButton();
        }

        private void c11_Click(object sender, EventArgs e)
        {
            color = c11.BackColor;
            checkButton();
        }

        private void c12_Click(object sender, EventArgs e)
        {
            color = c12.BackColor;
            checkButton();
        }

        private void c13_Click(object sender, EventArgs e)
        {
            color = c13.BackColor;
            checkButton();
        }

        private void c14_Click(object sender, EventArgs e)
        {
            color = c14.BackColor;
            checkButton();
        }

        private void c15_Click(object sender, EventArgs e)
        {
            color = c15.BackColor;
            checkButton();
        }

        private void c16_Click(object sender, EventArgs e)
        {
            color = c16.BackColor;
            checkButton();
        }

        private void c17_Click(object sender, EventArgs e)
        {
            color = c17.BackColor;
            checkButton();
        }

        private void c18_Click(object sender, EventArgs e)
        {
            color = c18.BackColor;
            checkButton();
        }

        private void c19_Click(object sender, EventArgs e)
        {
            color = c19.BackColor;
            checkButton();
        }

        private void c20_Click(object sender, EventArgs e)
        {
            color = c20.BackColor;
            checkButton();
        }

        private void c21_Click(object sender, EventArgs e)
        {
            color = c21.BackColor;
            checkButton();
        }

        private void c22_Click(object sender, EventArgs e)
        {
            color = c22.BackColor;
            checkButton();
        }
    }

}