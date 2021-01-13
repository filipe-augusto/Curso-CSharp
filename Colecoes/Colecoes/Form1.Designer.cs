
namespace Colecoes
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
            this.btnList = new System.Windows.Forms.Button();
            this.listaBox = new System.Windows.Forms.ListBox();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDicionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(534, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(133, 41);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // listaBox
            // 
            this.listaBox.FormattingEnabled = true;
            this.listaBox.Location = new System.Drawing.Point(24, 10);
            this.listaBox.Name = "listaBox";
            this.listaBox.Size = new System.Drawing.Size(468, 407);
            this.listaBox.TabIndex = 2;
            // 
            // btnHashSet
            // 
            this.btnHashSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashSet.Location = new System.Drawing.Point(534, 59);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(133, 41);
            this.btnHashSet.TabIndex = 3;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDicionary
            // 
            this.btnDicionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDicionary.Location = new System.Drawing.Point(534, 106);
            this.btnDicionary.Name = "btnDicionary";
            this.btnDicionary.Size = new System.Drawing.Size(133, 41);
            this.btnDicionary.TabIndex = 4;
            this.btnDicionary.Text = "Dicionary";
            this.btnDicionary.UseVisualStyleBackColor = true;
            this.btnDicionary.Click += new System.EventHandler(this.btnDicionary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnDicionary);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.listaBox);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Listas Genericas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox listaBox;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDicionary;
    }
}

