namespace OP
{
    partial class fridgeOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fridgeOpen));
            back = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = SystemColors.ButtonFace;
            back.Cursor = Cursors.Hand;
            back.FlatAppearance.BorderColor = Color.IndianRed;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Sitka Small", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back.Location = new Point(915, 12);
            back.Name = "back";
            back.Size = new Size(99, 39);
            back.TabIndex = 13;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            back.MouseDown += back_MouseDown;
            back.MouseUp += back_MouseUp;
            // 
            // fridgeOpen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1107, 725);
            Controls.Add(back);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fridgeOpen";
            Text = "Form1";
            MouseDown += fridgeOpen_MouseDown;
            MouseMove += fridgeOpen_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
    }
}