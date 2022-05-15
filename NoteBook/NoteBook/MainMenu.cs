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
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownLoad newForm = new DownLoad();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            New newForm = new New();
            newForm.Show();

        }
    }
}
