using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DATB
{
    public partial class fSub3 : Form
    {
        private cTypical3 _data3 = new cTypical3();
        private int mnCount;
        private List<String> _colname1 = new List<String> { "nIndex", "sItem", "sReturnValue" };
        private List<String> _colname2 = new List<String> { "nIndex", "sItem", "sReturnValue" };
        private List<String> _colname3 = new List<String> { "nIndex", "sItem", "sReturnValue" };
         private List<int> _count = new List<int> { 0, 0, 0 };
        private List<String> _list = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private int mnItem;
        private int mnMode, mnCols;

        private void fFLoad()
        {
            String sName = txtFName.Text + Convert.ToString(mnMode) + ".txt";
            String sLine;
            int nCount;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {

                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    _count[mnMode - 1] = 0;
                    nCount = 0;
                    do
                    {
                        sLine = sr.ReadLine();
                        if (sLine == "END")
                        {
                            continue;
                        }
                        nCount += 1;
                        _list[nCount - 1] = sLine;
                    } while (sLine != "END");
                    _count[mnMode - 1] = nCount;
                }

                fReset();
                fUpdateDisplay();

            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

        }

        private void fFSave()
        {
            String sName = txtFName.Text + Convert.ToString(mnMode) + ".txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {

                file.WriteLine("LIST");
                for (int i = 1; i <= lstDatabase.Items.Count; i++)
                {
                    _list[i - 1] = (String)lstDatabase.Items[i - 1];
                    file.WriteLine(_list[i - 1]);
                }
                file.WriteLine("END");
            }

        }


        private void fReset()
        {
            mnCount = 0;
            mnItem = 0;

            txtEdit1.Text = null;
            txtEdit2.Text = null;
            txtEdit3.Text = null;
            switch (mnMode)
            {
                case 1:
                    lblEdit1.Text = _colname1[0];
                    lblEdit2.Text = _colname1[1];
                    lblEdit3.Text = _colname1[2];
                    break;
                case 2:
                    lblEdit1.Text = _colname2[0];
                    lblEdit2.Text = _colname2[1];
                    lblEdit3.Text = _colname2[2];
                    break;
                default:
                    lblEdit1.Text = _colname3[0];
                    lblEdit2.Text = _colname3[1];
                    lblEdit3.Text = _colname3[2];
                    break;
             }


            if (lstDatabase.Items.Count > 0)
            {
                do
                {
                    lstDatabase.Items.RemoveAt(0);
                } while (lstDatabase.Items.Count > 0);
            }
        }

        private void fUpdateDisplay()
        {
            if (lstDatabase.Items.Count > 0)
            {
                do
                {
                    lstDatabase.Items.RemoveAt(0);
                } while (lstDatabase.Items.Count > 0);
            }
            for (int i = 1; i <= _count[mnMode - 1]; i++)
            {
                lstDatabase.Items.Add(_list[i - 1]);
            }
        }

        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            mnMode = 1;
            fReset();
            fFLoad();
            fUpdateDisplay();
        }



        private void btnMode1_Click(object sender, EventArgs e)
        {
            mnMode = 1;
            fReset();
            fFLoad();
            fUpdateDisplay();
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            mnMode = 2;
            fReset();
            fFLoad();
            fUpdateDisplay();

        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            mnMode = 3;
            fReset();
            fFLoad();
            fUpdateDisplay();

        }

        private void btnMode4_Click(object sender, EventArgs e)
        {
            mnMode = 4;
            fReset();
            fFLoad();
            fUpdateDisplay();

        }


        private void btnEdit2_Click(object sender, EventArgs e)
        {
            txtEdit1.Text = null;
            txtEdit2.Text = null;
            txtEdit3.Text = null;

        }

        private void btnDatabase1_Click(object sender, EventArgs e)
        {
            String sText = null;
            String sCol;

            if (lstDatabase.Items.Count >= mnItem)
            {
                if (mnItem != 0)
                {

                    _data3.fSet(mnItem);
                    for (int i = 1; i <= 3; i++)
                    {
                        switch (mnMode)
                        {
                            case 1:
                                sCol = _colname1[i - 1];
                                break;
                            case 2:
                                sCol = _colname2[i - 1];
                                break;
                            default:
                                sCol = _colname3[i - 1];
                                break;
                        }
                        sText = sText + sCol + "=" + _data3.fGetCol(i - 1) + ", ";
                    }
                }

                MessageBox.Show(sText, "Inspect");
            }

        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            String sText = null;
            String sCol;

            mnCount += 1;
            mnCols = 3;
            _data3.fSet2(mnCount, txtEdit1.Text, txtEdit2.Text, txtEdit3.Text);
            for (int i = 1; i <= mnCols; i++)
            {
                sCol = _colname1[i - 1];
                sText = sText + sCol + "=" + _data3.fGetCol(i - 1) + ", ";
            }
            lstDatabase.Items.Add(sText);
        }

        private void btnDatabase2_Click(object sender, EventArgs e)
        {
            lstDatabase.Items.RemoveAt(_count[mnMode - 1] - 1);
            mnCount -= 1;

        }

        private void btnDatabase3_Click(object sender, EventArgs e)
        {
            mnCount = 0;
            lstDatabase.Items.Clear();

        }

             private void lstDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lstDatabase.SelectedIndex + 1;

        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            fFSave();

        }

        private void lOADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReset();
            fFLoad();
            fUpdateDisplay();

        }



    }
}


