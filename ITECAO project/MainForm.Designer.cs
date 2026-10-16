namespace ITECAO_project
{
    partial class MainForm
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
            txtPassword = new TextBox();
            btnAnalyse = new Button();
            label2 = new Label();
            cmbPasswordType = new ComboBox();
            lblScore = new Label();
            lblStrength = new Label();
            lblType = new Label();
            txtRecommendation = new TextBox();
            label3 = new Label();
            lstPasswords = new ListBox();
            btnReport = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 38);
            label1.TabIndex = 0;
            label1.Text = "Password Security Analyser";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(313, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnAnalyse
            // 
            btnAnalyse.Location = new Point(313, 129);
            btnAnalyse.Name = "btnAnalyse";
            btnAnalyse.Size = new Size(109, 51);
            btnAnalyse.TabIndex = 2;
            btnAnalyse.Text = "Analyse Password";
            btnAnalyse.UseVisualStyleBackColor = true;
            btnAnalyse.Click += btnAnalyse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 361);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // cmbPasswordType
            // 
            cmbPasswordType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPasswordType.FormattingEnabled = true;
            cmbPasswordType.Items.AddRange(new object[] { "Personal", "Business", "Administrator" });
            cmbPasswordType.Location = new Point(478, 222);
            cmbPasswordType.Name = "cmbPasswordType";
            cmbPasswordType.Size = new Size(220, 28);
            cmbPasswordType.TabIndex = 4;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(313, 183);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(46, 20);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score";
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Location = new Point(304, 239);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(65, 20);
            lblStrength.TabIndex = 6;
            lblStrength.Text = "Strength";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(313, 303);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 7;
            lblType.Text = "Type";
            // 
            // txtRecommendation
            // 
            txtRecommendation.Location = new Point(282, 349);
            txtRecommendation.Multiline = true;
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.ReadOnly = true;
            txtRecommendation.Size = new Size(125, 42);
            txtRecommendation.TabIndex = 8;
            txtRecommendation.TextChanged += txtRecommendation_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 421);
            label3.Name = "label3";
            label3.Size = new Size(219, 20);
            label3.TabIndex = 9;
            label3.Text = "Passwords Analyzed this session";
            // 
            // lstPasswords
            // 
            lstPasswords.FormattingEnabled = true;
            lstPasswords.Location = new Point(224, 450);
            lstPasswords.Name = "lstPasswords";
            lstPasswords.Size = new Size(214, 144);
            lstPasswords.TabIndex = 10;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(478, 129);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(106, 52);
            btnReport.TabIndex = 11;
            btnReport.Text = "Generate Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 618);
            Controls.Add(btnReport);
            Controls.Add(lstPasswords);
            Controls.Add(label3);
            Controls.Add(txtRecommendation);
            Controls.Add(lblType);
            Controls.Add(lblStrength);
            Controls.Add(lblScore);
            Controls.Add(cmbPasswordType);
            Controls.Add(label2);
            Controls.Add(btnAnalyse);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Button btnAnalyse;
        private Label label2;
        private ComboBox cmbPasswordType;
        private Label lblScore;
        private Label lblStrength;
        private Label lblType;
        private TextBox txtRecommendation;
        private Label label3;
        private ListBox lstPasswords;
        private Button btnReport;
    }
}