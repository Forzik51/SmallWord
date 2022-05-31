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
    public partial class New : Form
    {
        public New()
        {
            
            InitializeComponent();
            this.ShowInTaskbar = true;
            this.StartPosition = FormStartPosition.CenterScreen;



        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Menu.StartWork();
            //this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
