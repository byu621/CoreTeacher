﻿namespace CoreTeacher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.character1 = new System.Windows.Forms.Label();
            this.character2 = new System.Windows.Forms.Label();
            this.pinyin1 = new System.Windows.Forms.Label();
            this.pinyin2 = new System.Windows.Forms.Label();
            this.iteratorLabel = new System.Windows.Forms.Label();
            this.syncButton = new System.Windows.Forms.Button();
            this.toBox = new System.Windows.Forms.TextBox();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.hskBox = new System.Windows.Forms.TextBox();
            this.purpleButton1 = new System.Windows.Forms.Button();
            this.purpleButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // character1
            // 
            this.character1.AutoSize = true;
            this.character1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.character1.Location = new System.Drawing.Point(18, 61);
            this.character1.Margin = new System.Windows.Forms.Padding(31, 0, 31, 0);
            this.character1.Name = "character1";
            this.character1.Size = new System.Drawing.Size(495, 128);
            this.character1.TabIndex = 0;
            this.character1.Text = "character1";
            // 
            // character2
            // 
            this.character2.AutoSize = true;
            this.character2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.character2.Location = new System.Drawing.Point(18, 205);
            this.character2.Margin = new System.Windows.Forms.Padding(31, 0, 31, 0);
            this.character2.Name = "character2";
            this.character2.Size = new System.Drawing.Size(495, 128);
            this.character2.TabIndex = 1;
            this.character2.Text = "character2";
            // 
            // pinyin1
            // 
            this.pinyin1.AutoSize = true;
            this.pinyin1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pinyin1.Location = new System.Drawing.Point(45, 168);
            this.pinyin1.Name = "pinyin1";
            this.pinyin1.Size = new System.Drawing.Size(62, 21);
            this.pinyin1.TabIndex = 2;
            this.pinyin1.Text = "pinyin1";
            // 
            // pinyin2
            // 
            this.pinyin2.AutoSize = true;
            this.pinyin2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pinyin2.Location = new System.Drawing.Point(45, 342);
            this.pinyin2.Name = "pinyin2";
            this.pinyin2.Size = new System.Drawing.Size(62, 21);
            this.pinyin2.TabIndex = 3;
            this.pinyin2.Text = "pinyin2";
            // 
            // iteratorLabel
            // 
            this.iteratorLabel.AutoSize = true;
            this.iteratorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iteratorLabel.Location = new System.Drawing.Point(557, 20);
            this.iteratorLabel.Name = "iteratorLabel";
            this.iteratorLabel.Size = new System.Drawing.Size(61, 21);
            this.iteratorLabel.TabIndex = 4;
            this.iteratorLabel.Text = "iterator";
            // 
            // syncButton
            // 
            this.syncButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.syncButton.Location = new System.Drawing.Point(476, 12);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(75, 36);
            this.syncButton.TabIndex = 8;
            this.syncButton.Text = "Sync";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // toBox
            // 
            this.toBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toBox.Location = new System.Drawing.Point(396, 17);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(61, 29);
            this.toBox.TabIndex = 7;
            this.toBox.TextChanged += new System.EventHandler(this.toBox_TextChanged);
            // 
            // fromBox
            // 
            this.fromBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromBox.Location = new System.Drawing.Point(305, 17);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(61, 29);
            this.fromBox.TabIndex = 6;
            this.fromBox.TextChanged += new System.EventHandler(this.fromBox_TextChanged);
            // 
            // hskBox
            // 
            this.hskBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hskBox.Location = new System.Drawing.Point(242, 17);
            this.hskBox.Name = "hskBox";
            this.hskBox.Size = new System.Drawing.Size(34, 29);
            this.hskBox.TabIndex = 5;
            this.hskBox.Text = "1";
            this.hskBox.TextChanged += new System.EventHandler(this.hskBox_TextChanged);
            // 
            // purpleButton1
            // 
            this.purpleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purpleButton1.Location = new System.Drawing.Point(396, 179);
            this.purpleButton1.Name = "purpleButton1";
            this.purpleButton1.Size = new System.Drawing.Size(75, 23);
            this.purpleButton1.TabIndex = 9;
            this.purpleButton1.Text = "purple";
            this.purpleButton1.UseVisualStyleBackColor = true;
            this.purpleButton1.Click += new System.EventHandler(this.purpleButton1_Click);
            // 
            // purpleButton2
            // 
            this.purpleButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purpleButton2.Location = new System.Drawing.Point(396, 343);
            this.purpleButton2.Name = "purpleButton2";
            this.purpleButton2.Size = new System.Drawing.Size(75, 23);
            this.purpleButton2.TabIndex = 10;
            this.purpleButton2.Text = "purple";
            this.purpleButton2.UseVisualStyleBackColor = true;
            this.purpleButton2.Click += new System.EventHandler(this.purpleButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(73F, 175F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 455);
            this.Controls.Add(this.purpleButton2);
            this.Controls.Add(this.purpleButton1);
            this.Controls.Add(this.hskBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.iteratorLabel);
            this.Controls.Add(this.pinyin2);
            this.Controls.Add(this.pinyin1);
            this.Controls.Add(this.character2);
            this.Controls.Add(this.character1);
            this.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(31, 35, 31, 35);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaseForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label character1;
        private Label character2;
        private Label pinyin1;
        private Label pinyin2;
        private Label iteratorLabel;
        private Button syncButton;
        private TextBox toBox;
        private TextBox fromBox;
        private TextBox hskBox;
        private Button purpleButton1;
        private Button purpleButton2;
    }
}