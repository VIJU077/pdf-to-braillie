namespace SDC_Application
{
    partial class PdfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pdf2_Logo = new MetroFramework.Drawing.Html.HtmlLabel();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.Clear_Button = new MetroFramework.Controls.MetroButton();
            this.Menu_Button = new MetroFramework.Controls.MetroButton();
            this.Open_Button = new MetroFramework.Controls.MetroButton();
            this.SavePDF = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Pdf2_Logo
            // 
            this.Pdf2_Logo.AutoScroll = true;
            this.Pdf2_Logo.AutoScrollMinSize = new System.Drawing.Size(119, 25);
            this.Pdf2_Logo.AutoSize = false;
            this.Pdf2_Logo.BackColor = System.Drawing.SystemColors.Window;
            this.Pdf2_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pdf2_Logo.Location = new System.Drawing.Point(23, 21);
            this.Pdf2_Logo.Name = "Pdf2_Logo";
            this.Pdf2_Logo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pdf2_Logo.Size = new System.Drawing.Size(136, 33);
            this.Pdf2_Logo.TabIndex = 0;
            this.Pdf2_Logo.Text = "PDF TO BRAILLE";
            this.Pdf2_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pdf2_Logo_MouseDown);
            this.Pdf2_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pdf2_Logo_MouseMove);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(23, 63);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(754, 278);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "";
            this.TextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            this.TextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseMove);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(258, 376);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(112, 39);
            this.Clear_Button.TabIndex = 2;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseSelectable = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            this.Clear_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clear_Button_MouseDown);
            this.Clear_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Clear_Button_MouseMove);
            // 
            // Menu_Button
            // 
            this.Menu_Button.Location = new System.Drawing.Point(615, 376);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(112, 39);
            this.Menu_Button.TabIndex = 3;
            this.Menu_Button.Text = "Go to Main Menu";
            this.Menu_Button.UseSelectable = true;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            this.Menu_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_Button_MouseDown);
            this.Menu_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_Button_MouseMove);
            // 
            // Open_Button
            // 
            this.Open_Button.Location = new System.Drawing.Point(47, 376);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(112, 39);
            this.Open_Button.TabIndex = 4;
            this.Open_Button.Text = "Open PDF";
            this.Open_Button.UseSelectable = true;
            this.Open_Button.Click += new System.EventHandler(this.Open_Button_Click);
            this.Open_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Open_Button_MouseDown);
            this.Open_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Open_Button_MouseMove);
            // 
            // SavePDF
            // 
            this.SavePDF.Location = new System.Drawing.Point(456, 376);
            this.SavePDF.Name = "SavePDF";
            this.SavePDF.Size = new System.Drawing.Size(103, 39);
            this.SavePDF.TabIndex = 5;
            this.SavePDF.Text = "Save Braille";
            this.SavePDF.UseSelectable = true;
            this.SavePDF.Click += new System.EventHandler(this.SavePDF_Click);
            // 
            // PdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SavePDF);
            this.Controls.Add(this.Open_Button);
            this.Controls.Add(this.Menu_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Pdf2_Logo);
            this.Name = "PdfForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel Pdf2_Logo;
        private System.Windows.Forms.RichTextBox TextBox;
        private MetroFramework.Controls.MetroButton Clear_Button;
        private MetroFramework.Controls.MetroButton Menu_Button;
        private MetroFramework.Controls.MetroButton Open_Button;
        private MetroFramework.Controls.MetroButton SavePDF;
    }
}