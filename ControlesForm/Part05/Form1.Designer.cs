﻿
namespace Part05
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
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check1
            // 
            this.check1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check1.Checked = true;
            this.check1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check1.ForeColor = System.Drawing.Color.Moccasin;
            this.check1.Location = new System.Drawing.Point(42, 25);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(187, 50);
            this.check1.TabIndex = 0;
            this.check1.Text = "Opção 1";
            this.check1.UseVisualStyleBackColor = false;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // check2
            // 
            this.check2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check2.Checked = true;
            this.check2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check2.ForeColor = System.Drawing.Color.Moccasin;
            this.check2.Location = new System.Drawing.Point(42, 86);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(187, 50);
            this.check2.TabIndex = 1;
            this.check2.Text = "Opção 2";
            this.check2.UseVisualStyleBackColor = false;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // check3
            // 
            this.check3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check3.Checked = true;
            this.check3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check3.ForeColor = System.Drawing.Color.Moccasin;
            this.check3.Location = new System.Drawing.Point(42, 147);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(187, 50);
            this.check3.TabIndex = 2;
            this.check3.Text = "Opção 3";
            this.check3.UseVisualStyleBackColor = false;
            this.check3.CheckedChanged += new System.EventHandler(this.check3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 108);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.Button button1;
    }
}

