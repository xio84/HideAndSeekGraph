using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class InputGraph : Form
    {
        int N,i;
        string[] inputs;
        public InputGraph(int n)
        {
            InitializeComponent();
            N = n;
            i = 0;
            inputs = new string[n];
            button1.Text = "Masukkan!: " + N + " input lagi";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputStr(object sender, EventArgs e)
        {
            if (N > 0)
            {
                inputs[i] = inputstring.Text;
                inputstring.Text = null;
                MessageBox.Show("Okay!");
                N--;
                i++;
                button1.Text = "Masukkan!: " + N + " input lagi";
            }
            else
            {
                inputstring.Text = null;
                MessageBox.Show("Terlalu banyak input!");
                button1.Text = "Masukkan!: " + N + " input lagi";
            }
        }
    }
}
