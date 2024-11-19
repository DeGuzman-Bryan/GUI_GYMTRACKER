namespace GUI_GYMTRACKER
{
    partial class CreateEditForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbName = new TextBox();
            tbEmail = new TextBox();
            tbProgram = new TextBox();
            tbDate = new TextBox();
            btnsave = new Button();
            btncancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 25);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 0;
            label1.Text = "Create Trainee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 102);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(143, 151);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(143, 208);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 263);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 4;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(143, 320);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 5;
            label6.Text = "Date";
            // 
            // tbName
            // 
            tbName.Location = new Point(316, 153);
            tbName.Name = "tbName";
            tbName.Size = new Size(258, 23);
            tbName.TabIndex = 7;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(316, 210);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(258, 23);
            tbEmail.TabIndex = 8;
            // 
            // tbProgram
            // 
            tbProgram.Location = new Point(316, 265);
            tbProgram.Name = "tbProgram";
            tbProgram.Size = new Size(258, 23);
            tbProgram.TabIndex = 9;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(316, 318);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(258, 23);
            tbDate.TabIndex = 10;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(316, 375);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 23);
            btnsave.TabIndex = 11;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(409, 375);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 23);
            btncancel.TabIndex = 12;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(tbDate);
            Controls.Add(tbProgram);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateEditForm";
            Text = "Create Trainee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbName;
        private TextBox tbEmail;
        private TextBox tbProgram;
        private TextBox tbDate;
        private Button btnsave;
        private Button btncancel;
    }
}