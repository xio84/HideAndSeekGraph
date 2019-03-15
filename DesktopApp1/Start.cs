using System;
using System.IO;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Start : Form
    {
        string input,graph,query;

        public Start()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void jumalhN_Click(object sender, EventArgs e)
        {
            input = textBox1.Text;
            MessageBox.Show("Jumlah input = "+input);
            jumlahN.Text = "Jumlah N = " + input;
            textBox1.Text = null;
        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void graph_input(object sender, EventArgs e)
        {
            /*graph = graphtextbox.Text;
            MessageBox.Show("File = " + graph);*/
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            graph = filePath;
            graphlabel.Text = "File = " + graph;
        }

        private void query_input(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            query = filePath;
            querylabel.Text = "File = " + query;
        }

        private void BeginProcedure(object sender, EventArgs e)
        {
            Procedure P = new Procedure();
            P.Start(graph,query);
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

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
