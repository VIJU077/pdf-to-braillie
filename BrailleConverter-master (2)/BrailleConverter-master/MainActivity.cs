using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SDC_Application
{
    public partial class MainActivity : MetroForm
    {
        Point lastPoint; //Point based Object used to move the static form 
        public MainActivity()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ------------ Code to Move the Form Elements on Mouse Click ------------------------
        private void Title_Label_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Title_Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Logo_Label_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Logo_Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Pdf_Logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Pdf_Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Text_Logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Pdf_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Pdf_Button_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Text_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        // ---------------- Code to Move to Another Form Activity ------------------
        private void Pdf_Logo_Click(object sender, EventArgs e)
        {
            this.Hide();
            PdfForm pdf = new PdfForm();
            pdf.ShowDialog();
            this.Close();
        }

        private void Pdf_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PdfForm pdf = new PdfForm();
            pdf.ShowDialog();
            this.Close();
        }

        private void Text_Logo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextForm tf = new TextForm();
            tf.ShowDialog();
            this.Close();
        }

        private void Text_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextForm tf = new TextForm();
            tf.ShowDialog();
            this.Close();
        }
    }
}
