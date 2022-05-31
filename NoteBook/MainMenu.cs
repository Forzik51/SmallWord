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
    public partial class MainMenu : Form
    {
       
        public MainMenu()
        {
            Program.Menu = this;
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownLoad newForm = new DownLoad();
            newForm.Show();
        }
        public void StartWork()
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartWork();

            //New newForm = new New(/*this.StartWork*/);
            //newForm.Show();

        }
    }
}
