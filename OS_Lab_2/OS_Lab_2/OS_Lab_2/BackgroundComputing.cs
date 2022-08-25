using System;
using System.Windows.Forms;
using System.IO;

namespace OS_Lab_2
{
    public partial class BackgroundComputing : Form
    {
        public BackgroundComputing()
        {
            InitializeComponent();
        }
        public byte[] bytearr { get; set; }
        string filename;
        string filenameend;
        string type;
        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                type = Path.GetExtension(op.FileName);
                filename = op.FileName;

                textBoxFile.Text = filename;

                FileStream fstream = File.OpenRead(filename);
                bytearr = new byte[fstream.Length];
                fstream.Read(bytearr, 0, bytearr.Length);
            }
        }

        private void buttonFileCopy_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = $"Text documents ({type})|*{type}";

            if (save.ShowDialog() == DialogResult.OK)
            {
                filenameend = save.FileName;
                textBoxFileCopy.Text = filenameend;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(filenameend, bytearr);
        }

        private void buttonCopyInSeparateThread_Click(object sender, EventArgs e)
        {

        }

    }
}
