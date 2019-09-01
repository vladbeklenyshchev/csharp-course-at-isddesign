using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationPractise1
{
    public partial class ModalWindow : Form
    {
        public ModalWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModalWindow2 modalForm2 = new ModalWindow2();
            modalForm2.ShowDialog();
        }
    }
}
