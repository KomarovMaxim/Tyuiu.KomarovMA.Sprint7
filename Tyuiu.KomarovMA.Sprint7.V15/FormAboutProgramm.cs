using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KomarovMA.Sprint7.V15
{
    public partial class FormAboutProgramm : Form
    {
        public FormAboutProgramm()
        {
            InitializeComponent();
        }

        private void buttonOK_KMA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
