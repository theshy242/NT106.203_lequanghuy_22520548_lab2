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

namespace lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       
        void ShowFileName(string filename)
        {
            txtfilename.Text = filename;
        }
        void ShowSize(long size)
        {
            if (size > 1)
            {
                txtsize.Text = size.ToString() + " bytes";
            }
            else
            {
                txtsize.Text = size.ToString() + " byte";
            }
        }
        void ShowURL(string url)
        {
            txturl.Text = url;
        }
        void ShowLineCount(FileStream fs)
        {
            fs.Position = 0;
            StreamReader reader = new StreamReader(fs);
            int linecount = 0;
            while (reader.ReadLine() != null)
            {
                linecount++;
            }
            txtlinecoutn.Text = linecount.ToString();
        }
        void ShowWordsCount(FileStream fs)
        {
            fs.Position = 0;
            StreamReader reader = new StreamReader(fs);
            int wordscount = 0;
            bool wordcounted = false;
            while (reader.Read() != -1)
            {
                if (reader.Peek() == ' ' || reader.Peek() == '\n' || reader.Peek() == -1 || reader.Peek() == '\t')
                {
                    if (wordcounted == false)
                    {
                        wordscount++;
                        wordcounted = true;
                    }
                    else
                    {
                        reader.Read();
                        wordcounted = true;
                    }
                }
                else
                {
                    wordcounted = false;
                }
            }
           txtwordscount.Text = wordscount.ToString();
        }
        void ShowCharacterCount(FileStream fs)
        {
            fs.Position = 0;
            StreamReader reader = new StreamReader(fs);
            int charactercount = 0;
            while (reader.Read() != -1)
            {
                charactercount++;
            }
            txtCharactercount.Text = charactercount.ToString();
        }

        

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndocfile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            txtHienthi.Text = reader.ReadToEnd();
            ShowFileName(openFile.SafeFileName);
            ShowSize(fs.Length);
            ShowURL(openFile.FileName);
            ShowLineCount(fs);
            ShowWordsCount(fs);
            ShowCharacterCount(fs);
            reader.Close();
        }
    }
}
