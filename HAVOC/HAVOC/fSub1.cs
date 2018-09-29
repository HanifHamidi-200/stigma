using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAVOC
{
    public partial class fSub1 : Form
    {
        private int mnCount;
        private List<String> _top = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null , null, null, null, null, null, null, null, null, null, null };
        private List<String> _bottom = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null , null, null, null, null, null, null, null, null, null, null };
        private bool mbNull = true;
        private String sFName=null;
        private int mnRecord;
        private bool bHide1, bHide2, bHide3, bHide4;
        private bool mbRed;
        private int nScore;

        private void fDatabaseNull()
        {
            mnCount = 7;
            _top[0] = "sent";
            _bottom[0] = "forth";
            _top[1] = "come";
            _bottom[1] = "back";
            _top[2] = "do";
            _bottom[2] = "anyway";
            _top[3] = "pull";
            _bottom[3] = "now";
            _top[4] = "push";
            _bottom[4] = "afterwards";
            _top[5] = "gain";
            _bottom[5] = "height";
            _top[6] = "be";
            _bottom[6] = "square";

        }

        private void fDatabase(String sName,ref bool bError)
        {
            int nCount = 0;
            String sLine;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    do
                    {
                        sLine = sr.ReadLine();
                        if (sLine == "LIST2")
                        {
                            continue;
                        }
                        nCount += 1;
                        _top[nCount - 1] = sLine;
                    } while (sLine != "LIST2");
                    mnCount = nCount;
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = sr.ReadLine();
                        _bottom[i - 1] = sLine;
                    }
                }
                bError = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! = "+ex);
                bError = true;
            }
        }

        private void btnCard1_Click(object sender, EventArgs e)
        {
            if (mbRed)
            {     
                mbRed = false;
                btnCard1.BackColor = Color.Red;
                return;
            }
              if (bHide1)
            {
                bHide1 = false;
                txtHide1.Visible = false;
            }
            else
            {
                bHide1 = true;
                txtHide1.Visible = true;
            }
            fUpdateDisplay();
        }

        private void btnCard2_Click(object sender, EventArgs e)
        {
            if (mbRed)
            {
                mbRed = false;
                btnCard2.BackColor = Color.Red;
                return;
            }
            if (bHide2)
            {
                bHide2 = false;
                txtHide2.Visible = false;
            }
            else
            {
                bHide2 = true;
                txtHide2.Visible = true;
            }
            fUpdateDisplay();

        }

        private void btnCard3_Click(object sender, EventArgs e)
        {
            if (mbRed)
            {
                mbRed = false;
                btnCard3.BackColor = Color.Red;
                return;
            }
             if (bHide3)
            {
                bHide3 = false;
                txtHide3.Visible = false;
            }
            else
            {
                bHide3 = true;
                txtHide3.Visible = true;
            }
            fUpdateDisplay();

        }

        private void btnCard4_Click(object sender, EventArgs e)
        {
            if (mbRed)
            {
                mbRed = false;
                btnCard4.BackColor = Color.Red;
                return;
            }
                if (bHide4)
            {
                bHide4 = false;
                txtHide4.Visible = false;
            }
            else
            {
                bHide4 = true;
                txtHide4.Visible = true;
            }
            fUpdateDisplay();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mnRecord == mnCount - 1)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnRecord += 1;
                fUpdateDisplay();
            }
        }

        private void btnSkipNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nLeft = mnCount - mnRecord-1;
            int nAdd;

            if (mnRecord == mnCount - 1)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nAdd = rnd1.Next(1, nLeft-1);
                mnRecord += nAdd;
                fUpdateDisplay();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (mnRecord == 1)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnRecord -= 1;
                fUpdateDisplay();
            }

        }

        private void btnSkipPrevious_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nLeft =  mnRecord-1;
            int nAdd;

            if (mnRecord == 1)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nAdd = rnd1.Next(1, nLeft - 1);
                mnRecord -= nAdd;
                fUpdateDisplay();
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            mbRed = true;
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            mbRed = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnCard1.BackColor = Color.Pink;
            btnCard2.BackColor = Color.Pink;
            btnCard3.BackColor = Color.Pink;
            btnCard4.BackColor = Color.Pink;
        }

        private void fUpdateDisplay()
        {
            String sTop, sBottom;

            sTop = _top[mnRecord - 1];
            if (bHide1)
            {
                sTop = "[HIDE]";
            }
            sBottom = _bottom[mnRecord - 1];
            if (bHide2)
            {
                sBottom = "[HIDE]";
            }
            btnCard1.Text = sTop;
            btnCard2.Text = sBottom;
            sTop = _top[mnRecord ];
            if (bHide3)
            {
                sTop = "[HIDE]";
            }
            sBottom = _bottom[mnRecord ];
            if (bHide4)
            {
                sBottom = "[HIDE]";
            }
            btnCard3.Text = sTop;
            btnCard4.Text = sBottom;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool bFound = false;
            String s1, s2;

            if (bHide1)
            {
                s1 = _top[mnRecord - 1];
                s2 = txtHide1.Text;
                if (s2 != s1)
                {
                    bFound = true;
                }
            }
            if (bHide2)
            {
                s1 = _bottom[mnRecord - 1];
                s2 = txtHide2.Text;
                if (s2 != s1)
                {
                    bFound = true;
                }
            }
            if (bHide3)
            {
                s1 = _top[mnRecord ];
                s2 = txtHide3.Text;
                if (s2 != s1)
                {
                    bFound = true;
                }
            }
            if (bHide4)
            {
                s1 = _bottom[mnRecord ];
                s2 = txtHide4.Text;
                if (s2 != s1)
                {
                    bFound = true;
                }
            }

            if (bFound)
            {
                MessageBox.Show("Something wrong", "Error!");
            }
            else
            {
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
            }
        }

        private void btnCheckClear_Click(object sender, EventArgs e)
        {
            txtHide1.Text = null;
            txtHide2.Text = null;
            txtHide3.Text = null;
            txtHide4.Text = null;

        }

        public fSub1()
        {
            InitializeComponent();
            nScore = 0;
            lblScore.Text = "Score = 0";
        }


        private void btnDatabaseNull_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
         
            bHide1 = false;
            bHide2 = false;
            bHide3 = false;
            bHide4 = false;
            txtHide1.Visible = false;
            txtHide2.Visible = false;
            txtHide3.Visible = false;
            txtHide4.Visible = false;

            mbNull = true;
            fDatabaseNull();

            mnRecord = rnd1.Next(1, mnCount);
            fUpdateDisplay();

            
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            bool bError=false;

            bHide1 = false;
            bHide2 = false;
            bHide3 = false;
            bHide4 = false;
            txtHide1.Visible = false;
            txtHide2.Visible = false;
            txtHide3.Visible = false;
            txtHide4.Visible = false;

            if (txtDatabase.Text == null)
            {
                mbNull = true;
            }
            else
            {
                mbNull = false;
                sFName = txtDatabase.Text;
            }
            if (mbNull)
            {
                fDatabaseNull();
            }
            else
            {
                fDatabase(sFName,ref bError);
            }

            if (bError == false)
            {
                mnRecord = rnd1.Next(1, mnCount);
                fUpdateDisplay();

            }
        }
    }
}

