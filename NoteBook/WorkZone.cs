using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
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
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, float.Parse(comboBox2.Text));

            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new Font(new FontFamily(comboBox1.Text), richTextBox1.SelectionFont.Size);

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

            if (richTextBox1.RightToLeft == RightToLeft.No)
                richTextBox1.RightToLeft = RightToLeft.Yes; 
            else
                richTextBox1.RightToLeft = RightToLeft.No;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                int wordstartIndex = richTextBox1.Find(textBox1.Text);
                if (wordstartIndex != -1)
                {
                    richTextBox1.Select(wordstartIndex, textBox1.Text.Length);
                    richTextBox1.SelectionStart = wordstartIndex;
                    richTextBox1.Focus();
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionBackColor = MyDialog.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = MyDialog.Color;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
        }


        bool numbList = false;
        private void button12_Click(object sender, EventArgs e)
        {
            string temptext = richTextBox1.SelectedText;

            int SelectionStart = richTextBox1.SelectionStart;
            int SelectionLength = richTextBox1.SelectionLength;

            richTextBox1.SelectionStart = richTextBox1.GetFirstCharIndexOfCurrentLine();
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectedText = "1. ";

            int j = 2;
            for (int i = SelectionStart; i < SelectionStart + SelectionLength; i++)
                if (richTextBox1.Text[i] == '\n')
                {
                    richTextBox1.SelectionStart = i + 1;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.SelectedText = j.ToString() + ". ";
                    j++;
                    SelectionLength += 3;
                }



        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int tempNum;
            if (e.KeyCode == Keys.Enter)
                try
                {
                    if (char.IsDigit(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine()]))
                    {
                        if (char.IsDigit(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 1]) && richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 2] == '.')
                            tempNum = int.Parse(richTextBox1.Text.Substring(richTextBox1.GetFirstCharIndexOfCurrentLine(), 2));
                        else tempNum = int.Parse(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine()].ToString());

                        if (richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 1] == '.' || (char.IsDigit(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 1]) && richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 2] == '.'))
                        {
                            tempNum++;
                            richTextBox1.SelectedText = "\r\n" + tempNum.ToString() + ". ";
                            e.SuppressKeyPress = true;
                        }
                    }
                }
                catch { }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";
            if (saveFile1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
        }
    }
}
