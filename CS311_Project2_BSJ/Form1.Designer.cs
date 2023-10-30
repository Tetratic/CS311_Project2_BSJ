namespace CS311_Project2_BSJ
{
    partial class frmCraps
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
            lblDie1 = new Label();
            lblDie2 = new Label();
            lblRoll1 = new Label();
            lblRoll2 = new Label();
            lblCurrentBalance = new Label();
            lblBal = new Label();
            txtBet = new TextBox();
            btnRoll = new Button();
            lblOutcome = new Label();
            SuspendLayout();
            // 
            // lblDie1
            // 
            lblDie1.AutoSize = true;
            lblDie1.Location = new Point(29, 36);
            lblDie1.Name = "lblDie1";
            lblDie1.Size = new Size(33, 15);
            lblDie1.TabIndex = 0;
            lblDie1.Text = "Die 1";
            // 
            // lblDie2
            // 
            lblDie2.AutoSize = true;
            lblDie2.Location = new Point(29, 81);
            lblDie2.Name = "lblDie2";
            lblDie2.Size = new Size(33, 15);
            lblDie2.TabIndex = 1;
            lblDie2.Text = "Die 2";
            // 
            // lblRoll1
            // 
            lblRoll1.AutoSize = true;
            lblRoll1.Location = new Point(91, 36);
            lblRoll1.Name = "lblRoll1";
            lblRoll1.Size = new Size(38, 15);
            lblRoll1.TabIndex = 2;
            lblRoll1.Text = "label3";
            // 
            // lblRoll2
            // 
            lblRoll2.AutoSize = true;
            lblRoll2.Location = new Point(91, 81);
            lblRoll2.Name = "lblRoll2";
            lblRoll2.Size = new Size(38, 15);
            lblRoll2.TabIndex = 3;
            lblRoll2.Text = "label4";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Location = new Point(171, 36);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(91, 15);
            lblCurrentBalance.TabIndex = 4;
            lblCurrentBalance.Text = "Current Balance";
            // 
            // lblBal
            // 
            lblBal.AutoSize = true;
            lblBal.Location = new Point(171, 81);
            lblBal.Name = "lblBal";
            lblBal.Size = new Size(38, 15);
            lblBal.TabIndex = 5;
            lblBal.Text = "label6";
            // 
            // txtBet
            // 
            txtBet.Location = new Point(29, 170);
            txtBet.Name = "txtBet";
            txtBet.Size = new Size(100, 23);
            txtBet.TabIndex = 6;
            txtBet.Text = "enter your bet";
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(171, 170);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(75, 23);
            btnRoll.TabIndex = 7;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += button1_Click;
            // 
            // lblOutcome
            // 
            lblOutcome.AutoSize = true;
            lblOutcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutcome.Location = new Point(328, 136);
            lblOutcome.Name = "lblOutcome";
            lblOutcome.Size = new Size(83, 32);
            lblOutcome.TabIndex = 8;
            lblOutcome.Text = "label7";
            // 
            // frmCraps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 223);
            Controls.Add(lblOutcome);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Controls.Add(lblBal);
            Controls.Add(lblCurrentBalance);
            Controls.Add(lblRoll2);
            Controls.Add(lblRoll1);
            Controls.Add(lblDie2);
            Controls.Add(lblDie1);
            Name = "frmCraps";
            Text = "Craps";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDie1;
        private Label lblDie2;
        private Label lblRoll1;
        private Label lblRoll2;
        private Label lblCurrentBalance;
        private Label lblBal;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblOutcome;
    }
}