using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARH
{
    public partial class Form1 : Form
    {
        private List<int> _value = new List<int> { 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 3; i++)
            {
                _value[i - 1] = rnd1.Next(1, 4);
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            btnBar11.BackColor = Color.Yellow;
            btnBar12.BackColor = Color.Yellow;
            btnBar13.BackColor = Color.Yellow;
            btnBar21.BackColor = Color.Yellow;
            btnBar22.BackColor = Color.Yellow;
            btnBar23.BackColor = Color.Yellow;
            btnBar31.BackColor = Color.Yellow;
            btnBar32.BackColor = Color.Yellow;
            btnBar33.BackColor = Color.Yellow;

            switch (_value[0])
            {
                case 1:
                    btnBar11.BackColor = Color.Red;
                    break;
                case 2:
                    btnBar12.BackColor = Color.Red;
                    break;
                default:
                    btnBar13.BackColor = Color.Red;
                    break;
            }
            switch (_value[1])
            {
                case 1:
                    btnBar21.BackColor = Color.Red;
                    break;
                case 2:
                    btnBar22.BackColor = Color.Red;
                    break;
                default:
                    btnBar23.BackColor = Color.Red;
                    break;
            }
            switch (_value[2])
            {
                case 1:
                    btnBar31.BackColor = Color.Red;
                    break;
                case 2:
                    btnBar32.BackColor = Color.Red;
                    break;
                default:
                    btnBar33.BackColor = Color.Red;
                    break;
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnBar11_Click(object sender, EventArgs e)
        {
            _value[0] = 1;
            fUpdateDisplay();
        }

        private void btnBar12_Click(object sender, EventArgs e)
        {
            _value[0] = 2;
            fUpdateDisplay();

        }

        private void btnBar13_Click(object sender, EventArgs e)
        {
            _value[0] = 3;
            fUpdateDisplay();

        }

        private void btnBar21_Click(object sender, EventArgs e)
        {
            _value[1] = 1;
            fUpdateDisplay();

        }

        private void btnBar22_Click(object sender, EventArgs e)
        {
            _value[1] = 2;
            fUpdateDisplay();

        }

        private void btnBar23_Click(object sender, EventArgs e)
        {
            _value[1] = 3;
            fUpdateDisplay();

        }

        private void btnBar31_Click(object sender, EventArgs e)
        {
            _value[2] = 1;
            fUpdateDisplay();

        }

        private void btnBar32_Click(object sender, EventArgs e)
        {
            _value[2] = 2;
            fUpdateDisplay();

        }

        private void btnBar33_Click(object sender, EventArgs e)
        {
            _value[2] = 3;
            fUpdateDisplay();

        }
    }
}
