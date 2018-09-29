using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAVOC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }

        private void btnOpen4_Click(object sender, EventArgs e)
        {
            fSub4 _dlg = new fSub4();
            _dlg.ShowDialog();

        }

        private void btnOpenR_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nMode = rnd1.Next(1, 5);

            switch (nMode)
            {
                case 1:
                    fSub1 _dlg1 = new fSub1();
                    _dlg1.ShowDialog();
                    break;
                case 2:
                    fSub2 _dlg2 = new fSub2();
                    _dlg2.ShowDialog();
                    break;
                case 3:
                    fSub3 _dlg3 = new fSub3();
                    _dlg3.ShowDialog();
                    break;
                default:
                    fSub4 _dlg4 = new fSub4();
                    _dlg4.ShowDialog();
                    break;
            }

        }
    }
}
