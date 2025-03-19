namespace SDC_Application
{
    partial class MainActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainActivity));
            this.Title_Label = new MetroFramework.Drawing.Html.HtmlLabel();
            this.Logo_Label = new MetroFramework.Drawing.Html.HtmlLabel();
            this.Pdf_Logo = new System.Windows.Forms.PictureBox();
            this.Pdf_Button = new MetroFramework.Controls.MetroButton();
            this.Text_Logo = new System.Windows.Forms.PictureBox();
            this.Text_Button = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pdf_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Label.AutoScroll = true;
            this.Title_Label.AutoScrollMinSize = new System.Drawing.Size(134, 27);
            this.Title_Label.AutoSize = false;
            this.Title_Label.BackColor = System.Drawing.SystemColors.Window;
            this.Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Title_Label.Location = new System.Drawing.Point(23, 23);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Title_Label.Size = new System.Drawing.Size(137, 35);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "BRAILLE WORKS";
            this.Title_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_Label_MouseDown);
            this.Title_Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_Label_MouseMove);
            // 
            // Logo_Label
            // 
            this.Logo_Label.AutoScroll = true;
            this.Logo_Label.AutoScrollMinSize = new System.Drawing.Size(214, 43);
            this.Logo_Label.AutoSize = false;
            this.Logo_Label.BackColor = System.Drawing.SystemColors.Window;
            this.Logo_Label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo_Label.Location = new System.Drawing.Point(263, 89);
            this.Logo_Label.Name = "Logo_Label";
            this.Logo_Label.Size = new System.Drawing.Size(232, 53);
            this.Logo_Label.TabIndex = 1;
            this.Logo_Label.Text = "BRAILLE WORKS";
            this.Logo_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_Label_MouseDown);
            this.Logo_Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logo_Label_MouseMove);
            // 
            // Pdf_Logo
            // 
            this.Pdf_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pdf_Logo.Image")));
            this.Pdf_Logo.Location = new System.Drawing.Point(414, 167);
            this.Pdf_Logo.Name = "Pdf_Logo";
            this.Pdf_Logo.Size = new System.Drawing.Size(325, 196);
            this.Pdf_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pdf_Logo.TabIndex = 3;
            this.Pdf_Logo.TabStop = false;
            this.Pdf_Logo.Click += new System.EventHandler(this.Pdf_Logo_Click);
            this.Pdf_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pdf_Logo_MouseDown);
            this.Pdf_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pdf_Logo_MouseMove);
            // 
            // Pdf_Button
            // 
            this.Pdf_Button.AutoSize = true;
            this.Pdf_Button.BackColor = System.Drawing.Color.White;
            this.Pdf_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pdf_Button.Location = new System.Drawing.Point(523, 369);
            this.Pdf_Button.Name = "Pdf_Button";
            this.Pdf_Button.Size = new System.Drawing.Size(103, 35);
            this.Pdf_Button.TabIndex = 4;
            this.Pdf_Button.Text = "PDF TO BRAILLE";
            this.Pdf_Button.UseSelectable = true;
            this.Pdf_Button.Click += new System.EventHandler(this.Pdf_Button_Click);
            this.Pdf_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pdf_Button_MouseDown);
            this.Pdf_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pdf_Button_MouseMove);
            // 
            // Text_Logo
            // 
            this.Text_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Text_Logo.Image")));
            this.Text_Logo.Location = new System.Drawing.Point(88, 167);
            this.Text_Logo.Name = "Text_Logo";
            this.Text_Logo.Size = new System.Drawing.Size(215, 196);
            this.Text_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Text_Logo.TabIndex = 5;
            this.Text_Logo.TabStop = false;
            this.Text_Logo.Click += new System.EventHandler(this.Text_Logo_Click);
            this.Text_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Text_Logo_MouseDown);
            this.Text_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Text_Logo_MouseMove);
            // 
            // Text_Button
            // 
            this.Text_Button.AutoSize = true;
            this.Text_Button.BackColor = System.Drawing.Color.White;
            this.Text_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Text_Button.Location = new System.Drawing.Point(133, 369);
            this.Text_Button.Name = "Text_Button";
            this.Text_Button.Size = new System.Drawing.Size(110, 35);
            this.Text_Button.TabIndex = 6;
            this.Text_Button.Text = "TEXT TO BRAILLE";
            this.Text_Button.UseSelectable = true;
            this.Text_Button.Click += new System.EventHandler(this.Text_Button_Click);
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text_Button);
            this.Controls.Add(this.Text_Logo);
            this.Controls.Add(this.Pdf_Button);
            this.Controls.Add(this.Pdf_Logo);
            this.Controls.Add(this.Logo_Label);
            this.Controls.Add(this.Title_Label);
            this.Name = "MainActivity";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_Label_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logo_Label_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Pdf_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel Title_Label;
        private MetroFramework.Drawing.Html.HtmlLabel Logo_Label;
        private System.Windows.Forms.PictureBox Pdf_Logo;
        private MetroFramework.Controls.MetroButton Pdf_Button;
        private System.Windows.Forms.PictureBox Text_Logo;
        private MetroFramework.Controls.MetroButton Text_Button;
    }
}