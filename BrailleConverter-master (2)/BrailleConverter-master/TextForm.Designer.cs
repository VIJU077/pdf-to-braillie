namespace SDC_Application
{
    partial class TextForm
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
            this.Textlogo = new MetroFramework.Drawing.Html.HtmlLabel();
            this.input_Textbox = new System.Windows.Forms.RichTextBox();
            this.TexttoBraille_Button = new MetroFramework.Controls.MetroButton();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.MainMenu_Button = new MetroFramework.Controls.MetroButton();
            this.BrailleAscii = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Textlogo
            // 
            this.Textlogo.AutoScroll = true;
            this.Textlogo.AutoScrollMinSize = new System.Drawing.Size(102, 27);
            this.Textlogo.AutoSize = false;
            this.Textlogo.BackColor = System.Drawing.SystemColors.Window;
            this.Textlogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textlogo.Location = new System.Drawing.Point(23, 23);
            this.Textlogo.Name = "Textlogo";
            this.Textlogo.Size = new System.Drawing.Size(136, 38);
            this.Textlogo.TabIndex = 0;
            this.Textlogo.Text = "Text to Braille";
            this.Textlogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Textlogo_MouseDown);
            this.Textlogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Textlogo_MouseMove);
            // 
            // input_Textbox
            // 
            this.input_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Textbox.Location = new System.Drawing.Point(24, 68);
            this.input_Textbox.Name = "input_Textbox";
            this.input_Textbox.Size = new System.Drawing.Size(730, 118);
            this.input_Textbox.TabIndex = 1;
            this.input_Textbox.Text = "";
            this.input_Textbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_Textbox_MouseDown);
            this.input_Textbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.input_Textbox_MouseMove);
            // 
            // TexttoBraille_Button
            // 
            this.TexttoBraille_Button.Location = new System.Drawing.Point(129, 202);
            this.TexttoBraille_Button.Name = "TexttoBraille_Button";
            this.TexttoBraille_Button.Size = new System.Drawing.Size(125, 40);
            this.TexttoBraille_Button.TabIndex = 2;
            this.TexttoBraille_Button.Text = "Convert Text to Braille";
            this.TexttoBraille_Button.UseSelectable = true;
            this.TexttoBraille_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TexttoBraille_Button_MouseClick);
            this.TexttoBraille_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TexttoBraille_Button_MouseDown);
            this.TexttoBraille_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TexttoBraille_Button_MouseMove);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.Location = new System.Drawing.Point(24, 248);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(730, 139);
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.TabStop = false;
            this.OutputTextBox.Text = "";
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            this.OutputTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OutputTextBox_MouseDown);
            this.OutputTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OutputTextBox_MouseMove);
            // 
            // MainMenu_Button
            // 
            this.MainMenu_Button.Location = new System.Drawing.Point(650, 393);
            this.MainMenu_Button.Name = "MainMenu_Button";
            this.MainMenu_Button.Size = new System.Drawing.Size(104, 34);
            this.MainMenu_Button.TabIndex = 4;
            this.MainMenu_Button.Text = "Go to Main Menu";
            this.MainMenu_Button.UseSelectable = true;
            this.MainMenu_Button.Click += new System.EventHandler(this.MainMenu_Button_Click);
            this.MainMenu_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_Button_MouseDown);
            this.MainMenu_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_Button_MouseMove);
            // 
            // BrailleAscii
            // 
            this.BrailleAscii.Location = new System.Drawing.Point(486, 202);
            this.BrailleAscii.Name = "BrailleAscii";
            this.BrailleAscii.Size = new System.Drawing.Size(184, 40);
            this.BrailleAscii.TabIndex = 5;
            this.BrailleAscii.Text = "Convert Text To Braille Ascii";
            this.BrailleAscii.UseSelectable = true;
            this.BrailleAscii.Click += new System.EventHandler(this.BrailleAscii_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrailleAscii);
            this.Controls.Add(this.MainMenu_Button);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.TexttoBraille_Button);
            this.Controls.Add(this.input_Textbox);
            this.Controls.Add(this.Textlogo);
            this.Name = "TextForm";
            this.Text = "TextForm";
            this.Load += new System.EventHandler(this.TextForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel Textlogo;
        private System.Windows.Forms.RichTextBox input_Textbox;
        private MetroFramework.Controls.MetroButton TexttoBraille_Button;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private MetroFramework.Controls.MetroButton MainMenu_Button;
        private MetroFramework.Controls.MetroButton BrailleAscii;
    }
}