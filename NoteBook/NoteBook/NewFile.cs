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
  
        }

        private void New_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu newForm = new MainMenu();
            newForm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkZone newForm = new WorkZone();
            newForm.Show();
            Close();
        }
    }
}
