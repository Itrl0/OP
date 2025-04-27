namespace OP
{
    partial class recipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recipe));
            back = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            cook = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = SystemColors.ButtonFace;
            back.Cursor = Cursors.Hand;
            back.FlatAppearance.BorderColor = Color.IndianRed;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back.Location = new Point(12, 541);
            back.Name = "back";
            back.Size = new Size(99, 39);
            back.TabIndex = 14;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(415, 541);
            button1.Name = "button1";
            button1.Size = new Size(99, 39);
            button1.TabIndex = 16;
            button1.Text = "Далі";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.WhiteSmoke;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            listBox1.ForeColor = SystemColors.MenuText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Items.AddRange(new object[] { "Буряк – 2 шт.", "Капуста – 1 качан", "Картопля – 3 шт.", "Морква – 1–2 шт.", "Цибуля – 1 шт.", "Томатна паста", "М’ясо – 1 шматок " });
            listBox1.Location = new Point(318, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 182);
            listBox1.TabIndex = 17;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 33);
            label1.TabIndex = 20;
            label1.Text = "Назва: Борщ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(318, 43);
            label2.Name = "label2";
            label2.Size = new Size(150, 29);
            label2.TabIndex = 21;
            label2.Text = "Інградієнти:";
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.WhiteSmoke;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox2.ForeColor = SystemColors.MenuText;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 22;
            listBox2.Items.AddRange(new object[] { "1)Зваріть м’ясо до готовності , вийміть і поріжте шматочками.", "2)У бульйон додайте нарізану картоплю.", "3)Окремо натріть буряк, моркву,  цибулю, обсмажте ", "з томатною пастою 5–7 хв.", "4)Коли картопля майже зварена, додайте обсмажені овочі", " та нарізану капусту.", "5)Варіть ще 10–15 хвилин, додайте спеції, зелень та м’ясо.", "6)Дайте настоятись 20 хвилин " });
            listBox2.Location = new Point(12, 333);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(530, 198);
            listBox2.TabIndex = 22;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(159, 275);
            label3.Name = "label3";
            label3.Size = new Size(176, 29);
            label3.TabIndex = 23;
            label3.Text = "Приготування:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(144, 541);
            button2.Name = "button2";
            button2.Size = new Size(99, 39);
            button2.TabIndex = 24;
            button2.Text = "Меню";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.IndianRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(277, 541);
            button3.Name = "button3";
            button3.Size = new Size(99, 39);
            button3.TabIndex = 25;
            button3.Text = "Закрити";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cook
            // 
            cook.Location = new Point(391, 278);
            cook.Name = "cook";
            cook.Size = new Size(123, 29);
            cook.TabIndex = 26;
            cook.Text = "Приготувати";
            cook.UseVisualStyleBackColor = true;
            cook.Click += cook_Click;
            // 
            // recipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(539, 615);
            Controls.Add(cook);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.None;
            Name = "recipe";
            Text = "Form1";
            MouseDown += recipe_MouseDown;
            MouseMove += recipe_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button cook;
    }
}