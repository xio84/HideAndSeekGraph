﻿namespace HideAndSeekGraph
{
    partial class InputGraph
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputstring = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mari membuat graf!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan input!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputstring
            // 
            this.inputstring.Location = new System.Drawing.Point(335, 206);
            this.inputstring.Name = "inputstring";
            this.inputstring.Size = new System.Drawing.Size(100, 22);
            this.inputstring.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 26);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.inputStr);
            // 
            // InputGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputstring);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputGraph";
            this.Text = "Building Graph...";
            this.Load += new System.EventHandler(this.InputGraph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputstring;
        private System.Windows.Forms.Button button1;
    }
}