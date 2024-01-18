namespace ImageClassifier
{
    partial class Form1
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
            select_image = new Button();
            evaluate = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // select_image
            // 
            select_image.BackColor = SystemColors.ActiveCaptionText;
            select_image.FlatStyle = FlatStyle.System;
            select_image.Location = new Point(97, 76);
            select_image.Name = "select_image";
            select_image.Size = new Size(181, 34);
            select_image.TabIndex = 0;
            select_image.Text = "Select an Image";
            select_image.TextAlign = ContentAlignment.MiddleLeft;
            select_image.UseVisualStyleBackColor = false;
            select_image.Click += button1_Click;
            // 
            // evaluate
            // 
            evaluate.Location = new Point(97, 192);
            evaluate.Name = "evaluate";
            evaluate.Size = new Size(181, 34);
            evaluate.TabIndex = 1;
            evaluate.Text = "Classify the Image";
            evaluate.TextAlign = ContentAlignment.MiddleLeft;
            evaluate.UseVisualStyleBackColor = true;
            evaluate.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(484, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(484, 457);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1028, 566);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(evaluate);
            Controls.Add(select_image);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button select_image;
        private Button evaluate;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}
