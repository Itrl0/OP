namespace OP
{
    partial class Registr2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registr2));
            closeButton2 = new Button();
            buttonRegist = new Button();
            Exit = new Button();
            label3 = new Label();
            label2 = new Label();
            password_box = new TextBox();
            name_box = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            email_box = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // closeButton2
            // 
            closeButton2.BackColor = SystemColors.ButtonFace;
            closeButton2.Cursor = Cursors.Hand;
            closeButton2.FlatAppearance.BorderColor = Color.Gainsboro;
            closeButton2.FlatStyle = FlatStyle.Flat;
            closeButton2.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton2.Location = new Point(706, 22);
            closeButton2.Name = "closeButton2";
            closeButton2.Size = new Size(82, 35);
            closeButton2.TabIndex = 21;
            closeButton2.Text = "Закрити";
            closeButton2.UseVisualStyleBackColor = false;
            closeButton2.Click += closeButton2_Click;
          
            // 
            // buttonRegist
            // 
            buttonRegist.BackColor = Color.White;
            buttonRegist.Cursor = Cursors.Hand;
            buttonRegist.FlatAppearance.BorderColor = Color.Silver;
            buttonRegist.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            buttonRegist.FlatStyle = FlatStyle.Flat;
            buttonRegist.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegist.Location = new Point(307, 379);
            buttonRegist.Name = "buttonRegist";
            buttonRegist.Size = new Size(196, 35);
            buttonRegist.TabIndex = 20;
            buttonRegist.Text = "Авторизація";
            buttonRegist.UseVisualStyleBackColor = false;
            buttonRegist.Click += buttonRegist_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.White;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderColor = Color.Silver;
            Exit.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit.Location = new Point(307, 318);
            Exit.Name = "Exit";
            Exit.Size = new Size(196, 35);
            Exit.TabIndex = 19;
            Exit.Text = "Увійти";
            Exit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(282, 237);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 18;
            label3.Text = "Пароль *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(282, 177);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 17;
            label2.Text = "Ім'я *";
            // 
            // password_box
            // 
            password_box.Location = new Point(282, 263);
            password_box.Name = "password_box";
            password_box.Size = new Size(235, 27);
            password_box.TabIndex = 16;
            password_box.UseSystemPasswordChar = true;
            // 
            // name_box
            // 
            name_box.Location = new Point(282, 206);
            name_box.Name = "name_box";
            name_box.Size = new Size(235, 27);
            name_box.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(187, 239);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(304, 22);
            label1.Name = "label1";
            label1.Size = new Size(199, 44);
            label1.TabIndex = 12;
            label1.Text = "Реєстрація";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(282, 110);
            label4.Name = "label4";
            label4.Size = new Size(182, 23);
            label4.TabIndex = 24;
            label4.Text = "Електронна пошта *";
            // 
            // email_box
            // 
            email_box.Location = new Point(282, 139);
            email_box.Name = "email_box";
            email_box.Size = new Size(235, 27);
            email_box.TabIndex = 23;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(187, 105);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // Registr2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(815, 438);
            Controls.Add(label4);
            Controls.Add(email_box);
            Controls.Add(pictureBox3);
            Controls.Add(closeButton2);
            Controls.Add(buttonRegist);
            Controls.Add(Exit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password_box);
            Controls.Add(name_box);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registr2";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton2;
        private Button buttonRegist;
        private Button Exit;
        private Label label3;
        private Label label2;
        private TextBox password_box;
        private TextBox name_box;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private TextBox email_box;
        private PictureBox pictureBox3;
    }
}