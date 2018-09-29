using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QDRT
{
    public partial class fS1 : Form
    {
        public fS1()
        {
            InitializeComponent();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            fS16 _dlg = new fS16();
            _dlg.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            fS17 _dlg = new fS17();
            _dlg.ShowDialog();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            fS18 _dlg = new fS18();
            _dlg.ShowDialog();

        }
    }
}
