namespace GUI_GYMTRACKER
{
    partial class HomeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDashboard));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 332);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Letter Gothic Std", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(426, 270);
            label1.Name = "label1";
            label1.Size = new Size(265, 87);
            label1.TabIndex = 3;
            label1.Text = "CHECK YOUR\r\nBMI NOW\r\nAVAILABLE FOR FREE\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Letter Gothic Std", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(92, 393);
            button1.Name = "button1";
            button1.Size = new Size(306, 53);
            button1.TabIndex = 4;
            button1.Text = "TRY NOW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(803, 477);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeDashboard";
            Text = "HomeDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}