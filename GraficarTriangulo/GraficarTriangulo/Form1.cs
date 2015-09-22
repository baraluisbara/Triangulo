using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficarTriangulo
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        Graphics Gr;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLines_Click(object sender, EventArgs e)
        {

            DrawLines();

        }

        private void btnSumX1_Click(object sender, EventArgs e)
        {
            int intX1 = Convert.ToInt32(txt1.Text);
            txt1.Text = (intX1 + 1).ToString();
            DrawLines();
        }        

        private void btnSumY1_Click(object sender, EventArgs e)
        {
            int intY1 = Convert.ToInt32(txt2.Text);
            txt2.Text = (intY1 + 1).ToString();
            DrawLines();
        }       

        private void btnRestX1_Click(object sender, EventArgs e)
        {
            int intX1 = Convert.ToInt32(txt1.Text);
            txt1.Text = (intX1 - 1).ToString();
            DrawLines();
        }        

        private void btnRestY1_Click(object sender, EventArgs e)
        {
            int intY1 = Convert.ToInt32(txt2.Text);
            txt2.Text = (intY1 - 1).ToString();
            DrawLines();
        }

        private void btnSumX2_Click(object sender, EventArgs e)
        {
            int intX1 = Convert.ToInt32(txt3.Text);
            txt3.Text = (intX1 + 1).ToString();
            DrawLines();
        }

        private void btnRestX2_Click(object sender, EventArgs e)
        {
            int intX1 = Convert.ToInt32(txt3.Text);
            txt3.Text = (intX1 - 1).ToString();
            DrawLines();
        }

        private void btnSumY2_Click(object sender, EventArgs e)
        {
            int intY1 = Convert.ToInt32(txt4.Text);
            txt4.Text = (intY1 + 1).ToString();
            DrawLines();
        }

        private void btnRestY2_Click(object sender, EventArgs e)
        {
            int intY1 = Convert.ToInt32(txt4.Text);
            txt4.Text = (intY1 - 1).ToString();
            DrawLines();
        }

        private void btnSumX3_Click(object sender, EventArgs e)
        {
            int intX1 = Convert.ToInt32(txt5.Text);
            txt5.Text = (intX1 + 1).ToString();
            DrawLines();
        }

        private void btnRestX3_Click(object sender, EventArgs e)
        {
            int intX1 = Convert.ToInt32(txt5.Text);
            txt5.Text = (intX1 - 1).ToString();
            DrawLines();
        }

        private void btnSumY3_Click(object sender, EventArgs e)
        {
            int intY1 = Convert.ToInt32(txt6.Text);
            txt6.Text = (intY1 + 1).ToString();
            DrawLines();
        }

        private void btnRestY3_Click(object sender, EventArgs e)
        {
            int intY1 = Convert.ToInt32(txt6.Text);
            txt6.Text = (intY1 - 1).ToString();
            DrawLines();
        }

        public void DrawLines()
        {
            int A1, A2, B1, B2, C1, C2;
            try
            {
                A1 = Convert.ToInt32(txt1.Text);
                A2 = Convert.ToInt32(txt2.Text);
                B1 = Convert.ToInt32(txt3.Text);
                B2 = Convert.ToInt32(txt4.Text);
                C1 = Convert.ToInt32(txt5.Text);
                C2 = Convert.ToInt32(txt6.Text);

                if (A1 < 1 && A2 < 1 && B1 < 1 && B1 < 2 && C1 < 1 && C2 < 1)
                {
                    MessageBox.Show("Datos negativos, revise sus coordenadas");
                }
                else
                {
                    Gr = pictureBox1.CreateGraphics();
                    Gr.Clear(Color.Silver);

                    // A - B
                    Gr.DrawLine(Pens.Black, A1, pictureBox1.Height - A2, B1, pictureBox1.Height - B2);
                    // B - C
                    Gr.DrawLine(Pens.Blue, B1, pictureBox1.Height - B2, C1, pictureBox1.Height - C2);
                    // C - A
                    Gr.DrawLine(Pens.Green, C1, pictureBox1.Height - C2, A1, pictureBox1.Height - A2);
                }                
            }
            catch
            {
                MessageBox.Show("Datos invalidos, revise sus coordenadas");
            }
            
        }
    }
}
