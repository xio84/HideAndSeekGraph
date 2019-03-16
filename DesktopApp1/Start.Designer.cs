namespace HideAndSeekGraph
{
    partial class Start
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
            this.Ninput = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.jumlahN = new System.Windows.Forms.Label();
            this.graphfbutton = new System.Windows.Forms.Button();
            this.graphlabel = new System.Windows.Forms.Label();
            this.querylabel = new System.Windows.Forms.Label();
            this.queryfbutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ninput
            // 
            this.Ninput.Location = new System.Drawing.Point(100, 185);
            this.Ninput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ninput.Name = "Ninput";
            this.Ninput.Size = new System.Drawing.Size(114, 38);
            this.Ninput.TabIndex = 2;
            this.Ninput.Text = "Enter N";
            this.Ninput.UseVisualStyleBackColor = true;
            this.Ninput.Click += new System.EventHandler(this.jumalhN_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(297, 36);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(173, 31);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Masukkan N!";
            this.helloWorldLabel.Click += new System.EventHandler(this.helloWorldLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(100, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Make Graph!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.compute);
            // 
            // jumlahN
            // 
            this.jumlahN.AutoSize = true;
            this.jumlahN.Location = new System.Drawing.Point(97, 153);
            this.jumlahN.Name = "jumlahN";
            this.jumlahN.Size = new System.Drawing.Size(87, 18);
            this.jumlahN.TabIndex = 7;
            this.jumlahN.Text = "Jumlah N = 0";
            // 
            // graphfbutton
            // 
            this.graphfbutton.Font = new System.Drawing.Font("Trebuchet MS", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphfbutton.Location = new System.Drawing.Point(303, 153);
            this.graphfbutton.Name = "graphfbutton";
            this.graphfbutton.Size = new System.Drawing.Size(145, 38);
            this.graphfbutton.TabIndex = 8;
            this.graphfbutton.Text = "Masukkan file graph";
            this.graphfbutton.UseVisualStyleBackColor = true;
            this.graphfbutton.Click += new System.EventHandler(this.graph_input);
            // 
            // graphlabel
            // 
            this.graphlabel.AutoSize = true;
            this.graphlabel.Location = new System.Drawing.Point(300, 116);
            this.graphlabel.Name = "graphlabel";
            this.graphlabel.Size = new System.Drawing.Size(39, 18);
            this.graphlabel.TabIndex = 9;
            this.graphlabel.Text = "File: ";
            // 
            // querylabel
            // 
            this.querylabel.AutoSize = true;
            this.querylabel.Location = new System.Drawing.Point(300, 205);
            this.querylabel.Name = "querylabel";
            this.querylabel.Size = new System.Drawing.Size(39, 18);
            this.querylabel.TabIndex = 12;
            this.querylabel.Text = "File: ";
            // 
            // queryfbutton
            // 
            this.queryfbutton.Location = new System.Drawing.Point(303, 254);
            this.queryfbutton.Name = "queryfbutton";
            this.queryfbutton.Size = new System.Drawing.Size(145, 38);
            this.queryfbutton.TabIndex = 11;
            this.queryfbutton.Text = "Masukkan file query";
            this.queryfbutton.UseVisualStyleBackColor = true;
            this.queryfbutton.Click += new System.EventHandler(this.query_input);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(568, 185);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(144, 38);
            this.startbutton.TabIndex = 13;
            this.startbutton.Text = "Start!";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.BeginProcedure);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 405);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.querylabel);
            this.Controls.Add(this.queryfbutton);
            this.Controls.Add(this.graphlabel);
            this.Controls.Add(this.graphfbutton);
            this.Controls.Add(this.jumlahN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.Ninput);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Start";
            this.Text = "Start Menu";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ninput;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label jumlahN;
        private System.Windows.Forms.Button graphfbutton;
        private System.Windows.Forms.Label graphlabel;
        private System.Windows.Forms.Label querylabel;
        private System.Windows.Forms.Button queryfbutton;
        private System.Windows.Forms.Button startbutton;
    }
}

