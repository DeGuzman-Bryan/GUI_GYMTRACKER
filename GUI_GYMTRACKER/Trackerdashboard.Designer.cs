namespace GUI_GYMTRACKER
{
    partial class TrackerDashboard
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
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            traineesTable = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)traineesTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "LIST OF TRAINEES";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(38, 40);
            button1.Name = "button1";
            button1.Size = new Size(86, 27);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(669, 40);
            button3.Name = "button3";
            button3.Size = new Size(86, 27);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // traineesTable
            // 
            traineesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            traineesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            traineesTable.Location = new Point(38, 73);
            traineesTable.MultiSelect = false;
            traineesTable.Name = "traineesTable";
            traineesTable.RowHeadersVisible = false;
            traineesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            traineesTable.Size = new Size(717, 353);
            traineesTable.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(577, 40);
            button2.Name = "button2";
            button2.Size = new Size(86, 27);
            button2.TabIndex = 5;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TrackerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 217, 218);
            ClientSize = new Size(787, 438);
            Controls.Add(button2);
            Controls.Add(traineesTable);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrackerDashboard";
            Text = "TrackerDashboard";
            ((System.ComponentModel.ISupportInitialize)traineesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button3;
        private DataGridView traineesTable;
        private Button button2;
    }
}