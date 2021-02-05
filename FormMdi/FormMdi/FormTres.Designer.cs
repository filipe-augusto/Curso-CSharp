
namespace FormMdi
{
    partial class FormTres
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
            this.btnFormDois = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormDois
            // 
            this.btnFormDois.Location = new System.Drawing.Point(225, 97);
            this.btnFormDois.Name = "btnFormDois";
            this.btnFormDois.Size = new System.Drawing.Size(329, 154);
            this.btnFormDois.TabIndex = 0;
            this.btnFormDois.Text = "Form Dois";
            this.btnFormDois.UseVisualStyleBackColor = true;
            this.btnFormDois.Click += new System.EventHandler(this.btnFormDois_Click);
            // 
            // FormTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormDois);
            this.Name = "FormTres";
            this.Text = "FormTres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormDois;
    }
}