namespace OP
{
    partial class Registr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registr));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            email_box = new TextBox();
            password_box = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Exit = new Button();
            buttonRegist = new Button();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(309, 23);
            label1.Name = "label1";
            label1.Size = new Size(229, 44);
            label1.TabIndex = 1;
            label1.Text = "Авторизація";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(190, 229);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // email_box
            // 
            email_box.Location = new Point(286, 151);
            email_box.Name = "email_box";
            email_box.Size = new Size(233, 27);
            email_box.TabIndex = 4;
            // 
            // password_box
            // 
            password_box.Location = new Point(286, 255);
            password_box.Name = "password_box";
            password_box.Size = new Size(233, 27);
            password_box.TabIndex = 5;
            password_box.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(286, 125);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 6;
            label2.Text = "Електронна пошта *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(286, 229);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 7;
            label3.Text = "Пароль *";
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderColor = Color.Silver;
            Exit.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit.Location = new Point(309, 313);
            Exit.Name = "Exit";
            Exit.Size = new Size(194, 35);
            Exit.TabIndex = 8;
            Exit.Text = "Увійти";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // buttonRegist
            // 
            buttonRegist.Cursor = Cursors.Hand;
            buttonRegist.FlatAppearance.BorderColor = Color.Silver;
            buttonRegist.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            buttonRegist.FlatStyle = FlatStyle.Flat;
            buttonRegist.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegist.Location = new Point(309, 377);
            buttonRegist.Name = "buttonRegist";
            buttonRegist.Size = new Size(194, 35);
            buttonRegist.TabIndex = 9;
            buttonRegist.Text = "Зареєструватись";
            buttonRegist.UseVisualStyleBackColor = true;
            buttonRegist.Click += buttonRegist_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ButtonFace;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderColor = Color.Gainsboro;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.Location = new Point(707, 23);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(79, 35);
            closeButton.TabIndex = 11;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            closeButton.MouseDown += closeButton_MouseDown;
            closeButton.MouseUp += closeButton_MouseUp;
            // 
            // Registr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = closeButton;
            ClientSize = new Size(814, 439);
            Controls.Add(closeButton);
            Controls.Add(buttonRegist);
            Controls.Add(Exit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password_box);
            Controls.Add(email_box);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registr";
            Text = "Form1";
            Load += Registr_Load;
            MouseDown += Registr_MouseDown;
            MouseMove += Registr_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox email_box;
        private TextBox password_box;
        private Label label2;
        private Label label3;
        private Button Exit;
        private Button buttonRegist;
        private Button closeButton;
    }
}