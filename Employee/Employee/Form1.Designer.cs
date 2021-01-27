
namespace Employee
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textHours = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelOutSourcedEmployee = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkOutSource = new System.Windows.Forms.CheckBox();
            this.listTable = new System.Windows.Forms.ListBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textValuePerEployee = new System.Windows.Forms.MaskedTextBox();
            this.textAdditionalCharge = new System.Windows.Forms.MaskedTextBox();
            this.panelOutSourcedEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(606, 371);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Register / Change";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(266, 49);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(369, 31);
            this.textName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(59, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hours";
            // 
            // textHours
            // 
            this.textHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHours.Location = new System.Drawing.Point(266, 106);
            this.textHours.Mask = "00000";
            this.textHours.Name = "textHours";
            this.textHours.Size = new System.Drawing.Size(94, 31);
            this.textHours.TabIndex = 4;
            this.textHours.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(59, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value Per Hour";
            // 
            // panelOutSourcedEmployee
            // 
            this.panelOutSourcedEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelOutSourcedEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOutSourcedEmployee.Controls.Add(this.textAdditionalCharge);
            this.panelOutSourcedEmployee.Controls.Add(this.label4);
            this.panelOutSourcedEmployee.Location = new System.Drawing.Point(64, 265);
            this.panelOutSourcedEmployee.Name = "panelOutSourcedEmployee";
            this.panelOutSourcedEmployee.Size = new System.Drawing.Size(520, 88);
            this.panelOutSourcedEmployee.TabIndex = 7;
            this.panelOutSourcedEmployee.Tag = "Out sourced Employee";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Additional Charge";
            // 
            // checkOutSource
            // 
            this.checkOutSource.AutoSize = true;
            this.checkOutSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutSource.ForeColor = System.Drawing.SystemColors.Info;
            this.checkOutSource.Location = new System.Drawing.Point(64, 219);
            this.checkOutSource.Name = "checkOutSource";
            this.checkOutSource.Size = new System.Drawing.Size(249, 29);
            this.checkOutSource.TabIndex = 8;
            this.checkOutSource.Text = "Out sourced Employee";
            this.checkOutSource.UseVisualStyleBackColor = true;
            this.checkOutSource.CheckedChanged += new System.EventHandler(this.checkValuePerHour_CheckedChanged);
            // 
            // listTable
            // 
            this.listTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTable.FormattingEnabled = true;
            this.listTable.ItemHeight = 24;
            this.listTable.Items.AddRange(new object[] {
            "Name and Salary"});
            this.listTable.Location = new System.Drawing.Point(42, 371);
            this.listTable.Name = "listTable";
            this.listTable.Size = new System.Drawing.Size(542, 148);
            this.listTable.TabIndex = 9;
            this.listTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listTable_MouseDoubleClick);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(606, 430);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(130, 38);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(606, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // textValuePerEployee
            // 
            this.textValuePerEployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValuePerEployee.Location = new System.Drawing.Point(266, 161);
            this.textValuePerEployee.Mask = "00000";
            this.textValuePerEployee.Name = "textValuePerEployee";
            this.textValuePerEployee.Size = new System.Drawing.Size(369, 31);
            this.textValuePerEployee.TabIndex = 12;
            this.textValuePerEployee.ValidatingType = typeof(int);
            // 
            // textAdditionalCharge
            // 
            this.textAdditionalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdditionalCharge.Location = new System.Drawing.Point(200, 21);
            this.textAdditionalCharge.Mask = "00000";
            this.textAdditionalCharge.Name = "textAdditionalCharge";
            this.textAdditionalCharge.Size = new System.Drawing.Size(313, 31);
            this.textAdditionalCharge.TabIndex = 13;
            this.textAdditionalCharge.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(774, 562);
            this.Controls.Add(this.textValuePerEployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.listTable);
            this.Controls.Add(this.checkOutSource);
            this.Controls.Add(this.panelOutSourcedEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Tag = "Out sourced Employee";
            this.Text = " registration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOutSourcedEmployee.ResumeLayout(false);
            this.panelOutSourcedEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelOutSourcedEmployee;
        private System.Windows.Forms.CheckBox checkOutSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listTable;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox textValuePerEployee;
        private System.Windows.Forms.MaskedTextBox textAdditionalCharge;
    }
}

