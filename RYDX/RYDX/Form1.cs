using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RYDX
{
    public partial class Form1 : Form
    {
        private int mnLength;
        private int nNumber;
        private String msText1, msText2;
        private String sExamine = null;
        private int nLathe = 1;
        private String sReturn = null;
        private String sSpill = null;
        private int nPos;
        private bool mbDone1,mbDone2;
        private List<String> _command1 = new List<string> { "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL" };
        private List<String> _command2 = new List<string> { "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL" };
        private List<String> _play1 = new List<string> { "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL" };
        private List<String> _play2 = new List<string> { "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL" };
        private int mnItem, mnList;


        private int fJuggle(ref String sText,ref String sReturn)
        {
            Random rnd1 = new Random();
            int nLength;
            int nPos;
            String sText2;
            int nCount = 0;

            sReturn = null;
            do
            {
                nCount += 1;
                nLength = sText.Length / 2;
                if (nLength == 0)
                {
                    continue;
                }
                nPos = rnd1.Next(1, nLength + 1);
                nNumber = rnd1.Next(1, 10);
                if (nCount > 1)
                {
                    if (nNumber <= 2)
                    {
                        return nPos;
                    }
                }
                sText2 = sText.Substring(nPos * 2 - 2, 2);
                sReturn = sReturn + sText2;
                sText = sText.Substring(0, nPos * 2 - 2) + sText.Substring(nPos*2, (nLength - nPos) * 2);
            } while (nLength != 0);

            return 0;
        }

        private int fTake(ref String sText, int nPos)
        {
            String sReturn = sText.Substring(nPos * 2 - 2, 2);
            int nLength = sText.Length / 2;
            int nValue;

            sText = sText.Substring(0, nPos * 2 - 2) + sText.Substring(nPos * 2, (nLength - nPos) * 2);

            nValue = Convert.ToInt32(sReturn);
            return nValue;
        }

        private int fValue(String sText,int nPos)
        {
            String sReturn = sText.Substring(nPos * 2 - 2, 2);

            return Convert.ToInt32(sReturn);
        }

        private void fRNext(String sText1,String sText2,ref bool bAbort)
        {
            String sSave1 = sText1;
            String sSave2 = sText2;
            int nValue;

            bAbort = false;

            if (mbDone1 == true)
            {
                if (mbDone2 == true)
                {
                    MessageBox.Show("Finished!");
                    bAbort = true;
                    fUpdateDisplay2();
                    return;
                }
            }

            sSpill = null;
            if (nPos == 0)
            {
                if (nLathe == 1)
                {
                    mbDone2 = true;
                }
                else
                {
                    mbDone1 = true;
                }
                if (nLathe == 1)
                {
                    sExamine = msText1;
                }
                else
                {
                    sExamine = msText2;
                }
                fFinish(ref sExamine);
                if (nLathe == 1)
                {
                    fUpdateLathe1(sExamine);
                    fUpdateDisplay();
                }
                else
                {
                    fUpdateLathe2(sExamine);
                    fUpdateDisplay();
                }
                if (nLathe == 1)
                {
                    sSpill = sSpill + "[A]";
                }
                else
                {
                    sSpill = sSpill + "[B]";
                
                 }
                sSpill = sSpill + sExamine;

                txtPath.Text = txtPath.Text+sSpill;
                if (nLathe == 1)
                {
                    msText1 = null;
                    txtText1.Text = msText1;
                    mbDone1 = true;
                }
                else
                {
                    msText2 = null;
                    txtText2.Text = msText2;
                    mbDone2 = true;
                }
                return;
            }

            if (nLathe == 1)
            {
                sExamine = msText1;
            }
            else
            {
                sExamine = msText2;
            }
            if (nPos > sExamine.Length / 2)
            {
                nPos = sExamine.Length / 2;
            }
            nValue = fTake(ref sExamine, nPos);
             if (nLathe == 1)
            {
                _command1[nPos - 1] = "CATCH"+Convert.ToString(nValue);
                 fUpdateDisplay();
            }
            else
            {
                _command2[nPos - 1] = "CATCH" + Convert.ToString(nValue);
                fUpdateDisplay();
            }
             if (nLathe == 1)
            {
                sSpill = sSpill + "[A]";
            }
            else
            {
                sSpill = sSpill + "[B]";

            }
            sSpill = sSpill + Convert.ToString(nValue) + " - ";

            nPos = fJuggle(ref sExamine, ref sReturn);
            if (nLathe == 1)
            {
                fUpdateLathe1(sReturn);
                fUpdateDisplay();
            }
            else
            {
                fUpdateLathe2(sReturn);
                fUpdateDisplay();
            }
            if (nLathe == 1)
            {
                sSpill = sSpill + "[A]";
            }
            else
            {
                sSpill = sSpill + "[B]";

            }
            sSpill = sSpill + sReturn + " - ";
            

            if (nLathe == 1)
            {
                msText1 = sExamine;
                txtText1.Text = msText1;
                sSave1 = sExamine;
                nLathe = 2;
                sExamine = sSave2;
             }
            else
            {
                msText2 = sExamine;
                txtText2.Text = msText2;
                sSave2 = sExamine;
                nLathe = 1;
                sExamine = sSave1;
            }
         
            txtText1.Text = msText1;
            txtText2.Text = msText2;
            txtPath.Text = txtPath.Text + sSpill;
        }
        private void fUpdateLathe1(String sReturn)
        {
            int nLength = sReturn.Length / 2;
            String sTwo;
            int nValue1,nValue2;

            for (int i = 1; i <= nLength-1; i++)
            {
                sTwo = sReturn.Substring(i * 2 - 2, 2);
                nValue1 = Convert.ToInt32(sTwo);
                sTwo = sReturn.Substring(i * 2 , 2);
                nValue2 = Convert.ToInt32(sTwo);
                _command1[nValue1 - 1] = "GOTO " + Convert.ToString(nValue2);
            }
            sTwo = sReturn.Substring(nLength*2-2, 2);
            nValue1 = Convert.ToInt32(sTwo);
            _command1[nValue1 - 1] = "OPP* ";
        }


        private void fUpdateLathe2(String sReturn)
        {
            int nLength = sReturn.Length / 2;
            String sTwo;
            int nValue1, nValue2;

            for (int i = 1; i <= nLength - 1; i++)
            {
                sTwo = sReturn.Substring(i * 2 - 2, 2);
                nValue1 = Convert.ToInt32(sTwo);
                sTwo = sReturn.Substring(i * 2 , 2);
                nValue2 = Convert.ToInt32(sTwo);
                _command2[nValue1 - 1] = "GOTO " + Convert.ToString(nValue2);
            }
            sTwo = sReturn.Substring(nLength * 2 - 2, 2);
            nValue1 = Convert.ToInt32(sTwo);
            _command2[nValue1 - 1] = "OPP* ";
        }

        private void fUpdatePlay(int nList,int nItem)
        {
            if (nList == 1)
            {
                _play1[nItem - 1] = "PLAYED";
            }
            else
            {
                _play2[nItem - 1] = "PLAYED";
            }
            fUpdateDisplay2();
        }

        private void fRun()
        {
            Random rnd1 = new Random();
            String sSave1 = msText1;
            String sSave2 = msText2;
            int nLength = mnLength;
            bool bAbort = false;

            if (lstA.Items.Count > 0)
            {
                do
                {
                    lstA.Items.RemoveAt(0);
                } while (lstA.Items.Count > 0);
            }
            fUpdateDisplay();
            fUpdateDisplay2();
            txtPath.Text = null;
            txtText1.Text = msText1;
            txtText2.Text = msText2;
            nLathe = 1;
            nPos = rnd1.Next(1, nLength + 1);
            _command1[nPos - 1] = "START";
            sSpill = null;
            mbDone1 = false;
            mbDone2 = false;
            fRNext(msText1, msText2,ref bAbort);
  }

        private bool fTakeout(ref String sText,ref String sReturn,int nNumber)
        {
            int nLength = sText.Length / 2;
             String sNumber = Convert.ToString(nNumber);

             sReturn = sText.Substring(nNumber * 2 - 2, 2);
            sText = sText.Substring(0, nNumber * 2 - 2) + sText.Substring(nNumber * 2, (nLength - nNumber) * 2);

            return true;
        }

        private void fUpdateDisplay()
        {
            String sText;

            if (lstA.Items.Count > 0)
            {
                do
                {
                    lstA.Items.RemoveAt(0);
                } while (lstA.Items.Count > 0);
            }
            if (lstB.Items.Count > 0)
            {
                do
                {
                    lstB.Items.RemoveAt(0);
                } while (lstB.Items.Count > 0);
            }

            for (int i = 1; i <= mnLength; i++)
            {
                sText = "[" + Convert.ToString(i) + "] = " + _command1[i - 1];
                lstA.Items.Add(sText);
            }
            for (int i = 1; i <= mnLength; i++)
            {
                sText = "[" + Convert.ToString(i) + "] = " + _command2[i - 1];
                lstB.Items.Add(sText);
            }
        }
        private void fUpdateDisplay2()
        {
            String sText;

            if (lstPlayA.Items.Count > 0)
            {
                do
                {
                    lstPlayA.Items.RemoveAt(0);
                } while (lstPlayA.Items.Count > 0);
            }
            if (lstPlayB.Items.Count > 0)
            {
                do
                {
                    lstPlayB.Items.RemoveAt(0);
                } while (lstPlayB.Items.Count > 0);
            }

            for (int i = 1; i <= mnLength; i++)
            {
                sText = "[" + Convert.ToString(i) + "] = " + _command1[i - 1] + " = " + _play1[i - 1];
                lstPlayA.Items.Add(sText);
            }
            for (int i = 1; i <= mnLength; i++)
            {
                sText = "[" + Convert.ToString(i) + "] = " + _command2[i - 1] + " = " + _play2[i - 1];
                lstPlayB.Items.Add(sText);
            }
        }

        private void fFinish(ref String sExamine)
        {
            Random rnd1 = new Random();
            int nLength,nPos;
            String sText = sExamine;
            String sText2;
            String sReturn = null;

            do
            {
                nLength = sText.Length / 2;
                if (nLength == 0)
                {
                    continue;
                }
                nPos = rnd1.Next(1, nLength + 1);
                sText2 = sText.Substring(nPos * 2 - 2, 2);
                sReturn = sReturn + sText2;
                sText = sText.Substring(0, nPos * 2 - 2) + sText.Substring(nPos * 2, (nLength - nPos) * 2);
            } while (nLength != 0);

            sExamine = sReturn;
        }
        private void fReset()
        {
            String sText1,sText2, sTwo;

            mnLength = 18;
            mnItem = 0;
            mnList = 0;

            for (int i = 1; i <= mnLength; i++)
            {
                _command1[i - 1] = "NULL";
                _command2[i - 1] = "NULL";
                _play1[i - 1] = "NULL";
                _play2[i - 1] = "NULL";

            }
            sText1 = null;
            for (int i = 1; i <= mnLength; i++)
            {
                sTwo = Convert.ToString(i);
                if(sTwo.Length == 1)
                {
                    sTwo = sTwo + " ";
                }
                sText1 = sText1 + sTwo;
            }
            sText2 = null;
            for (int i = 1; i <= mnLength; i++)
            {
                sTwo = Convert.ToString(i);
                if (sTwo.Length == 1)
                {
                    sTwo = sTwo + " ";
                }
                sText2 = sText2 + sTwo;
            }

            msText1 = sText1;
            msText2 = sText2;


        }
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnRAll_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

            do
            {
                fRNext(msText1, msText2, ref bAbort);
            } while (bAbort == false);  
        }

        private void lstPlayA_Click(object sender, EventArgs e)
        {
            mnItem = lstPlayA.SelectedIndex + 1;
            mnList = 1;
            fUpdatePlay(mnList, mnItem);

        }

        private void lstPlayB_Click(object sender, EventArgs e)
        {
            mnItem = lstPlayB.SelectedIndex + 1;
            mnList = 2;
            fUpdatePlay(mnList, mnItem);

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
                fReset();
                fRun();

            }

            private void btnRNext_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

            fRNext(msText1, msText2,ref bAbort);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
            fRun();
        }
    }
}
