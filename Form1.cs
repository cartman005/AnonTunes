using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonTunes
{
    public partial class Form1 : Form
    {
        private static int TIMEOUT_SECONDS = 30;
        private static string EXECUTABLE = "AtomicParsley-utf8.exe";
        private static string ARGUMENTS = "--DeepScan --manualAtomRemove moov.trak.mdia.minf.stbl.stsd.mp4a.pinf --manualAtomRemove moov.trak[2].mdia.minf.stbl.stsd.avc1.pinf --manualAtomRemove moov.trak.mdia.minf.stbl.stsd.mp4a.UUID --manualAtomRemove moov.udta.meta.ilst.apID --manualAtomRemove moov.udta.meta.ilst.sfID --manualAtomRemove moov.udta.meta.ilst.purd --manualAtomRemove moov.udta.Xtra --manualAtomRemove moov.udta.meta.ilst.ownr --freefree 0 -W";

        public Form1()
        {
            InitializeComponent();
            pathText.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        }

        private void wipeButton_Click(object sender, EventArgs e)
        {
            // Extensions of files to wipe
            var extensionList = new string[] { ".mp4", ".m4a", ".m4b", ".m4r" };

            // Iterate through parent folder to find all .mp4 files
            var musicFiles = Directory.GetFiles(pathText.Text, "*", SearchOption.AllDirectories)
                .Where(n => extensionList.Contains(Path.GetExtension(n), StringComparer.OrdinalIgnoreCase))
                .ToList();

            // Initialize the progress bar
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = musicFiles.Count;
            progressBar1.Value = 1;
            progressBar1.Step = 1;

            // Launch AtomicParsley for each file
            string output;
            string arguments;
            foreach (string filePath in musicFiles)
            {
                arguments = "\"" + filePath + "\" " + ARGUMENTS;
                Debug.WriteLine("Wiping {0}", filePath, "");
                output = LaunchEXE.Run(EXECUTABLE, arguments, TIMEOUT_SECONDS);
                //if (output != "")
                //{
                    //output = output.Substring(output.LastIndexOf(Environment.NewLine));
                    Debug.WriteLine(output);
                //}
                progressBar1.PerformStep();
            }

            progressBar1.Visible = false;
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.pathText.Text = folderBrowserDialog1.SelectedPath;                
        }

        private void pathLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
