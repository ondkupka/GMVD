using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace painT_project
{
    internal class ButtonHandler
    {
        public Color color;
        public bool pcXsc = true;

        public ButtonHandler()
        {

        }

        public void ColorButton_Click(object sender, EventArgs e, Button pc_btn, Button sc_btn, Panel crrnt_clr)
        {
            Button button = (Button)sender;
            color = button.BackColor;
            CheckButton(pc_btn, sc_btn, crrnt_clr);
        }

        public void CheckButton(Button pc_btn, Button sc_btn, Panel crrnt_clr)
        {
            crrnt_clr.BackColor = color;
            if (pcXsc == true)
                pc_btn.BackColor = color;
            else
                sc_btn.BackColor = color;
        }

        public void Pc_btn_Click(Button pc_btn, Button sc_btn, Panel crrnt_clr)
        {
            pcXsc = true;
            CheckMain(pc_btn, sc_btn, crrnt_clr);
        }

        public void Sc_btn_Click(Button pc_btn, Button sc_btn, Panel crrnt_clr)
        {
            pcXsc = false;
            CheckMain(pc_btn, sc_btn, crrnt_clr);
        }

        public void CheckMain(Button pc_btn, Button sc_btn, Panel crrnt_clr)
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
    }
}
