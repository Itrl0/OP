
namespace OP
{
    partial class RgistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RgistrationForm));
            panel1 = new Panel();
            label1 = new Label();
            namefield = new TextBox();
            loginfield = new TextBox();
            surnamefield = new TextBox();
            passwordfield = new TextBox();
            SignUpButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 91);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(549, 91);
            label1.TabIndex = 1;
            label1.Text = "Реєстрація";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // namefield
            // 
            namefield.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            namefield.Location = new Point(165, 122);
            namefield.Multiline = true;
            namefield.Name = "namefield";
            namefield.Size = new Size(265, 45);
            namefield.TabIndex = 1;
            // 
            // loginfield
            // 
            loginfield.Location = new Point(165, 265);
            loginfield.Multiline = true;
            loginfield.Name = "loginfield";
            loginfield.Size = new Size(265, 45);
            loginfield.TabIndex = 2;
            // 
            // surnamefield
            // 
            surnamefield.Location = new Point(165, 191);
            surnamefield.Multiline = true;
            surnamefield.Name = "surnamefield";
            surnamefield.Size = new Size(265, 45);
            surnamefield.TabIndex = 3;
            // 
            // passwordfield
            // 
            passwordfield.Location = new Point(165, 337);
            passwordfield.Multiline = true;
            passwordfield.Name = "passwordfield";
            passwordfield.Size = new Size(265, 45);
            passwordfield.TabIndex = 4;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.ActiveCaptionText;
            SignUpButton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.Transparent;
            SignUpButton.Location = new Point(165, 437);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(265, 53);
            SignUpButton.TabIndex = 5;
            SignUpButton.Text = "Зареєструватись";
            SignUpButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 265);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(111, 337);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // RgistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 546);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(SignUpButton);
            Controls.Add(passwordfield);
            Controls.Add(surnamefield);
            Controls.Add(loginfield);
            Controls.Add(namefield);
            Controls.Add(panel1);
            Name = "RgistrationForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox namefield;
        private TextBox loginfield;
        private TextBox surnamefield;
        private TextBox passwordfield;
        private Button SignUpButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
