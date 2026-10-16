namespace ITECAO_project
{
    partial class ReportForm
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
            lblTotal = new Label();
            lblAverage = new Label();
            lblHighest = new Label();
            lblLowest = new Label();
            label2 = new Label();
            lblWeak = new Label();
            lblModerate = new Label();
            lblStrong = new Label();
            lblVeryStrong = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(507, 32);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 0;
            label1.Text = "Security Report";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(510, 95);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(177, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total Passwords Analysed";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(537, 151);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(105, 20);
            lblAverage.TabIndex = 2;
            lblAverage.Text = "Average Score";
            // 
            // lblHighest
            // 
            lblHighest.AutoSize = true;
            lblHighest.Location = new Point(541, 201);
            lblHighest.Name = "lblHighest";
            lblHighest.Size = new Size(101, 20);
            lblHighest.TabIndex = 3;
            lblHighest.Text = "Highest Score";
            // 
            // lblLowest
            // 
            lblLowest.AutoSize = true;
            lblLowest.Location = new Point(541, 244);
            lblLowest.Name = "lblLowest";
            lblLowest.Size = new Size(96, 20);
            lblLowest.TabIndex = 4;
            lblLowest.Text = "Lowest Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 301);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 5;
            label2.Text = "Strength Breakdown";
            // 
            // lblWeak
            // 
            lblWeak.AutoSize = true;
            lblWeak.Location = new Point(554, 354);
            lblWeak.Name = "lblWeak";
            lblWeak.Size = new Size(45, 20);
            lblWeak.TabIndex = 6;
            lblWeak.Text = "Weak";
            // 
            // lblModerate
            // 
            lblModerate.AutoSize = true;
            lblModerate.Location = new Point(554, 398);
            lblModerate.Name = "lblModerate";
            lblModerate.Size = new Size(74, 20);
            lblModerate.TabIndex = 7;
            lblModerate.Text = "Moderate";
            // 
            // lblStrong
            // 
            lblStrong.AutoSize = true;
            lblStrong.Location = new Point(554, 434);
            lblStrong.Name = "lblStrong";
            lblStrong.Size = new Size(53, 20);
            lblStrong.TabIndex = 8;
            lblStrong.Text = "Strong";
            // 
            // lblVeryStrong
            // 
            lblVeryStrong.AutoSize = true;
            lblVeryStrong.Location = new Point(552, 481);
            lblVeryStrong.Name = "lblVeryStrong";
            lblVeryStrong.Size = new Size(85, 20);
            lblVeryStrong.TabIndex = 9;
            lblVeryStrong.Text = "Very Strong";
          
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 583);
            Controls.Add(lblVeryStrong);
            Controls.Add(lblStrong);
            Controls.Add(lblModerate);
            Controls.Add(lblWeak);
            Controls.Add(label2);
            Controls.Add(lblLowest);
            Controls.Add(lblHighest);
            Controls.Add(lblAverage);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Name = "ReportForm";
            Text = "ReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTotal;
        private Label lblAverage;
        private Label lblHighest;
        private Label lblLowest;
        private Label label2;
        private Label lblWeak;
        private Label lblModerate;
        private Label lblStrong;
        private Label lblVeryStrong;
    }
}