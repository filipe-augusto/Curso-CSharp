
namespace Part42_FontDialog
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
            this.font = new System.Windows.Forms.FontDialog();
            this.lblFont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // font
            // 
            this.font.ShowApply = true;
            this.font.ShowColor = true;
            this.font.ShowHelp = true;
            this.font.Apply += new System.EventHandler(this.font_Apply);
            // 
            // lblFont
            // 
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(190, 62);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(495, 146);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Clique e selecone uma fonte...";
            this.lblFont.Click += new System.EventHandler(this.lblFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 513);
            this.Controls.Add(this.lblFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog font;
        private System.Windows.Forms.Label lblFont;
    }
}

