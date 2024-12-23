namespace InputDesign
{
    partial class Form3
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
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            nameLabel = new Label();
            nopplLabel = new Label();
            roomNoLabel = new Label();
            totalLabel = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(187, 203, 205);
            label7.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(50, 69, 79);
            label7.Location = new Point(27, 20);
            label7.Name = "label7";
            label7.Size = new Size(271, 27);
            label7.TabIndex = 12;
            label7.Text = "Booking Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(187, 203, 205);
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(50, 69, 79);
            label1.Location = new Point(75, 62);
            label1.Name = "label1";
            label1.Size = new Size(79, 27);
            label1.TabIndex = 13;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(187, 203, 205);
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(50, 69, 79);
            label2.Location = new Point(75, 111);
            label2.Name = "label2";
            label2.Size = new Size(235, 27);
            label2.TabIndex = 14;
            label2.Text = "Number of people:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(187, 203, 205);
            label3.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(50, 69, 79);
            label3.Location = new Point(75, 156);
            label3.Name = "label3";
            label3.Size = new Size(234, 27);
            label3.TabIndex = 15;
            label3.Text = "Booked room num:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(187, 203, 205);
            label4.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(50, 69, 79);
            label4.Location = new Point(27, 214);
            label4.Name = "label4";
            label4.Size = new Size(274, 27);
            label4.TabIndex = 16;
            label4.Text = "Payment information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(187, 203, 205);
            label5.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(50, 69, 79);
            label5.Location = new Point(75, 268);
            label5.Name = "label5";
            label5.Size = new Size(305, 27);
            label5.TabIndex = 17;
            label5.Text = "Total amount required:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(187, 203, 205);
            label9.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(50, 69, 79);
            label9.Location = new Point(329, 388);
            label9.Name = "label9";
            label9.Size = new Size(148, 27);
            label9.TabIndex = 20;
            label9.Text = "thank you!";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(540, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 20);
            nameLabel.TabIndex = 21;
            // 
            // nopplLabel
            // 
            nopplLabel.AutoSize = true;
            nopplLabel.Location = new Point(572, 118);
            nopplLabel.Name = "nopplLabel";
            nopplLabel.Size = new Size(0, 20);
            nopplLabel.TabIndex = 22;
            // 
            // roomNoLabel
            // 
            roomNoLabel.AutoSize = true;
            roomNoLabel.Location = new Point(592, 156);
            roomNoLabel.Name = "roomNoLabel";
            roomNoLabel.Size = new Size(0, 20);
            roomNoLabel.TabIndex = 23;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(602, 272);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(0, 20);
            totalLabel.TabIndex = 24;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(122, 133, 136);
            ClientSize = new Size(800, 450);
            Controls.Add(totalLabel);
            Controls.Add(roomNoLabel);
            Controls.Add(nopplLabel);
            Controls.Add(nameLabel);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label nameLabel;
        private Label nopplLabel;
        private Label roomNoLabel;
        private Label totalLabel;
    }
}