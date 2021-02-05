
namespace FormMdi
{
    partial class FormDois
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
            this.btnFormTres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormTres
            // 
            this.btnFormTres.Location = new System.Drawing.Point(283, 102);
            this.btnFormTres.Name = "btnFormTres";
            this.btnFormTres.Size = new System.Drawing.Size(327, 99);
            this.btnFormTres.TabIndex = 0;
            this.btnFormTres.Text = "Form Tres";
            this.btnFormTres.UseVisualStyleBackColor = true;
            this.btnFormTres.Click += new System.EventHandler(this.btnFormTres_Click);
            // 
            // FormDois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormTres);
            this.Name = "FormDois";
            this.Text = "FormDois";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDois_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormTres;
    }
}