﻿namespace KeLi.FormMvc.Views
{
    partial class PersonForm
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
            this.btnChangeBack = new System.Windows.Forms.Button();
            this.btnChangeFore = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeBack
            // 
            this.btnChangeBack.Location = new System.Drawing.Point(64, 144);
            this.btnChangeBack.Name = "btnChangeBack";
            this.btnChangeBack.Size = new System.Drawing.Size(172, 23);
            this.btnChangeBack.TabIndex = 0;
            this.btnChangeBack.Text = "To Backend";
            this.btnChangeBack.UseVisualStyleBackColor = true;
            this.btnChangeBack.Click += new System.EventHandler(this.BtnChangeBack_Click);
            // 
            // btnChangeFore
            // 
            this.btnChangeFore.Location = new System.Drawing.Point(64, 104);
            this.btnChangeFore.Name = "btnChangeFore";
            this.btnChangeFore.Size = new System.Drawing.Size(172, 23);
            this.btnChangeFore.TabIndex = 1;
            this.btnChangeFore.Text = "To Front";
            this.btnChangeFore.UseVisualStyleBackColor = true;
            this.btnChangeFore.Click += new System.EventHandler(this.BtnChangeFore_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(62, 11);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(178, 21);
            this.tbId.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(62, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 21);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name: ";
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnChangeFore);
            this.Controls.Add(this.btnChangeBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVC Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeBack;
        private System.Windows.Forms.Button btnChangeFore;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

