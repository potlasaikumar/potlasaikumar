namespace SSProject
{
    partial class EnterATMPIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PinTb = new System.Windows.Forms.TextBox();
            this.BankRegisteredTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Citizen Bank ATM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(191, 143);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter your ATM PIN";
            // 
            // PinTb
            // 
            this.PinTb.Location = new System.Drawing.Point(424, 213);
            this.PinTb.Multiline = true;
            this.PinTb.Name = "PinTb";
            this.PinTb.PasswordChar = '*';
            this.PinTb.Size = new System.Drawing.Size(144, 22);
            this.PinTb.TabIndex = 10;
            this.PinTb.TextChanged += new System.EventHandler(this.PinTb_TextChanged);
            // 
            // BankRegisteredTb
            // 
            this.BankRegisteredTb.Location = new System.Drawing.Point(493, 292);
            this.BankRegisteredTb.Name = "BankRegisteredTb";
            this.BankRegisteredTb.Size = new System.Drawing.Size(100, 20);
            this.BankRegisteredTb.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Bank Registered";
            // 
            // EnterATMPIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BankRegisteredTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PinTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnterATMPIN";
            this.Text = "EnterATMPIN";
            this.Load += new System.EventHandler(this.EnterATMPIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PinTb;
        private System.Windows.Forms.TextBox BankRegisteredTb;
        private System.Windows.Forms.Label label9;
    }
}