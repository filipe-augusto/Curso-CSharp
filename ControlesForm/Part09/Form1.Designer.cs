
namespace Part09
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
            this.link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.ActiveLinkColor = System.Drawing.Color.Peru;
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.ForeColor = System.Drawing.Color.DarkOrange;
            this.link.LinkArea = new System.Windows.Forms.LinkArea(6, 8);
            this.link.LinkColor = System.Drawing.Color.Red;
            this.link.Location = new System.Drawing.Point(99, 67);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(102, 30);
            this.link.TabIndex = 0;
            this.link.TabStop = true;
            this.link.Text = "Curso C#";
            this.link.UseCompatibleTextRendering = true;
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link;
    }
}

