using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileGetters
{

    public partial class Form1 : Form
    {
        private static List<int> _count = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private String sAnswer1 = null, sAnswer2 = null, sAnswer3 = null;
        private String msPopup1;
        private int mnItem;
        private int nScore;
        private bool mbRotate,mbExpire;
        private int nNumber;

        public Form1()
        {
            InitializeComponent();
            sAnswer1 = null;
            sAnswer2 = null;
            sAnswer3 = null;
            nScore = 0;
            lblScore.Text = "Score = 0";
        }

        private void fChance(String sLetter,int nLetter)
        {
            Random rnd1 = new Random();
      
            if (mbRotate)
            {
                mbRotate = false;
                mbExpire = false;
                 _count[nLetter - 1] += 26;
                if (_count[nLetter - 1] > 104)
                {
                    _count[nLetter - 1] -= 104;
                }

                sLetter = " ";
                sAnswer1 = sAnswer1.Substring(0, nLetter - 1) + sLetter + sAnswer1.Substring(nLetter, 16 - nLetter);
                if (sAnswer1.Substring(nLetter - 1, 1) == sAnswer2.Substring(nLetter - 1, 1))
                {
                    sAnswer3 = sAnswer3.Substring(0, nLetter - 1) + sLetter + sAnswer3.Substring(nLetter, 16 - nLetter);
                    nScore += 10;
                    lblScore.Text = "Score = " + Convert.ToString(nScore);
                }
                lblAnswer1.Text = sAnswer1;
                lblAnswer2.Text = sAnswer3;

                fUpdateDisplay();
                return;
            }
            if (mbExpire)
            {
                mbExpire = false;
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _count[nLetter - 1] = rnd1.Next(1, 105);

                    sLetter = " ";
                    sAnswer1 = sAnswer1.Substring(0, nLetter - 1) + sLetter + sAnswer1.Substring(nLetter, 16 - nLetter);
                    if (sAnswer1.Substring(nLetter - 1, 1) == sAnswer2.Substring(nLetter - 1, 1))
                    {
                        sAnswer3 = sAnswer3.Substring(0, nLetter - 1) + sLetter + sAnswer3.Substring(nLetter, 16 - nLetter);
                        nScore += 10;
                        lblScore.Text = "Score = " + Convert.ToString(nScore);
                    }
                    lblAnswer1.Text = sAnswer1;
                    lblAnswer2.Text = sAnswer3;
                    fUpdateDisplay();
                    return;
                }
                else
                {
                      sLetter = sAnswer2.Substring(nLetter - 1, 1);
                    sAnswer1 = sAnswer1.Substring(0, nLetter - 1) + sLetter + sAnswer1.Substring(nLetter, 16 - nLetter);
                    if (sAnswer1.Substring(nLetter - 1, 1) == sAnswer2.Substring(nLetter - 1, 1))
                    {
                        sAnswer3 = sAnswer3.Substring(0, nLetter - 1) + sLetter + sAnswer3.Substring(nLetter, 16 - nLetter);
                        nScore += 10;
                        lblScore.Text = "Score = " + Convert.ToString(nScore);
                    }
                    lblAnswer1.Text = sAnswer1;
                    lblAnswer2.Text = sAnswer3;
                    nScore += 10;
                    lblScore.Text = "Score = " + Convert.ToString(nScore);
                    return;
                }
            }


            sAnswer1 = sAnswer1.Substring(0, nLetter - 1) + sLetter + sAnswer1.Substring(nLetter, 16 - nLetter);
            if (sAnswer1.Substring(nLetter - 1, 1) == sAnswer2.Substring(nLetter - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, nLetter - 1) + sLetter + sAnswer3.Substring(nLetter, 16 - nLetter);
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;

        }

        private void fReset()
        {
            Random rnd1 = new Random();
            char sLetter;

            mbRotate = false;
            mbExpire = false;

            sAnswer1 = null;
            sAnswer2 = null;
            sAnswer3 = null;
            for (int i = 1; i <= 16; i++)
            {
                sAnswer1 = sAnswer1 + " ";
                sAnswer2 = sAnswer2 + "-";
                sAnswer3 = sAnswer3 + "-";
            }
            for (int i = 1; i <= 16; i++)
            {
                _count[i - 1] = rnd1.Next(1, 105);
            }
            for (int i = 1; i <= 16; i++)
            {
                if (_count[i - 1] <= 26)
                {
                    sLetter = (char)(_count[i - 1] + 64);
                    sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                }
                else
                {
                    if (_count[i - 1] <= 26 + 26)
                    {
                        sLetter = (char)(_count[i - 1] + 64 - 26);
                        sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                    }
                    else
                    {
                        if (_count[i - 1] <= 26 + 26 + 26)
                        {
                            sLetter = (char)(_count[i - 1] + 64 - 26 - 26);
                            sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                        }
                        else
                        {
                            sLetter = (char)(_count[i - 1] + 64 - 26 - 26 - 26);
                            sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                        }
                    }
                }
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;



        }
        private void fPeek(int nValue, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F B1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F B2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F B3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F B4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F B5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F B6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F B7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F B8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F B9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F B10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F B11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F B12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F B13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F B14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F B15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F B16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F B17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F B18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F B19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F B20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F B21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F B22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F B23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F B24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F B25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F B26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"F L1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"F L2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"F L3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"F L4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"F L5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"F L6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"F L7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture34 = new PictureBox
            {
                Name = "pictureBox34",
                Image = Image.FromFile(@"F L8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture35 = new PictureBox
            {
                Name = "pictureBox35",
                Image = Image.FromFile(@"F L9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture36 = new PictureBox
            {
                Name = "pictureBox36",
                Image = Image.FromFile(@"F L10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture37 = new PictureBox
            {
                Name = "pictureBox37",
                Image = Image.FromFile(@"F L11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture38 = new PictureBox
            {
                Name = "pictureBox38",
                Image = Image.FromFile(@"F L12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture39 = new PictureBox
            {
                Name = "pictureBox39",
                Image = Image.FromFile(@"F L13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture40 = new PictureBox
            {
                Name = "pictureBox40",
                Image = Image.FromFile(@"F L14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture41 = new PictureBox
            {
                Name = "pictureBox41",
                Image = Image.FromFile(@"F L15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture42 = new PictureBox
            {
                Name = "pictureBox42",
                Image = Image.FromFile(@"F L16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture43 = new PictureBox
            {
                Name = "pictureBox43",
                Image = Image.FromFile(@"F L17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture44 = new PictureBox
            {
                Name = "pictureBox44",
                Image = Image.FromFile(@"F L18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture45 = new PictureBox
            {
                Name = "pictureBox45",
                Image = Image.FromFile(@"F L19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture46 = new PictureBox
            {
                Name = "pictureBox46",
                Image = Image.FromFile(@"F L20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture47 = new PictureBox
            {
                Name = "pictureBox47",
                Image = Image.FromFile(@"F L21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture48 = new PictureBox
            {
                Name = "pictureBox48",
                Image = Image.FromFile(@"F L22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture49 = new PictureBox
            {
                Name = "pictureBox49",
                Image = Image.FromFile(@"F L23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture50 = new PictureBox
            {
                Name = "pictureBox50",
                Image = Image.FromFile(@"F L24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture51 = new PictureBox
            {
                Name = "pictureBox51",
                Image = Image.FromFile(@"F L25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture52 = new PictureBox
            {
                Name = "pictureBox52",
                Image = Image.FromFile(@"F L26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture53 = new PictureBox
            {
                Name = "pictureBox53",
                Image = Image.FromFile(@"F M1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture54 = new PictureBox
            {
                Name = "pictureBox54",
                Image = Image.FromFile(@"F M2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture55 = new PictureBox
            {
                Name = "pictureBox55",
                Image = Image.FromFile(@"F M3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture56 = new PictureBox
            {
                Name = "pictureBox56",
                Image = Image.FromFile(@"F M4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture57 = new PictureBox
            {
                Name = "pictureBox57",
                Image = Image.FromFile(@"F M5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture58 = new PictureBox
            {
                Name = "pictureBox58",
                Image = Image.FromFile(@"F M6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture59 = new PictureBox
            {
                Name = "pictureBox59",
                Image = Image.FromFile(@"F M7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture60 = new PictureBox
            {
                Name = "pictureBox60",
                Image = Image.FromFile(@"F M8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture61 = new PictureBox
            {
                Name = "pictureBox61",
                Image = Image.FromFile(@"F M9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture62 = new PictureBox
            {
                Name = "pictureBox62",
                Image = Image.FromFile(@"F M10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture63 = new PictureBox
            {
                Name = "pictureBox63",
                Image = Image.FromFile(@"F M11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture64 = new PictureBox
            {
                Name = "pictureBox64",
                Image = Image.FromFile(@"F M12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture65 = new PictureBox
            {
                Name = "pictureBox65",
                Image = Image.FromFile(@"F M13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture66 = new PictureBox
            {
                Name = "pictureBox66",
                Image = Image.FromFile(@"F M14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture67 = new PictureBox
            {
                Name = "pictureBox67",
                Image = Image.FromFile(@"F M15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture68 = new PictureBox
            {
                Name = "pictureBox68",
                Image = Image.FromFile(@"F M16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture69 = new PictureBox
            {
                Name = "pictureBox69",
                Image = Image.FromFile(@"F M17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture70 = new PictureBox
            {
                Name = "pictureBox70",
                Image = Image.FromFile(@"F M18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture71 = new PictureBox
            {
                Name = "pictureBox71",
                Image = Image.FromFile(@"F M19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture72 = new PictureBox
            {
                Name = "pictureBox72",
                Image = Image.FromFile(@"F M20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture73 = new PictureBox
            {
                Name = "pictureBox73",
                Image = Image.FromFile(@"F M21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture74 = new PictureBox
            {
                Name = "pictureBox74",
                Image = Image.FromFile(@"F M22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture75 = new PictureBox
            {
                Name = "pictureBox75",
                Image = Image.FromFile(@"F M23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture76 = new PictureBox
            {
                Name = "pictureBox76",
                Image = Image.FromFile(@"F M24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture77 = new PictureBox
            {
                Name = "pictureBox77",
                Image = Image.FromFile(@"F M25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture78 = new PictureBox
            {
                Name = "pictureBox78",
                Image = Image.FromFile(@"F M26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture79 = new PictureBox
            {
                Name = "pictureBox79",
                Image = Image.FromFile(@"F S1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture80 = new PictureBox
            {
                Name = "pictureBox80",
                Image = Image.FromFile(@"F S2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture81 = new PictureBox
            {
                Name = "pictureBox81",
                Image = Image.FromFile(@"F S3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture82 = new PictureBox
            {
                Name = "pictureBox82",
                Image = Image.FromFile(@"F S4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture83 = new PictureBox
            {
                Name = "pictureBox83",
                Image = Image.FromFile(@"F S5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture84 = new PictureBox
            {
                Name = "pictureBox84",
                Image = Image.FromFile(@"F S6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture85 = new PictureBox
            {
                Name = "pictureBox85",
                Image = Image.FromFile(@"F S7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture86 = new PictureBox
            {
                Name = "pictureBox86",
                Image = Image.FromFile(@"F S8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture87 = new PictureBox
            {
                Name = "pictureBox87",
                Image = Image.FromFile(@"F S9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture88 = new PictureBox
            {
                Name = "pictureBox88",
                Image = Image.FromFile(@"F S10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture89 = new PictureBox
            {
                Name = "pictureBox89",
                Image = Image.FromFile(@"F S11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture90 = new PictureBox
            {
                Name = "pictureBox90",
                Image = Image.FromFile(@"F S12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture91 = new PictureBox
            {
                Name = "pictureBox91",
                Image = Image.FromFile(@"F S13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture92 = new PictureBox
            {
                Name = "pictureBox92",
                Image = Image.FromFile(@"F S14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture93 = new PictureBox
            {
                Name = "pictureBox93",
                Image = Image.FromFile(@"F S15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture94 = new PictureBox
            {
                Name = "pictureBox94",
                Image = Image.FromFile(@"F S16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture95 = new PictureBox
            {
                Name = "pictureBox95",
                Image = Image.FromFile(@"F S17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture96 = new PictureBox
            {
                Name = "pictureBo9x6",
                Image = Image.FromFile(@"F S18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture97 = new PictureBox
            {
                Name = "pictureBox97",
                Image = Image.FromFile(@"F S19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture98 = new PictureBox
            {
                Name = "pictureBox98",
                Image = Image.FromFile(@"F S20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture99 = new PictureBox
            {
                Name = "pictureBox99",
                Image = Image.FromFile(@"F S21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture100 = new PictureBox
            {
                Name = "pictureBox100",
                Image = Image.FromFile(@"F S22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture101 = new PictureBox
            {
                Name = "pictureBox101",
                Image = Image.FromFile(@"F S23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture102 = new PictureBox
            {
                Name = "pictureBox102",
                Image = Image.FromFile(@"F S24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture103 = new PictureBox
            {
                Name = "pictureBox103",
                Image = Image.FromFile(@"F S25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture104 = new PictureBox
            {
                Name = "pictureBox104",
                Image = Image.FromFile(@"F S26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture105 = new PictureBox
            {
                Name = "pictureBox105",
                Image = Image.FromFile(@"F Nullgate.png"),
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
                case 16:
                    _pic2 = picture16;
                    break;
                case 17:
                    _pic2 = picture17;
                    break;
                case 18:
                    _pic2 = picture18;
                    break;
                case 19:
                    _pic2 = picture19;
                    break;
                case 20:
                    _pic2 = picture20;
                    break;
                case 21:
                    _pic2 = picture21;
                    break;
                case 22:
                    _pic2 = picture22;
                    break;
                case 23:
                    _pic2 = picture23;
                    break;
                case 24:
                    _pic2 = picture24;
                    break;
                case 25:
                    _pic2 = picture25;
                    break;
                case 26:
                    _pic2 = picture26;
                    break;
                case 27:
                    _pic2 = picture27;
                    break;
                case 28:
                    _pic2 = picture28;
                    break;
                case 29:
                    _pic2 = picture29;
                    break;
                case 30:
                    _pic2 = picture30;
                    break;
                case 31:
                    _pic2 = picture31;
                    break;
                case 32:
                    _pic2 = picture32;
                    break;
                case 33:
                    _pic2 = picture33;
                    break;
                case 34:
                    _pic2 = picture34;
                    break;
                case 35:
                    _pic2 = picture35;
                    break;
                case 36:
                    _pic2 = picture36;
                    break;
                case 37:
                    _pic2 = picture37;
                    break;
                case 38:
                    _pic2 = picture38;
                    break;
                case 39:
                    _pic2 = picture39;
                    break;
                case 40:
                    _pic2 = picture40;
                    break;
                case 41:
                    _pic2 = picture41;
                    break;
                case 42:
                    _pic2 = picture42;
                    break;
                case 43:
                    _pic2 = picture43;
                    break;
                case 44:
                    _pic2 = picture44;
                    break;
                case 45:
                    _pic2 = picture45;
                    break;
                case 46:
                    _pic2 = picture46;
                    break;
                case 47:
                    _pic2 = picture47;
                    break;
                case 48:
                    _pic2 = picture48;
                    break;
                case 49:
                    _pic2 = picture49;
                    break;
                case 50:
                    _pic2 = picture50;
                    break;
                case 51:
                    _pic2 = picture51;
                    break;
                case 52:
                    _pic2 = picture52;
                    break;
                case 53:
                    _pic2 = picture53;
                    break;
                case 54:
                    _pic2 = picture54;
                    break;
                case 55:
                    _pic2 = picture55;
                    break;
                case 56:
                    _pic2 = picture56;
                    break;
                case 57:
                    _pic2 = picture57;
                    break;
                case 58:
                    _pic2 = picture58;
                    break;
                case 59:
                    _pic2 = picture59;
                    break;
                case 60:
                    _pic2 = picture60;
                    break;
                case 61:
                    _pic2 = picture61;
                    break;
                case 62:
                    _pic2 = picture62;
                    break;
                case 63:
                    _pic2 = picture63;
                    break;
                case 64:
                    _pic2 = picture64;
                    break;
                case 65:
                    _pic2 = picture65;
                    break;
                case 66:
                    _pic2 = picture66;
                    break;
                case 67:
                    _pic2 = picture67;
                    break;
                case 68:
                    _pic2 = picture68;
                    break;
                case 69:
                    _pic2 = picture69;
                    break;
                case 70:
                    _pic2 = picture70;
                    break;
                case 71:
                    _pic2 = picture71;
                    break;
                case 72:
                    _pic2 = picture72;
                    break;
                case 73:
                    _pic2 = picture73;
                    break;
                case 74:
                    _pic2 = picture74;
                    break;
                case 75:
                    _pic2 = picture75;
                    break;
                case 76:
                    _pic2 = picture76;
                    break;
                case 77:
                    _pic2 = picture77;
                    break;
                case 78:
                    _pic2 = picture78;
                    break;
                case 79:
                    _pic2 = picture79;
                    break;
                case 80:
                    _pic2 = picture80;
                    break;
                case 81:
                    _pic2 = picture81;
                    break;
                case 82:
                    _pic2 = picture82;
                    break;
                case 83:
                    _pic2 = picture83;
                    break;
                case 84:
                    _pic2 = picture84;
                    break;
                case 85:
                    _pic2 = picture85;
                    break;
                case 86:
                    _pic2 = picture86;
                    break;
                case 87:
                    _pic2 = picture87;
                    break;
                case 88:
                    _pic2 = picture88;
                    break;
                case 89:
                    _pic2 = picture89;
                    break;
                case 90:
                    _pic2 = picture90;
                    break;
                case 91:
                    _pic2 = picture91;
                    break;
                case 92:
                    _pic2 = picture92;
                    break;
                case 93:
                    _pic2 = picture93;
                    break;
                case 94:
                    _pic2 = picture94;
                    break;
                case 95:
                    _pic2 = picture95;
                    break;
                case 96:
                    _pic2 = picture96;
                    break;
                case 97:
                    _pic2 = picture97;
                    break;
                case 98:
                    _pic2 = picture98;
                    break;
                case 99:
                    _pic2 = picture99;
                    break;
                case 100:
                    _pic2 = picture100;
                    break;
                case 101:
                    _pic2 = picture101;
                    break;
                case 102:
                    _pic2 = picture102;
                    break;
                case 103:
                    _pic2 = picture103;
                    break;
               case 104:
                    _pic2 = picture104;
                    break;
              default:
                    _pic2 = picture105;
                    break;
            }



        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType;

            nType = _count[0];
            fPeek(nType, ref _pic);
            pic1.Image = _pic.Image;
            nType = _count[1];
            fPeek(nType, ref _pic);
            pic2.Image = _pic.Image;
            nType = _count[2];
            fPeek(nType, ref _pic);
            pic3.Image = _pic.Image;
            nType = _count[3];
            fPeek(nType, ref _pic);
            pic4.Image = _pic.Image;
            nType = _count[4];
            fPeek(nType, ref _pic);
            pic5.Image = _pic.Image;
            nType = _count[5];
            fPeek(nType, ref _pic);
            pic6.Image = _pic.Image;
            nType = _count[6];
            fPeek(nType, ref _pic);
            pic7.Image = _pic.Image;
            nType = _count[7];
            fPeek(nType, ref _pic);
            pic8.Image = _pic.Image;
            nType = _count[8];
            fPeek(nType, ref _pic);
            pic9.Image = _pic.Image;
            nType = _count[9];
            fPeek(nType, ref _pic);
            pica.Image = _pic.Image;
            nType = _count[10];
            fPeek(nType, ref _pic);
            picb.Image = _pic.Image;
            nType = _count[11];
            fPeek(nType, ref _pic);
            picc.Image = _pic.Image;
            nType = _count[12];
            fPeek(nType, ref _pic);
            picd.Image = _pic.Image;
            nType = _count[13];
            fPeek(nType, ref _pic);
            pice.Image = _pic.Image;
            nType = _count[14];
            fPeek(nType, ref _pic);
            picf.Image = _pic.Image;
            nType = _count[15];
            fPeek(nType, ref _pic);
            picg.Image = _pic.Image;

        }
        private void pic1_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 1;
            fChance(sLetter, i);
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 3;
            fChance(sLetter, i);
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 4;
            fChance(sLetter, i);
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 5;
            fChance(sLetter, i);
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 6;
            fChance(sLetter, i);
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 7;
            fChance(sLetter, i);
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 8;
            fChance(sLetter, i);
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 9;
            fChance(sLetter, i);
        }

        private void pica_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 10;
            fChance(sLetter, i);
        }

        private void picb_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 11;
            fChance(sLetter, i);
        }

        private void picc_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 12;
            fChance(sLetter, i);
        }

        private void picd_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 13;
            fChance(sLetter, i);
        }


        private void lstPopup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lstPopup1.SelectedIndex + 1;
        }

        private void pice_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 14;
            fChance(sLetter, i);
        }

        private void picf_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 15;
            fChance(sLetter, i);
        }

        private void picg_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 16;
            fChance(sLetter, i);
        }

        private void btnPopup1_Click(object sender, EventArgs e)
        {
            fPopup testdialog = new fPopup();

            switch (mnItem)
            {
                case 1:
                    msPopup1 = "B";
                    break;
                case 2:
                    msPopup1 = "L";
                    break;
                case 3:
                    msPopup1 = "M";
                    break;
                default:
                    msPopup1 = "S";
                    break;
            }

            String sName = "data.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                file.WriteLine(msPopup1);
            }





            testdialog.ShowDialog();
            testdialog.Dispose();

        }

        private void txtLetter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLetter_KeyUp(object sender, KeyEventArgs e)
        {
            char sLetter = (char)e.KeyCode;
            txtLetter.Text = Convert.ToString(sLetter);
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

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (txtLetter.Text == null)
            {
                MessageBox.Show("Error!");
                mbRotate = false;
            }
            else
            {
                mbRotate = true;
            }
        }

        private void btnCheatsheet_Click(object sender, EventArgs e)
        {
            fCheatsheet _dlg = new fCheatsheet();
            _dlg.ShowDialog();
        }

        private void btnExpire_Click(object sender, EventArgs e)
        {
            if (txtLetter.Text == null)
            {
                MessageBox.Show("Error!");
                mbExpire = false;
            }
            else
            {
                mbExpire = true;
            }
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            if (sAnswer1 == sAnswer3)
            {
                nScore += 100;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                fReset();
                fUpdateDisplay();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 2;
            fChance(sLetter, i);
        }
    }

    }

