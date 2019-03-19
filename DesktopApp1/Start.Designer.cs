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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.graphfbutton = new System.Windows.Forms.Button();
            this.graphlabel = new System.Windows.Forms.Label();
            this.querylabel = new System.Windows.Forms.Label();
            this.queryfbutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.Quit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.helloWorldLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.helloWorldLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helloWorldLabel.Image = ((System.Drawing.Image)(resources.GetObject("helloWorldLabel.Image")));
            this.helloWorldLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.helloWorldLabel.Location = new System.Drawing.Point(135, 19);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(479, 42);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "HIDE AND SEEK GRAPH!";
            this.helloWorldLabel.Click += new System.EventHandler(this.helloWorldLabel_Click);
            // 
            // graphfbutton
            // 
            this.graphfbutton.BackColor = System.Drawing.Color.Maroon;
            this.graphfbutton.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphfbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.graphfbutton.Image = ((System.Drawing.Image)(resources.GetObject("graphfbutton.Image")));
            this.graphfbutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.graphfbutton.Location = new System.Drawing.Point(57, 223);
            this.graphfbutton.Name = "graphfbutton";
            this.graphfbutton.Size = new System.Drawing.Size(149, 57);
            this.graphfbutton.TabIndex = 8;
            this.graphfbutton.Text = "Input Graph File";
            this.graphfbutton.UseVisualStyleBackColor = false;
            this.graphfbutton.Click += new System.EventHandler(this.graph_input);
            // 
            // graphlabel
            // 
            this.graphlabel.AutoEllipsis = true;
            this.graphlabel.AutoSize = true;
            this.graphlabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.graphlabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphlabel.Location = new System.Drawing.Point(59, 84);
            this.graphlabel.Name = "graphlabel";
            this.graphlabel.Size = new System.Drawing.Size(147, 31);
            this.graphlabel.TabIndex = 9;
            this.graphlabel.Text = "File Graph : ";
            // 
            // querylabel
            // 
            this.querylabel.AutoEllipsis = true;
            this.querylabel.AutoSize = true;
            this.querylabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.querylabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.querylabel.Location = new System.Drawing.Point(59, 149);
            this.querylabel.Name = "querylabel";
            this.querylabel.Size = new System.Drawing.Size(150, 31);
            this.querylabel.TabIndex = 12;
            this.querylabel.Text = "File Query : ";
            // 
            // queryfbutton
            // 
            this.queryfbutton.BackColor = System.Drawing.Color.Maroon;
            this.queryfbutton.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryfbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.queryfbutton.Image = ((System.Drawing.Image)(resources.GetObject("queryfbutton.Image")));
            this.queryfbutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.queryfbutton.Location = new System.Drawing.Point(375, 223);
            this.queryfbutton.Name = "queryfbutton";
            this.queryfbutton.Size = new System.Drawing.Size(157, 57);
            this.queryfbutton.TabIndex = 11;
            this.queryfbutton.Text = "Input Query File";
            this.queryfbutton.UseVisualStyleBackColor = false;
            this.queryfbutton.Click += new System.EventHandler(this.query_input);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.Maroon;
            this.startbutton.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startbutton.Image = ((System.Drawing.Image)(resources.GetObject("startbutton.Image")));
            this.startbutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.startbutton.Location = new System.Drawing.Point(56, 306);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(150, 55);
            this.startbutton.TabIndex = 13;
            this.startbutton.Text = "Start!";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.BeginProcedure);
            // 
            // Quit_button
            // 
            this.Quit_button.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit_button.Image = ((System.Drawing.Image)(resources.GetObject("Quit_button.Image")));
            this.Quit_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Quit_button.Location = new System.Drawing.Point(375, 306);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(157, 55);
            this.Quit_button.TabIndex = 14;
            this.Quit_button.Text = "Quit";
            this.Quit_button.UseVisualStyleBackColor = true;
            this.Quit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 396);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.querylabel);
            this.Controls.Add(this.queryfbutton);
            this.Controls.Add(this.graphlabel);
            this.Controls.Add(this.graphfbutton);
            this.Controls.Add(this.helloWorldLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Start";
            this.Text = "Start Menu";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button graphfbutton;
        private System.Windows.Forms.Label graphlabel;
        private System.Windows.Forms.Label querylabel;
        private System.Windows.Forms.Button queryfbutton;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button Quit_button;
    }
}

