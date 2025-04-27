namespace OP
{
    partial class recipe9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recipe9));
            back = new Button();
            next_Page = new Button();
            label3 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button2 = new Button();
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
            back.ForeColor = Color.Black;
            back.Location = new Point(12, 541);
            back.Name = "back";
            back.Size = new Size(99, 39);
            back.TabIndex = 26;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // next_Page
            // 
            next_Page.BackColor = SystemColors.ButtonFace;
            next_Page.Cursor = Cursors.Hand;
            next_Page.FlatAppearance.BorderColor = Color.IndianRed;
            next_Page.FlatStyle = FlatStyle.Flat;
            next_Page.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            next_Page.ForeColor = Color.Black;
            next_Page.Location = new Point(417, 541);
            next_Page.Name = "next_Page";
            next_Page.Size = new Size(99, 39);
            next_Page.TabIndex = 27;
            next_Page.Text = "Далі";
            next_Page.UseVisualStyleBackColor = false;
            next_Page.Click += next_Page_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(139, 275);
            label3.Name = "label3";
            label3.Size = new Size(176, 29);
            label3.TabIndex = 67;
            label3.Text = "Приготування:";
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Control;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox2.ForeColor = SystemColors.MenuText;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 22;
            listBox2.Items.AddRange(new object[] { "1)Наріжте куряче м’ясо невеликими шматочками.", "2)Обсмажте курку на олії до золотистого кольору.", "3)Додайте нарізану моркву та цибулю, готуйте ще 5 хвилин.", "4)Всипте промитий рис і залийте гарячою водою ", "(щоб вода покривала рис на 2 пальці).", "5)Посоліть, додайте спеції і не перемішуючи, варіть на ", "малому вогні під кришкою.", "6)Коли рис увібрав воду, вимкніть плиту і дайте плову ", "настоятися 10 хвилин." });
            listBox2.Location = new Point(0, 307);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(516, 220);
            listBox2.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(319, 43);
            label2.Name = "label2";
            label2.Size = new Size(150, 29);
            label2.TabIndex = 65;
            label2.Text = "Інградієнти:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 33);
            label1.TabIndex = 64;
            label1.Text = "Назва: Плов з куркою";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            listBox1.ForeColor = SystemColors.MenuText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Items.AddRange(new object[] { "Рис", "М'ясо – 1 шматок", "Морква – 1 шт.", "Цибуля – 1 шт.", "Спеції" });
            listBox1.Location = new Point(322, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 182);
            listBox1.TabIndex = 62;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.IndianRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(282, 541);
            button3.Name = "button3";
            button3.Size = new Size(99, 39);
            button3.TabIndex = 69;
            button3.Text = "Закрити";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(149, 541);
            button2.Name = "button2";
            button2.Size = new Size(99, 39);
            button2.TabIndex = 68;
            button2.Text = "Меню";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cook
            // 
            cook.Location = new Point(321, 278);
            cook.Name = "cook";
            cook.Size = new Size(105, 29);
            cook.TabIndex = 103;
            cook.Text = "приготувати";
            cook.UseVisualStyleBackColor = true;
            // 
            // recipe9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(next_Page);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.None;
            Name = "recipe9";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button back;
        private Button next_Page;
        private Label label3;
        private ListBox listBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button2;
        private Button cook;
    }
}