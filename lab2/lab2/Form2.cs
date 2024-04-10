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
    public partial class Form2 : Form
    {
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;

        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài 1 : Ghi và đọc file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đọc file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ghi file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(625, 406);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1268, 512);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader streamReader = new StreamReader(fileStream);
                textBox1.Text = streamReader.ReadToEnd();
                fileStream.Close();
                streamReader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                FileStream fileStream = new FileStream(filePath, FileMode.CreateNew);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(textBox1.Text);
                streamWriter.Close();
                fileStream.Close();
            }
        }
    }
}
