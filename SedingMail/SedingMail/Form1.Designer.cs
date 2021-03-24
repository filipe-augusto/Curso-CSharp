
namespace SedingMail
{
    partial class Form1
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
            this.btnSendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMail2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(340, 147);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(121, 45);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnMail2
            // 
            this.btnMail2.Location = new System.Drawing.Point(147, 117);
            this.btnMail2.Name = "btnMail2";
            this.btnMail2.Size = new System.Drawing.Size(75, 70);
            this.btnMail2.TabIndex = 2;
            this.btnMail2.Text = "Mail 2";
            this.btnMail2.UseVisualStyleBackColor = true;
            this.btnMail2.Click += new System.EventHandler(this.btnMail2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMail2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMail2;
    }
}

