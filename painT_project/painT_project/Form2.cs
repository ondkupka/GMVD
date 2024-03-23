using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace painT_project
{
    public partial class Form2 : Form 
    {
        private PrintDocument printDocument1 = new PrintDocument();
        ButtonHandler buttonHandler = new ButtonHandler();
        Point lastPoint;
        Pen myPen = new Pen(Color.Black, 1);
        Pen myErasorPen = new Pen(Color.White, 1);
        Random rnd = new Random(); //random na spray
        public Color color { get; private set; }
        Bitmap myBitmap;
        int value = 1;
        bool isMoving = false;
        char t = '0';
        char f = '1';
        Graphics graphics;
        int x;
        int y;
        int firstX;
        int firstY;
        int lastX;
        int lastY;
        
        public Form2()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height); //vytvoření bitmapy 
            pictureBox1.Image = myBitmap;
            graphics = Graphics.FromImage(myBitmap);
        }
        
        private void clrpick_btn_Click(object sender, EventArgs e) //tlačítko pro vlastní tvorbu barvy
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

        private void pc_btn_Click(object sender, EventArgs e) //udělal jsem si speciální classu kvuli barvam, abych neměl hnusnej kod, coz stejne mam :DD
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

        private void button2_Click(object sender, EventArgs e) //vypínací tlačítko
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
            button2.Location = new Point(width-32,4); //Aby tlačítko bylo vpravo i po maximalizování, s dalšími se mi teď ve 2:30 ráno moc nechce dělat, ale možná je ještě dám přímo doprostřed
            pictureBox1.Width = panel1.Width;
            pictureBox1.Height = height;
            graphics.FillRectangle(Brushes.White, 0, 0, myBitmap.Width, myBitmap.Height); //Hned na začátkou se "vybarví" bíle, aby při ukládání bylo bílé pozadí  
            btn_clear.BackColor = ColorTranslator.FromHtml("#5498fd");
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMoving = true;
            firstX = e.Location.X;  //zaznamenám první klik myší
            firstY = e.Location.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving && e.Button == MouseButtons.Left)
            {
                color = crrnt_clr.BackColor;
                myPen.Width = value;
                myErasorPen.Width = value;
                color = crrnt_clr.BackColor;
                myPen.Color = color;    
                switch (t)
                {
                    case '1': // dle jednotlivých charů se zvolí varianta a ta se provede

                        Brush myBrush = new SolidBrush(color);
                        graphics.DrawLine(myPen, lastPoint, e.Location);
                        graphics.FillEllipse(myBrush, e.X - myPen.Width / 2, e.Y - myPen.Width / 2, myPen.Width, myPen.Width);
                        lastPoint = e.Location;
                        pictureBox1.Invalidate();
                        break;
                    case '2':
                        Brush myCan = new SolidBrush(color);
                        for (int i = 0; i < value; i++)
                        {
                            int x = e.X + rnd.Next(-value, value);                                                  
                            int y = e.Y + rnd.Next(-value, value);
                            graphics.FillEllipse(myCan, x, y, 3, 3);
                        }
                        lastPoint = e.Location;
                        pictureBox1.Invalidate();
                        break;
                    case '3':
                        Brush myErasor = new SolidBrush(Color.White);
                        graphics.DrawLine(myErasorPen, lastPoint, e.Location);
                        graphics.FillEllipse(myErasor, e.X - myPen.Width / 2, e.Y - myPen.Width / 2, myPen.Width, myPen.Width);
                        lastPoint = e.Location;
                        pictureBox1.Invalidate();
                        break;
                }
                x = e.Location.X; 
                y = e.Location.Y; 
                lastX = e.Location.X - firstX; 
                lastY = e.Location.Y - firstY; 

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Brush myBrush = new SolidBrush(color);
            isMoving = false;
            lastX = x - firstX; //zaznamenám poslední pozici myši
            lastY = y - firstY;
            if (t == '4' && f == '1') // dle jednotlivých charů se zvolí varianta a ta se provede
            {
                graphics.DrawRectangle(myPen, firstX, firstY, lastX, lastY);            
            }
            else if (t == '5' && f == '1')
            {
                graphics.DrawEllipse(myPen, firstX, firstY, lastX, lastY);
            }
            else if (t == '5' && f == '0')
            {
                graphics.FillEllipse(myBrush, firstX, firstY, lastX, lastY);
            }
            else if (t == '4' && f == '0')
            {
                graphics.FillRectangle(myBrush, firstX, firstY, lastX, lastY);
            }
            pictureBox1.Invalidate();
        }
        private void btn_pencil_Click(object sender, EventArgs e)
        {
            t = '1';
            btn_pencil.FlatAppearance.BorderSize = 1;
            btn_can.FlatAppearance.BorderSize = 0;
            btn_rectangle.FlatAppearance.BorderSize = 0;
            btn_erasor.FlatAppearance.BorderSize = 0;
            btn_elps.FlatAppearance.BorderSize = 0;
        }
        private void btn_erasor_Click(object sender, EventArgs e)
        {
            t = '3';
            btn_erasor.FlatAppearance.BorderSize = 1;
            btn_pencil.FlatAppearance.BorderSize = 0;
            btn_rectangle.FlatAppearance.BorderSize = 0;
            btn_can.FlatAppearance.BorderSize = 0;
            btn_elps.FlatAppearance.BorderSize = 0;
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            t = '4';
            btn_rectangle.FlatAppearance.BorderSize = 1;
            btn_erasor.FlatAppearance.BorderSize = 0;
            btn_pencil.FlatAppearance.BorderSize = 0;
            btn_can.FlatAppearance.BorderSize = 0;
            btn_elps.FlatAppearance.BorderSize = 0;
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            t = '2';
            btn_can.FlatAppearance.BorderSize = 1;
            btn_rectangle.FlatAppearance.BorderSize = 0;
            btn_erasor.FlatAppearance.BorderSize = 0;
            btn_pencil.FlatAppearance.BorderSize = 0;
            btn_elps.FlatAppearance.BorderSize = 0;
        }

        private void btn_save_Click(object sender, EventArgs e) //uložení bitmpay jako obrázku, Stack Overflow pomohlo 
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JPG Image|*.jpg";
                sfd.Title = "Uložit obrázek";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    myBitmap.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void btn_elps_Click(object sender, EventArgs e)
        {
            t = '5';
            btn_elps.FlatAppearance.BorderSize = 1;
            btn_can.FlatAppearance.BorderSize = 0;
            btn_rectangle.FlatAppearance.BorderSize = 0;
            btn_erasor.FlatAppearance.BorderSize = 0;
            btn_pencil.FlatAppearance.BorderSize = 0;
        }



        private void btn_printer_Click(object sender, EventArgs e) //Ještě jsem nezkoušel, takže si nemyslím, že to bude funkčni 
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(myBitmap, 0, 0);
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                f = '0'; // f = fill
            }
            else
            {
                f = '1';
            }
        }
    }
}
