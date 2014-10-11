using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemanticVersioningForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = !groupBox1.Enabled;
            textBox1.Enabled = !textBox1.Enabled;
        }

        private void srcButtDia_Click(object sender, EventArgs e)
        {
            sourceFileDialog.ShowDialog();
            srcFilePath.Text = sourceFileDialog.FileName;
        }

        private void destButtDia_Click(object sender, EventArgs e)
        {
            destFileDialog.ShowDialog();
            destFileBox.Text = destFileDialog.FileName;
        }

        private void sortButt_Click(object sender, EventArgs e)
        {
            stLabel.Text = "Sorting...";
            if (checkBox1.Checked)
            {
                //  File stuff
                StreamReader reader = new StreamReader(srcFilePath.Text);
                List<string> fileCont = new List<string>();
                while (!reader.EndOfStream)
                {
                    fileCont.Add(reader.ReadLine());
                }
                reader.Close();
                string[] input = fileCont.ToArray();
                string[] output = sortSemVers(input);
                string s = "";
                for (int i = 0; i < output.Length; i++)
                    s += output[i] + Environment.NewLine;
                StreamWriter writer = new StreamWriter(destFileBox.Text);
                writer.Write(s);
                writer.Close();
            }
            else
            {
                //  Text Box prossessing
                string[] input = textBox1.Text.Split('\n');
                string[] output = sortSemVers(input);
                string s = "";
                for (int i = 0; i < output.Length; i++)
                    s += output[i] + Environment.NewLine;
                textBox1.Text = s;
            }
            stLabel.Text = "Done!";
        }

        private string[] sortSemVers(string[] input)
        {
            SemanticVersion[] workList = new SemanticVersion[input.Length];
            string[] finalList = new string[input.Length];
            for (int x = 0; x < finalList.Length; x++)
            {
                workList[x] = new SemanticVersion(input[x]);
            }
            for (int x = 0; x < finalList.Length; x++)
            {
                int ind = getLeast(workList);
                finalList[x] = workList[ind].ToString();
                workList[ind].SetMajor(int.MaxValue);
            }
            return finalList;
        }

        private int getLeast(SemanticVersion[] args)
        {
            SemanticVersion currMin = args[0];
            int c = 0;
            int i = c;
            foreach (SemanticVersion s in args)
            {
                if (s.CompareTo(currMin) > 0)
                {
                    currMin = s;
                    i = c;
                }
                c++;
            }
            return i;
        }
    }
}
