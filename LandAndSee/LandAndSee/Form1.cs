
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandAndSee
{
    public partial class Form1 : Form
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private cFloat _float = new cFloat();
        private cHouse _house = new cHouse();
        private List<String> _gettype = new List<string> { "food", "clothes", "equipment", "machines" };
        private List<int> _typeaccept = new List<int> { 0, 0, 0, 0,0,0 };
        private List<int> _getquantity = new List<int> { 0, 0, 0, 0 };
        private List<int> _getquantitysave = new List<int> { 0, 0, 0, 0 };
        private int mnInstructType, mnInstructQuantity,mnInstructPlace;
        private int mnCarryType, mnCarryQuantity;
        private int mnMode;
        private String msInstruction;
        private int mnHouse;

        private void fUpdateShoppinglist()
        {
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            for (int i = 1; i <= 4; i++)
            {
                sText = _gettype[i - 1] + " = " + Convert.ToString(_getquantity[i - 1]);
                lst1.Items.Add(sText);
            }

        }

        private void fGotlist()
        {
            String sText;

            if (lst2.Items.Count > 0)
            {
                do
                {
                    lst2.Items.RemoveAt(0);
                } while (lst2.Items.Count > 0);
            }

            if (mnCarryType == 0)
            {


            }
            else
            {
                sText = _gettype[mnCarryType - 1] + " = " + Convert.ToString(mnCarryQuantity);
                lst2.Items.Add(sText);

            }
        }
        private void fShoppinglist()
        {
            Random rnd1 = new Random();
            String sText;

            if (mnMode == 1)
            {


                for (int i = 1; i <= 4; i++)
                {
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 5)
                    {

                        _getquantity[i - 1] = 0;

                    }
                    else
                    {
                        _getquantity[i - 1] = rnd1.Next(4, 21);

                    }
                    _getquantitysave[i - 1] = _getquantity[i - 1];
                }

                if (lst1.Items.Count > 0)
                {
                    do
                    {
                        lst1.Items.RemoveAt(0);
                    } while (lst1.Items.Count > 0);
                }

                for (int i = 1; i <= 4; i++)
                {
                    sText = _gettype[i - 1] + " = " + Convert.ToString(_getquantity[i - 1]);
                    lst1.Items.Add(sText);
                }
            }
            else
            {
                if (lst1.Items.Count > 0)
                {
                    do
                    {
                        lst1.Items.RemoveAt(0);
                    } while (lst1.Items.Count > 0);
                }

                for (int i = 1; i <= 4; i++)
                {
                    sText = _gettype[i - 1] + " = " + Convert.ToString(_getquantitysave[i - 1]);
                    lst1.Items.Add(sText);
                }

            }
        }

        private void fInstruction()
        {
            Random rnd1 = new Random();
            String sText;
            char sLetter;

            if (mnMode == 1)
            {


                mnInstructType = rnd1.Next(1, 5);
                mnInstructQuantity = rnd1.Next(4, 21);
                mnInstructPlace = rnd1.Next(1, 7);
                sLetter = (char)(mnInstructPlace + 64);

                sText = "Get " + _gettype[mnInstructType - 1] + " x" + Convert.ToString(mnInstructQuantity) + " from Box" + sLetter;
                txtInstruction.Text = sText;
            }
            else
            {
                txtInstruction.Text = msInstruction;
            }
        }
        private int fType(int nCol, int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _col1[nRow - 1];
                case 2:
                    return _col2[nRow - 1];
                case 3:
                    return _col3[nRow - 1];
                case 4:
                    return _col4[nRow - 1];
                case 5:
                    return _col5[nRow - 1];
                case 6:
                    return _col6[nRow - 1];
                case 7:
                    return _col7[nRow - 1];
                default:
                    return _col8[nRow - 1];
            }
        }
        private void fNav(int nMode)
        {
            int nType;
            int nCol = _float.fGetCol();
            int nRow = _float.fGetRow();
            int nCol2, nRow2;
            int nRotate;
            int nHouse;
            bool bFound = false;

            if (mnMode == 1)
            {


                switch (nMode)
                {
                    case 1:
                        nType = fType(nCol, nRow);
                        if (nType != 9)
                        {
                            return;
                        }
                        nRow -= 1;
                        nRotate = 1;
                        _float.fSet(nCol, nRow, nRotate);
                        fUpdateDisplay();
                        break;
                    case 2:
                        nType = fType(nCol, nRow);
                        if (nCol == 8)
                        {
                            return;
                        }
                        nCol += 1;
                        nRotate = 2;
                        _float.fSet(nCol, nRow, nRotate);
                        fUpdateDisplay();
                        break;
                    case 3:
                        nType = fType(nCol, nRow);
                        if (nType != 9)
                        {
                            return;
                        }
                        if (nRow == 8)
                        {
                            return;
                        }
                        nRow += 1;
                        nRotate = 3;
                        _float.fSet(nCol, nRow, nRotate);
                        fUpdateDisplay();
                        break;
                    default:
                        nType = fType(nCol, nRow);
                        if (nCol == 1)
                        {
                            return;
                        }
                        nCol -= 1;
                        nRotate = 4;
                        _float.fSet(nCol, nRow, nRotate);
                        fUpdateDisplay();
                        break;

                }

                nType = fType(nCol, nRow);
                if (mnCarryType == 0)
                {
                    if (nType == mnInstructPlace)
                    {
                        mnCarryType = mnInstructType;
                        mnCarryQuantity = mnInstructQuantity;
                        fInstruction();
                        fGotlist();
                        return;
                    }
                }
                if (nType == 13)
                {
                    if (mnCarryType != 0)
                    {
                        _getquantity[mnCarryType - 1] -= mnCarryQuantity;
                        mnCarryType = 0;
                        mnCarryQuantity = 0;
                        fUpdateShoppinglist();
                        fGotlist();
                    }
                }

            }
            else
            {
                switch (nMode)
                {
                    case 1:
                        nRow -= 1;
                        nRotate = 1;
                        if (nRow == 0)
                        {
                            return;
                        }
                        _float.fSet(nCol, nRow, nRotate);
                        fUpdateDisplay();
                        break;
                    case 2:
                         nCol += 1;
                        nRotate = 2;
                        if (nCol == 9)
                        {
                            return;
                        }
                        _float.fSet(nCol, nRow, nRotate);
                        fUpdateDisplay();
                        break;
                    case 3:
                        nRow += 1;
                        nRotate = 3;
                        if (nRow == 9)
                        {
                            return;
                        }
                        _float.fSet(nCol, nRow, nRotate);
                        fUpdateDisplay();
                        break;
                    default:
                        nCol -= 1;
                        nRotate = 4;
                        if (nCol == 0)
                        {
                            return;
                        }
                        _float.fSet(nCol, nRow, nRotate);
                        fUpdateDisplay();
                        break;

                }
                nType = fType(nCol, nRow);
                nHouse = 0;
                for (int i = 1; i <= 6; i++)
                {
                    _house.fSet(i);
                    nCol2 = _house.fGetCol();
                    nRow2 = _house.fGetRow();
                    if (nCol2 == nCol)
                    {
                        if (nRow2 == nRow)
                        {
                            bFound = true;
                            nHouse = i;
                            continue;
                        }
                    }
                    if (bFound)
                    {
                        continue;
                    }
                }
                if (nType == 8)
                {
                    msInstruction = "HOUSE accepts " + _gettype[_typeaccept[nHouse - 1] - 1];
                    mnHouse = nHouse;
                }
                else
                {
                    msInstruction = null;
                }
                fInstruction();
            }
        }

        private void fStick(int nCol, int nRow, int nType, int nRotate)
        {
                switch (nCol)
                {
                    case 1:
                        _col1[nRow - 1] = nType;
                        _rotate1[nRow - 1] = nRotate;
                        break;
                    case 2:
                        _col2[nRow - 1] = nType;
                        _rotate2[nRow - 1] = nRotate;
                        break;
                    case 3:
                        _col3[nRow - 1] = nType;
                        _rotate3[nRow - 1] = nRotate;
                        break;
                    case 4:
                        _col4[nRow - 1] = nType;
                        _rotate4[nRow - 1] = nRotate;
                        break;
                    case 5:
                        _col5[nRow - 1] = nType;
                        _rotate5[nRow - 1] = nRotate;
                        break;
                    case 6:
                        _col6[nRow - 1] = nType;
                        _rotate6[nRow - 1] = nRotate;
                        break;
                    case 7:
                        _col7[nRow - 1] = nType;
                        _rotate7[nRow - 1] = nRotate;
                        break;
                    default:
                        _col8[nRow - 1] = nType;
                        _rotate8[nRow - 1] = nRotate;
                        break;
                }
            }

            private void fReset()
        {
            Random rnd1 = new Random();
            int nPos;
            int nCol, nRow, nRotate;
            bool bFound;

            mnMode = 1;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (j == 1)
                    {
                        fStick( i, j, 14, 1);
                    }
                    else
                    {
                        fStick( i, j, 12, 1);
                    }
                }       
            }

            nPos = rnd1.Next(1, 9);
            fStick(nPos,1, 13, rnd1.Next(1, 5));
            for (int i = 2; i <= 8; i++)
            {
                nPos = rnd1.Next(1, 9);
                fStick(nPos, i, 9, rnd1.Next(1, 5));
            }

            for (int i = 1; i <= 6; i++)
            {
                bFound = false;
                do
                {
                    nCol = rnd1.Next(1, 9);
                    nRow = rnd1.Next(2, 9);
                    if (fType(nCol, nRow) == 12)
                    {
                        bFound = true;
                    }

                } while (bFound == false);
                fStick(nCol, nRow, i, rnd1.Next(1, 5));
            }
            nCol = rnd1.Next(1, 9);
            nRow = rnd1.Next(1, 9);
            nRotate = rnd1.Next(1, 5);
            _float.fSet(nCol, nRow, nRotate);

            fShoppinglist();
            fInstruction();
            mnCarryType = 0;
            mnCarryQuantity = 0;
            fGotlist();
        }

        private void fReset2()
        {
            Random rnd1 = new Random();
            int nCol, nRow, nRotate;
            bool bFound;

            mnMode = 2;
            mnHouse = 0;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 5)
                    {
                        fStick(i, j, 10, 1);

                    }
                    else
                    {
                        fStick(i, j, 11, 1);

                    }
                }
            }
            
            for (int i = 1; i <= 6; i++)
            {
                bFound = false;
                do
                {
                    nCol = rnd1.Next(1, 9);
                    nRow = rnd1.Next(2, 9);
                    if (fType(nCol, nRow) != 8)
                    {
                        bFound = true;
                    }

                } while (bFound == false);
                fStick(nCol, nRow, 8, rnd1.Next(1, 5));
                _typeaccept[i - 1] = rnd1.Next(1, 5);
                _house.fSet2(i,nCol,nRow);
                
            }
            nCol = rnd1.Next(1, 9);
            nRow = rnd1.Next(1, 9);
            nRotate = rnd1.Next(1, 5);
            _float.fSet(nCol, nRow, nRotate);

            msInstruction = null;
            fInstruction();
        }

    private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;
            int nCol = _float.fGetCol();
            int nRow = _float.fGetRow();
            int nRotate2 = _float.fGetRotate();

            nType = _col1[0];
            nRotate = _rotate1[0];
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = _col1[1];
            nRotate = _rotate1[1];
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = _col1[2];
            nRotate = _rotate1[2];
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = _col1[3];
            nRotate = _rotate1[3];
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = _col1[4];
            nRotate = _rotate1[4];
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = _col1[5];
            nRotate = _rotate1[5];
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = _col1[6];
            nRotate = _rotate1[6];
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = _col1[7];
            nRotate = _rotate1[7];
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            nType = _col2[0];
            nRotate = _rotate2[0];
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = _col2[1];
            nRotate = _rotate2[1];
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = _col2[2];
            nRotate = _rotate2[2];
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = _col2[3];
            nRotate = _rotate2[3];
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = _col2[4];
            nRotate = _rotate2[4];
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = _col2[5];
            nRotate = _rotate2[5];
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = _col2[6];
            nRotate = _rotate2[6];
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = _col2[7];
            nRotate = _rotate2[7];
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            nType = _col3[0];
            nRotate = _rotate3[0];
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = _col3[1];
            nRotate = _rotate3[1];
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = _col3[2];
            nRotate = _rotate3[2];
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = _col3[3];
            nRotate = _rotate3[3];
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = _col3[4];
            nRotate = _rotate3[4];
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = _col3[5];
            nRotate = _rotate3[5];
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = _col3[6];
            nRotate = _rotate3[6];
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = _col3[7];
            nRotate = _rotate3[7];
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            nType = _col4[0];
            nRotate = _rotate4[0];
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = _col4[1];
            nRotate = _rotate4[1];
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = _col4[2];
            nRotate = _rotate4[2];
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = _col4[3];
            nRotate = _rotate4[3];
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = _col4[4];
            nRotate = _rotate4[4];
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = _col4[5];
            nRotate = _rotate4[5];
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = _col4[6];
            nRotate = _rotate4[6];
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = _col4[7];
            nRotate = _rotate4[7];
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            nType = _col5[0];
            nRotate = _rotate5[0];
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = _col5[1];
            nRotate = _rotate5[1];
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = _col5[2];
            nRotate = _rotate5[2];
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = _col5[3];
            nRotate = _rotate5[3];
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = _col5[4];
            nRotate = _rotate5[4];
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = _col5[5];
            nRotate = _rotate5[5];
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = _col5[6];
            nRotate = _rotate5[6];
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = _col5[7];
            nRotate = _rotate5[7];
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            nType = _col6[0];
            nRotate = _rotate6[0];
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = _col6[1];
            nRotate = _rotate6[1];
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = _col6[2];
            nRotate = _rotate6[2];
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = _col6[3];
            nRotate = _rotate6[3];
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = _col6[4];
            nRotate = _rotate6[4];
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = _col6[5];
            nRotate = _rotate6[5];
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = _col6[6];
            nRotate = _rotate6[6];
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = _col6[7];
            nRotate = _rotate6[7];
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            nType = _col7[0];
            nRotate = _rotate7[0];
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = _col7[1];
            nRotate = _rotate7[1];
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = _col7[2];
            nRotate = _rotate7[2];
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = _col7[3];
            nRotate = _rotate7[3];
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = _col7[4];
            nRotate = _rotate7[4];
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = _col7[5];
            nRotate = _rotate7[5];
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = _col7[6];
            nRotate = _rotate7[6];
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = _col7[7];
            nRotate = _rotate7[7];
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            nType = _col8[0];
            nRotate = _rotate8[0];
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = _col8[1];
            nRotate = _rotate8[1];
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = _col8[2];
            nRotate = _rotate8[2];
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = _col8[3];
            nRotate = _rotate8[3];
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = _col8[4];
            nRotate = _rotate8[4];
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = _col8[5];
            nRotate = _rotate8[5];
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = _col8[6];
            nRotate = _rotate8[6];
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = _col8[7];
            nRotate = _rotate8[7];
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;

            nType = 15;
            nRotate = nRotate2;
            fPeek(nType, nRotate, ref _pic);
            switch (nCol)
            {
                case 1:
                    switch (nRow)
                    {
                        case 1:
                            pic11.Image = _pic.Image;
                            break;
                        case 2:
                            pic12.Image = _pic.Image;
                            break;
                        case 3:
                            pic13.Image = _pic.Image;
                            break;
                        case 4:
                            pic14.Image = _pic.Image;
                            break;
                        case 5:
                            pic15.Image = _pic.Image;
                            break;
                        case 6:
                            pic16.Image = _pic.Image;
                            break;
                        case 7:
                            pic17.Image = _pic.Image;
                            break;
                        default:
                            pic18.Image = _pic.Image;
                            break;
                    }
                    break;
                case 2:
                    switch (nRow)
                    {
                        case 1:
                            pic21.Image = _pic.Image;
                            break;
                        case 2:
                            pic22.Image = _pic.Image;
                            break;
                        case 3:
                            pic23.Image = _pic.Image;
                            break;
                        case 4:
                            pic24.Image = _pic.Image;
                            break;
                        case 5:
                            pic25.Image = _pic.Image;
                            break;
                        case 6:
                            pic26.Image = _pic.Image;
                            break;
                        case 7:
                            pic27.Image = _pic.Image;
                            break;
                        default:
                            pic28.Image = _pic.Image;
                            break;
                    }
                    break;
                case 3:
                    switch (nRow)
                    {
                        case 1:
                            pic31.Image = _pic.Image;
                            break;
                        case 2:
                            pic32.Image = _pic.Image;
                            break;
                        case 3:
                            pic33.Image = _pic.Image;
                            break;
                        case 4:
                            pic34.Image = _pic.Image;
                            break;
                        case 5:
                            pic35.Image = _pic.Image;
                            break;
                        case 6:
                            pic36.Image = _pic.Image;
                            break;
                        case 7:
                            pic37.Image = _pic.Image;
                            break;
                        default:
                            pic38.Image = _pic.Image;
                            break;
                    }
                    break;
                case 4:
                    switch (nRow)
                    {
                        case 1:
                            pic41.Image = _pic.Image;
                            break;
                        case 2:
                            pic42.Image = _pic.Image;
                            break;
                        case 3:
                            pic43.Image = _pic.Image;
                            break;
                        case 4:
                            pic44.Image = _pic.Image;
                            break;
                        case 5:
                            pic45.Image = _pic.Image;
                            break;
                        case 6:
                            pic46.Image = _pic.Image;
                            break;
                        case 7:
                            pic47.Image = _pic.Image;
                            break;
                        default:
                            pic48.Image = _pic.Image;
                            break;
                    }
                    break;
                case 5:
                    switch (nRow)
                    {
                        case 1:
                            pic51.Image = _pic.Image;
                            break;
                        case 2:
                            pic52.Image = _pic.Image;
                            break;
                        case 3:
                            pic53.Image = _pic.Image;
                            break;
                        case 4:
                            pic54.Image = _pic.Image;
                            break;
                        case 5:
                            pic55.Image = _pic.Image;
                            break;
                        case 6:
                            pic56.Image = _pic.Image;
                            break;
                        case 7:
                            pic57.Image = _pic.Image;
                            break;
                        default:
                            pic58.Image = _pic.Image;
                            break;
                    }
                    break;
                case 6:
                    switch (nRow)
                    {
                        case 1:
                            pic61.Image = _pic.Image;
                            break;
                        case 2:
                            pic62.Image = _pic.Image;
                            break;
                        case 3:
                            pic63.Image = _pic.Image;
                            break;
                        case 4:
                            pic64.Image = _pic.Image;
                            break;
                        case 5:
                            pic65.Image = _pic.Image;
                            break;
                        case 6:
                            pic66.Image = _pic.Image;
                            break;
                        case 7:
                            pic67.Image = _pic.Image;
                            break;
                        default:
                            pic68.Image = _pic.Image;
                            break;
                    }
                    break;
                case 7:
                    switch (nRow)
                    {
                        case 1:
                            pic71.Image = _pic.Image;
                            break;
                        case 2:
                            pic72.Image = _pic.Image;
                            break;
                        case 3:
                            pic73.Image = _pic.Image;
                            break;
                        case 4:
                            pic74.Image = _pic.Image;
                            break;
                        case 5:
                            pic75.Image = _pic.Image;
                            break;
                        case 6:
                            pic76.Image = _pic.Image;
                            break;
                        case 7:
                            pic77.Image = _pic.Image;
                            break;
                        default:
                            pic78.Image = _pic.Image;
                            break;
                    }
                    break;
                default:
                    switch (nRow)
                    {
                        case 1:
                            pic81.Image = _pic.Image;
                            break;
                        case 2:
                            pic82.Image = _pic.Image;
                            break;
                        case 3:
                            pic83.Image = _pic.Image;
                            break;
                        case 4:
                            pic84.Image = _pic.Image;
                            break;
                        case 5:
                            pic85.Image = _pic.Image;
                            break;
                        case 6:
                            pic86.Image = _pic.Image;
                            break;
                        case 7:
                            pic87.Image = _pic.Image;
                            break;
                        default:
                            pic88.Image = _pic.Image;
                            break;
                    }
                    break;
            }

        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F boxA.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F boxB.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F boxC.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F boxD.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F boxE.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F boxF.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F emptybox.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F house.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F ladder.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F land1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F land2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F lowerdeck.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F thetop.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F upperdeck.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                case 12:
                    _pic2 = picture12;
                    break;
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                default:
                    _pic2 = picture16;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();

        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            fNav(1);
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst2_MouseUp(object sender, MouseEventArgs e)
        {
            if (mnCarryType != 0)
            {
                _getquantity[mnCarryType - 1] -= mnCarryQuantity;
                mnCarryType = 0;
                mnCarryQuantity = 0;
                fGotlist();
                fUpdateShoppinglist();
            }

        }

        private void btnMoveon_Click(object sender, EventArgs e)
        {
            bool bFound = false; 

            for (int i = 1; i <= 4; i++)
            {
                if (_getquantity[i - 1] > 0)
                {
                    bFound = true;
                    continue;
                }
            }

            if (bFound == false)
            {
                fReset2();
                fUpdateDisplay();

            }
        }

        private void btnReroll_Click(object sender, EventArgs e)
        {
            fReset2();
            fUpdateDisplay();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            int nQuantity;

            for (int i = 1; i <= 4; i++)
            {
                nQuantity = _getquantitysave[i - 1];
                if (nQuantity != 0)
                {
                    if (i== _typeaccept[mnHouse - 1])
                    {
                        _getquantitysave[i - 1] = 0;
                    }
                }
            }
            fInstruction();
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            bool bFound = false;

            for (int i = 1; i <= 4; i++)
            {
                if (_getquantitysave[i - 1] != 0)
                {
                    bFound = true;
                    continue;
                }
            }

            if (bFound == false)
            {
                fReset();
                fUpdateDisplay();
            }
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            fNav(2);
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            fNav(3);
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            fNav(4);
        }
    }
}
