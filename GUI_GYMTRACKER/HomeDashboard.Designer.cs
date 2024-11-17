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
            homelabel = new Label();
            SuspendLayout();
            // 
            // homelabel
            // 
            homelabel.AutoSize = true;
            homelabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homelabel.ForeColor = SystemColors.ButtonHighlight;
            homelabel.Location = new Point(308, 256);
            homelabel.Name = "homelabel";
            homelabel.Size = new Size(83, 32);
            homelabel.TabIndex = 1;
            homelabel.Text = "HOME";
            // 
            // HomeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 477);
            Controls.Add(homelabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeDashboard";
            Text = "HomeDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label homelabel;
    }
}