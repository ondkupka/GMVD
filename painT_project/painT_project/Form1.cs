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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           if (panel1.Width >= 1530)
            {
                timer1.Stop();
                this.Hide();
                form2.Show();
                
            }
           else
            {
                panel1.Width += 150;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
