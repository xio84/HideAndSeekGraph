using System;
using System.IO;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;
using System.Collections;
using System.Windows.Forms.Integration;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace HideAndSeekGraph
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

        private void graph_input(object sender, EventArgs e)
        {
            /*graph = graphtextbox.Text;
            MessageBox.Show("File = " + graph);*/
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var fileName = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            FlexibleMessageBox.Show(fileContent, "File Content at path : " + filePath, MessageBoxButtons.OK);
            graph = filePath;
            graphlabel.Text = "File Graph : " + fileName;
        }

        private void query_input(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var fileName = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            FlexibleMessageBox.Show(fileContent, "File Content at path : " + filePath, MessageBoxButtons.OK);
            query = filePath;
            querylabel.Text = "File Query : " + fileName;
        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeginProcedure(object sender, EventArgs e)
        {
            Procedure P = new Procedure();
            ArrayList A;
            MainWindow w = new MainWindow(P.Start(graph, query, out A), A);
            ElementHost.EnableModelessKeyboardInterop(w);
            w.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
