
namespace Part25_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tP1 = new System.Windows.Forms.TabPage();
            this.tP2 = new System.Windows.Forms.TabPage();
            this.url_2 = new System.Windows.Forms.TextBox();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.url_1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tP1.SuspendLayout();
            this.tP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tP1);
            this.tabControl1.Controls.Add(this.tP2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tP1
            // 
            this.tP1.Controls.Add(this.webBrowser1);
            this.tP1.Controls.Add(this.btn1);
            this.tP1.Controls.Add(this.url_1);
            this.tP1.Location = new System.Drawing.Point(4, 22);
            this.tP1.Name = "tP1";
            this.tP1.Padding = new System.Windows.Forms.Padding(3);
            this.tP1.Size = new System.Drawing.Size(792, 424);
            this.tP1.TabIndex = 0;
            this.tP1.Text = "Browser 1";
            this.tP1.UseVisualStyleBackColor = true;
            // 
            // tP2
            // 
            this.tP2.Controls.Add(this.btn2);
            this.tP2.Controls.Add(this.webBrowser2);
            this.tP2.Controls.Add(this.url_2);
            this.tP2.Location = new System.Drawing.Point(4, 22);
            this.tP2.Name = "tP2";
            this.tP2.Padding = new System.Windows.Forms.Padding(3);
            this.tP2.Size = new System.Drawing.Size(792, 424);
            this.tP2.TabIndex = 1;
            this.tP2.Text = "Browser 2";
            this.tP2.UseVisualStyleBackColor = true;
            // 
            // url_2
            // 
            this.url_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.url_2.Location = new System.Drawing.Point(14, 6);
            this.url_2.Name = "url_2";
            this.url_2.Size = new System.Drawing.Size(693, 20);
            this.url_2.TabIndex = 0;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(66, 41);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(641, 360);
            this.webBrowser2.TabIndex = 1;
            // 
            // url_1
            // 
            this.url_1.Location = new System.Drawing.Point(0, 0);
            this.url_1.Name = "url_1";
            this.url_1.Size = new System.Drawing.Size(695, 20);
            this.url_1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(695, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(97, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Ir";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(711, 6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 59);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "ir";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(37, 29);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(721, 350);
            this.webBrowser1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tP1.ResumeLayout(false);
            this.tP1.PerformLayout();
            this.tP2.ResumeLayout(false);
            this.tP2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tP1;
        private System.Windows.Forms.TabPage tP2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox url_1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TextBox url_2;
    }
}

