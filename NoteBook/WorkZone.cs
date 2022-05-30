using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class WorkZone : Form
    {
        public WorkZone()
        {
            
            InitializeComponent();
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                comboBox1.Items.Add(font.Name);
            }
            //MainMenu mainMenu = new MainMenu();
            //mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach(char c in richTextBox1.SelectedText)
            //    if(c.ToString(). == FontStyle.Bold)
            //if(richTextBox1.SelectionFont( x => x.) != FontStyle.Bold)
            richTextBox1.SelectionFont = new Font(richTextBox1.Font,
            richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.Name, float.Parse(comboBox2.Text));

            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new Font(new FontFamily(comboBox1.Text), richTextBox1.Font.Size);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            //richTextBox1.SelectedText = Ho
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                int wordstartIndex = richTextBox1.Find(textBox1.Text);
                if (wordstartIndex != -1)
                {
                    richTextBox1.Select(wordstartIndex, textBox1.Text.Length);
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }
            }
        }
    }
}
