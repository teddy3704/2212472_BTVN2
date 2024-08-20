namespace SimpleCrosswordGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHint = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(13, 13);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(115, 13);
            this.lblHint.TabIndex = 0;
            this.lblHint.Text = "Nhập một loại trái cây: ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(16, 39);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(200, 20);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.Text = "Tao";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(222, 37);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 72);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(309, 104);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblHint);
            this.Name = "Form1";
            this.Text = "Trò Chơi Ô Chữ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
