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
    public partial class TextForm : MetroForm
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void TextForm_Load(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        // ------------ Code to Move UI Design -------------
        private void Textlogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void input_Textbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void TexttoBraille_Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void MainMenu_Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void OutputTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void OutputTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Textlogo_MouseMove(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void input_Textbox_MouseMove(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TexttoBraille_Button_MouseMove(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void MainMenu_Button_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        // -------- Code to Convert the Text to Braille ---------------
        private void TexttoBraille_Button_MouseClick(object sender, MouseEventArgs e)
        {
            String Text = input_Textbox.Text.ToString();
            ConvertTextToBraille cttb = new ConvertTextToBraille();
            OutputTextBox.Text = cttb.Display(Text);
           // input_Textbox.Text = "";
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainActivity ma = new MainActivity();
            ma.ShowDialog();
            this.Close();
        }

        private void BrailleAscii_Click(object sender, EventArgs e)
        {
            String BText = input_Textbox.Text.ToString();
            ConvertTextToAscii ctta = new ConvertTextToAscii();
            OutputTextBox.Text = ctta.DisplayAscii(BText);
        }
    }
}
