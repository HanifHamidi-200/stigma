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
    public partial class fSub2 : Form
    {
        private bool mbNull;
        private List<String> _top = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _bottom = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private String sFName;
        private int nFNumber;
        private int mnRecord,mnCount;
        private int nScore;

        public fSub2()
        {
            InitializeComponent();
            nScore = 0;
            lblScore.Text = "Score = 0";
        }
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

        private void fDatabase(String sName, ref bool bError)
        {
            int nCount = 0;
            String sLine;
            String sText;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    do
                    {
                        sLine = sr.ReadLine();
                        if (sLine.Length >= 4)
                        {
                            sText = sLine.Substring(0, 4);
                        }
                        else
                        {
                            sText = null;
                        }
                        if (sText == "LIST")
                        {
                         }
                        else
                        {
                            nCount += 1;
                            _top[nCount - 1] = sLine;
                        }
                    } while (sText != "LIST");
                    mnCount = nCount;
                    if (nFNumber == 1)
                    {
                        for (int i = 1; i <= mnCount; i++)
                        {
                            _bottom[i - 1] = _top[i - 1];
                        }
                        bError = false;
                        return;
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = sr.ReadLine();
                        _top[i - 1] = sLine;
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        _bottom[i - 1] = _top[i - 1];
                    }
                }
                bError = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! = " + ex);
                bError = true;
            }
        }


        private void fUpdateDisplay()
        {
            lblTry.Text = "Try " + Convert.ToString(mnRecord);
            txtInput.Text = null;
        }

        private void fCheck()
        {
            if (txtInput.Text == _bottom[mnRecord - 1])
            {
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                mnRecord += 1;
                if (mnRecord > mnCount)
                {
                    mnRecord = 1;
                }
                fUpdateDisplay();
            }
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            int _char = Convert.ToInt32(e.KeyCode);

            if (_char == 13)
            {
                fCheck();
            }
        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
          
                mbNull = true;
                nFNumber = 1;
                fDatabaseNull();
         
                mnRecord = rnd1.Next(1, mnCount);
                fUpdateDisplay();


        }

        private void lblClue1_Click(object sender, EventArgs e)
        {

        }

        private void btnClue_Click(object sender, EventArgs e)
        {
            int nPrev = mnRecord - 1;
            int nNext = mnRecord + 1;
         
            if (nPrev == 0)
            {
                nPrev = mnCount;
            }
            if (nNext > mnCount)
            {
                nNext = 1;
            }

            lblClue1.Text = "PREV = " + _bottom[nPrev - 1];
            lblClue2.Text = "NEXT = " + _bottom[nNext - 1];

        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            bool bError = false;
        
            if (txtDatabaseName.Text == null)
            {
                mbNull = true;
            }
            else
            {
                mbNull = false;
                sFName = txtDatabaseName.Text;
            }
            if (txtDatabaseNumber.Text == null)
            {
                nFNumber = 1;
            }
            else
            {
                nFNumber = Convert.ToInt32(txtDatabaseNumber.Text);
            }
            if (mbNull)
            {
                fDatabaseNull();
            }
            else
            {
                fDatabase(sFName, ref bError);
            }

            if (bError == false)
            {
                mnRecord = rnd1.Next(1, mnCount);
                fUpdateDisplay();

            }
        }
    }
}
