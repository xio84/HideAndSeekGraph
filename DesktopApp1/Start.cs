using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Start : Form
    {
        string input;

        public Start()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
            input = textBox1.Text;
            textBox1.Text = null;
        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void compute(object sender, EventArgs e)
        {
            int n;
            if (Int32.TryParse(input, out n))
            {
                Form InputGraph = new InputGraph(n);
                InputGraph.ShowDialog();
            }
        }
    }
}
