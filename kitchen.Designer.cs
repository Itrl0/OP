﻿namespace OP
{
    partial class kitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitchen));
            kitchenn = new PictureBox();
            fridge = new PictureBox();
            recipe = new PictureBox();
            closeButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)kitchenn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fridge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kitchenn
            // 
            kitchenn.Image = (Image)resources.GetObject("kitchenn.Image");
            kitchenn.Location = new Point(-5, -3);
            kitchenn.Name = "kitchenn";
            kitchenn.Size = new Size(728, 445);
            kitchenn.SizeMode = PictureBoxSizeMode.StretchImage;
            kitchenn.TabIndex = 0;
            kitchenn.TabStop = false;
            kitchenn.MouseDown += kitchenn_MouseDown;
            kitchenn.MouseMove += kitchenn_MouseMove;
            // 
            // fridge
            // 
            fridge.Image = (Image)resources.GetObject("fridge.Image");
            fridge.Location = new Point(471, 72);
            fridge.Name = "fridge";
            fridge.Size = new Size(189, 225);
            fridge.SizeMode = PictureBoxSizeMode.StretchImage;
            fridge.TabIndex = 1;
            fridge.TabStop = false;
            fridge.Click += fridge_Click;
            // 
            // recipe
            // 
            recipe.Image = (Image)resources.GetObject("recipe.Image");
            recipe.Location = new Point(226, 259);
            recipe.Name = "recipe";
            recipe.Size = new Size(108, 70);
            recipe.SizeMode = PictureBoxSizeMode.StretchImage;
            recipe.TabIndex = 2;
            recipe.TabStop = false;
            recipe.Click += recipe_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ButtonFace;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderColor = Color.Gainsboro;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.Location = new Point(44, 35);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(99, 39);
            closeButton.TabIndex = 12;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            closeButton.MouseDown += closeButton_MouseDown;
            closeButton.MouseUp += closeButton_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 38);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // kitchen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(722, 423);
            Controls.Add(pictureBox1);
            Controls.Add(closeButton);
            Controls.Add(recipe);
            Controls.Add(fridge);
            Controls.Add(kitchenn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kitchen";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)kitchenn).EndInit();
            ((System.ComponentModel.ISupportInitialize)fridge).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox kitchenn;
        private PictureBox fridge;
        private PictureBox recipe;
        private Button closeButton;
        private PictureBox pictureBox1;
    }
}