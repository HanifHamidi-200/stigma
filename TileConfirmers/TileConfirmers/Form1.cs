using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileConfirmers
{
    public partial class Form1 : Form
    {
        private List<int> _count = new List<int> { 71,104 ,143,33,33,38};
        private List<String> _index = new List<String> { "abcdefghijkmnoprstuwyz", "abcdefghijkmnoprstuwyz", "abcdegijkmnoprstuy" , "abdefgijklmnoprstuvxz" , "abcdeghijklmnopqrstuvz", "bcdghjklmnprstvy" };
        private List<int> _place = new List<int> { 0,0,0,0,0,0,0,0,0,0 };
        private List<String> _data1 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _data2 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _data3 = new List<String> { null,null,null,null,null , null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _lookup1 = new List<String> { "a", "ba", "be", "bi", "bo", "bu", "chi", "da", "de", "do", "e", "fu", "ga", "ge", "gi", "go", "gu", "ha", "he", "hi", "ho", "i", "ji", "ji2", "ka", "ke", "ki", "ko", "ku", "ma", "me", "mi", "mo", "mu", "n", "na", "ne", "ni", "no", "nu", "o", "pa", "pe", "pi", "po", "pu", "ra", "re", "ri", "ro", "ru", "sa", "se", "shi", "so", "su", "ta", "te", "to", "tsu", "u", "wa", "wo", "ya", "yo", "yu", "za", "ze", "zo", "zu", "zu2", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _lookup2 = new List<String> { "a", "ba", "be", "bi", "bo", "bu", "bya", "byo", "byu", "cha", "chi", "cho", "chu", "da", "de", "do", "e", "fu", "ga", "ge", "gi", "go", "gu", "gya", "gyo", "gyu", "ha", "he", "hi", "ho", "hya", "hyo", "hyu", "i", "ja", "ji", "ji2", "jo", "ju", "ka", "ke", "ki", "ko", "ku", "kya", "kyo", "kyu", "ma", "me", "mi", "mo", "mu", "mya", "myo", "myu", "n", "na", "ne", "ni", "no", "nu", "nya", "nyo", "nyu", "o", "o2", "pa", "pe", "pi", "po", "pu", "pya", "pyo", "pyu", "ra", "re", "ri", "ro", "ru", "rya", "ryo", "ryu", "sa", "se", "sha", "shi", "sho", "shu", "so", "su", "ta", "te", "to", "tsu", "u", "wa", "ya", "yo", "yu", "za", "ze", "zo", "zu", "zu2", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
private List<String> _lookup3 = new List<String> { "a", "ae", "ba", "bae", "beo", "beu", "bi", "bo", "bu", "bya", "byeo", "byo", "byu", "chu", "chae", "cheo", "cheu", "chi", "cho", "chu", "chya", "chyeo", "chyo", "chyu", "da", "dae", "deo", "deu", "di", "do", "du", "dya", "dyeo", "dyo", "dyu", "eo", "eu", "ga", "gae", "geo", "geu", "gi", "go", "gu", "gya", "gyeo", "gyo", "gyu", "i", "ja", "jae", "jeo", "jeu", "ji", "jo", "ju", "jya", "jyeo", "jyo", "jyu", "ka", "kae", "keo", "keu", "ki", "ko", "ku", "kya", "kyeo", "kyo", "kyu", "ma", "mae", "meo", "meu", "mi", "mo", "mu", "mya", "myeo", "myo", "myu", "na", "nae", "neo", "neu", "ni", "no", "nu", "nya", "nyeo", "nyo", "nyu", "o", "pa", "pae", "peo", "peu", "pi", "po", "pu", "pya", "pyeo", "pyo", "pyu", "ra", "rae", "reo", "reu", "ri", "ro", "ru", "rya", "ryeo", "ryo", "ryu", "sa", "sae", "seo", "seu", "si", "so", "su", "sya", "sya2", "syeo", "syu", "ta", "ta2", "tae", "teo", "teu", "to", "tu", "tya", "tyeo", "tyo", "tyu", "u", "ya", "yeo", "yo", "yu", null, null, null, null, null, null, null };
        private List<String> _lookup4 = new List<String> { "a", "b", "d", "e", "f", "g", "i", "j", "ja", "je", "jo", "ju", "k", "l", "m", "n", "n2", "n3", "n4", "o", "p", "r", "s", "sh", "shch", "t", "tch", "ts", "u", "v", "x", "z", "zch", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _lookup5 = new List<String> { "a", "b", "ch", "che", "d", "dz", "e", "g", "gh", "h", "i", "j", "ke", "kh", "kh2", "l", "m", "n", "o", "pe", "ph", "qe", "r", "s", "sh", "te", "th", "tse", "tsh", "u", "v", "z", "zh",null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
private List<String> _lookup6 = new List<String> { "b", "bha", "ca", "cha", "da", "da2", "dha", "dha2", "ga", "gha", "ha", "ja", "jha", "ka", "kha", "la", "la2", "la3", "ma", "na", "na2", "na3", "nya", "nya2", "pa", "pha", "ra", "ra2", "sa", "sa2", "sae", "ta", "ta2", "ta3", "tha", "tha2", "va", "ya", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _index1a = new List<int> { 1, 2, 7, 8, 11, 12, 13, 18, 22, 23, 25, 30, 35,41, 42, 47, 52, 57, 61, 62, 64, 67, 0, 0, 0, 0, 0 };
        private List<int> _index1b = new List<int> { 1, 6, 7, 10, 11, 12, 17, 21, 22, 24, 29, 34,40, 41, 46, 51, 56, 60, 61, 63, 66, 71, 0, 0, 0, 0, 0 };
        private List<int> _index2a = new List<int> { 1, 2, 10, 14, 17, 18, 19, 27, 34, 35, 40, 48, 56, 65, 67, 75, 83, 91,95, 96, 97, 100, 0, 0, 0, 0, 0 };
        private List<int> _index2b = new List<int> { 1, 9, 13, 16, 17, 18, 26, 33, 34, 39, 47, 55, 64, 66, 74, 82, 90, 94,95, 96, 99, 104, 0, 0, 0, 0, 0 };
        private List<int> _index3a = new List<int> { 1, 3, 14, 25, 36, 38, 49, 50, 61, 72, 83, 94, 95, 106, 117, 128, 139, 140, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _index3b = new List<int> { 2, 13, 24, 35, 37, 48, 49, 60, 71, 82, 93, 94, 105, 116, 127, 138, 139, 143, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _index4a = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 13, 14, 15, 16, 20, 21, 22, 23, 26, 29, 30, 31, 32, 0, 0, 0, 0, 0 };
        private List<int> _index4b = new List<int> { 1, 2, 3, 4, 5, 6, 7, 12, 13, 14, 15, 19, 20, 21, 22, 25, 28, 29, 30, 31, 33, 0, 0, 0, 0, 0 };
        private List<int> _index5a = new List<int> { 1, 2, 3, 5, 7, 8, 10, 11, 12, 13, 16, 17, 18, 19, 20, 22, 23, 24, 26, 30, 31, 32, 0, 0, 0, 0 };
        private List<int> _index5b = new List<int> { 1, 2, 4, 6, 7, 9, 10, 11, 12, 15, 16, 17, 18, 19, 21, 22, 23, 25, 29, 30, 31, 33, 0, 0, 0, 0 };
        private List<int> _index6a = new List<int> { 1, 3, 5, 9, 11, 12, 14, 16, 19, 20, 25, 27, 29, 32, 37, 38, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _index6b = new List<int> { 2, 4, 8, 10, 11, 13, 15, 18, 19, 24, 26, 28, 31, 36, 37, 38, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnMode;
        private String sAnswer1, sAnswer2, sAnswer3;
        private int mnItem;
        private int nScore;

        private void fUpdateList()
        {
            String sList = _index[mnMode - 1];
            int nCount = sList.Length;
            String sLetter;

            if (lstPopup.Items.Count > 0)
            {
                do
                {
                    lstPopup.Items.RemoveAt(0);
                } while (lstPopup.Items.Count > 0);
            }

            for (int i = 1; i <= nCount; i++)
            {
                sLetter = sList.Substring(i - 1,1);
                lstPopup.Items.Add(sLetter);
            }
            mnItem = 1;
         }

        private void fInput(int nChar,String sInput)
        {
            String sAnswer;
            int nAnswer = _place[nChar - 1];

            switch (mnMode)
            {
                case 1:
                    sAnswer = _lookup1[nAnswer - 1];
                    break;
                case 2:
                    sAnswer = _lookup2[nAnswer - 1];
                    break;
                case 3:
                    sAnswer = _lookup3[nAnswer - 1];
                    break;
                case 4:
                    sAnswer = _lookup4[nAnswer - 1];
                    break;
                case 5:
                    sAnswer = _lookup5[nAnswer - 1];
                    break;
                default:
                    sAnswer = _lookup6[nAnswer - 1];
                    break;
            }

            if (sInput == sAnswer)
            {
                if (nChar == 1)
                {
                    sAnswer3 =  "Y" + sAnswer3.Substring(nChar, 10 - nChar);
                }
                else
                {
                    sAnswer3 = sAnswer3.Substring(0, nChar - 1) + "Y" + sAnswer3.Substring(nChar, 10 - nChar);
                }
                _data1[nAnswer-1] = _data2[nAnswer-1];
                _data3[nAnswer-1] = _data2[nAnswer-1];
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
            }
            else
            {
                if (nChar == 1)
                {
                    sAnswer3 =  "N" + sAnswer3.Substring(nChar, 10 - nChar);
                }
                else
                {
                    sAnswer3 = sAnswer3.Substring(0, nChar - 1) + "N" + sAnswer3.Substring(nChar, 10 - nChar);
                }
                _data1[nAnswer-1] = sInput;
                _data3[nAnswer-1] = null;
            }
            fUpdateStatus();
            txtInput.Text = null;
        }

        private void fUpdateStatus()
        {
            String sLookup = null;
            int nPlace;

            sLookup = null;
            for (int i = 1; i <= 10; i++)
            {
                nPlace = _place[i - 1];
                sLookup = sLookup+"[" + _data1[nPlace-1] + "]";
            }
            txtAnswer1.Text = sLookup;
            sLookup = null;
            for (int i = 1; i <= 10; i++)
            {
                nPlace = _place[i - 1];
                if (sAnswer3.Substring(i - 1, 1) == "N")
                {
                    sLookup = sLookup + "[]";
                }
                else
                {
                    sLookup = sLookup + "[" + _data3[nPlace-1] + "]";
                }
            }
            txtAnswer3.Text = sLookup;
        }
        private void fPeek1(int nValue, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"../../hiragana/F a.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../hiragana/F ba.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"../../hiragana/F be.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"../../hiragana/F bi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"../../hiragana/F bo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"../../hiragana/F bu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"../../hiragana/F chi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"../../hiragana/F da.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"../../hiragana/F de.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"../../hiragana/F do.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"../../hiragana/F e.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"../../hiragana/F fu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"../../hiragana/F ga.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"../../hiragana/F ge.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"../../hiragana/F gi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"../../hiragana/F go.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"../../hiragana/F gu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"../../hiragana/F ha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"../../hiragana/F he.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"../../hiragana/F hi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"../../hiragana/F ho.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"../../hiragana/F i.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"../../hiragana/F ji.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"../../hiragana/F ji2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"../../hiragana/F ka.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../hiragana/F ke.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"../../hiragana/F ki.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"../../hiragana/F ko.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"../../hiragana/F ku.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"../../hiragana/F ma.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"../../hiragana/F me.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"../../hiragana/F mi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"../../hiragana/F mo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture34 = new PictureBox
            {
                Name = "pictureBox34",
                Image = Image.FromFile(@"../../hiragana/F mu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture35 = new PictureBox
            {
                Name = "pictureBox35",
                Image = Image.FromFile(@"../../hiragana/F n.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture36 = new PictureBox
            {
                Name = "pictureBox36",
                Image = Image.FromFile(@"../../hiragana/F na.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture37 = new PictureBox
            {
                Name = "pictureBox37",
                Image = Image.FromFile(@"../../hiragana/F ne.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture38 = new PictureBox
            {
                Name = "pictureBox38",
                Image = Image.FromFile(@"../../hiragana/F ni.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture39 = new PictureBox
            {
                Name = "pictureBox39",
                Image = Image.FromFile(@"../../hiragana/F no.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture40 = new PictureBox
            {
                Name = "pictureBox40",
                Image = Image.FromFile(@"../../hiragana/F nu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture41 = new PictureBox
            {
                Name = "pictureBox41",
                Image = Image.FromFile(@"../../hiragana/F o.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture42 = new PictureBox
            {
                Name = "pictureBox42",
                Image = Image.FromFile(@"../../hiragana/F pa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture43 = new PictureBox
            {
                Name = "pictureBox43",
                Image = Image.FromFile(@"../../hiragana/F pe.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture44 = new PictureBox
            {
                Name = "pictureBox44",
                Image = Image.FromFile(@"../../hiragana/F pi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture45 = new PictureBox
            {
                Name = "pictureBox45",
                Image = Image.FromFile(@"../../hiragana/F po.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture46 = new PictureBox
            {
                Name = "pictureBox46",
                Image = Image.FromFile(@"../../hiragana/F pu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture47 = new PictureBox
            {
                Name = "pictureBox47",
                Image = Image.FromFile(@"../../hiragana/F ra.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture48 = new PictureBox
            {
                Name = "pictureBox48",
                Image = Image.FromFile(@"../../hiragana/F re.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture49 = new PictureBox
            {
                Name = "pictureBox49",
                Image = Image.FromFile(@"../../hiragana/F ri.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture50 = new PictureBox
            {
                Name = "pictureBox50",
                Image = Image.FromFile(@"../../hiragana/F ro.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture51 = new PictureBox
            {
                Name = "pictureBox51",
                Image = Image.FromFile(@"../../hiragana/F ru.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture52 = new PictureBox
            {
                Name = "pictureBox52",
                Image = Image.FromFile(@"../../hiragana/F sa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture53 = new PictureBox
            {
                Name = "pictureBox53",
                Image = Image.FromFile(@"../../hiragana/F se.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture54 = new PictureBox
            {
                Name = "pictureBox54",
                Image = Image.FromFile(@"../../hiragana/F shi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture55 = new PictureBox
            {
                Name = "pictureBox55",
                Image = Image.FromFile(@"../../hiragana/F so.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture56 = new PictureBox
            {
                Name = "pictureBox56",
                Image = Image.FromFile(@"../../hiragana/F su.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture57 = new PictureBox
            {
                Name = "pictureBox57",
                Image = Image.FromFile(@"../../hiragana/F ta.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture58 = new PictureBox
            {
                Name = "pictureBox58",
                Image = Image.FromFile(@"../../hiragana/F te.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture59 = new PictureBox
            {
                Name = "pictureBox59",
                Image = Image.FromFile(@"../../hiragana/F to.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture60 = new PictureBox
            {
                Name = "pictureBox60",
                Image = Image.FromFile(@"../../hiragana/F tsu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture61 = new PictureBox
            {
                Name = "pictureBox61",
                Image = Image.FromFile(@"../../hiragana/F u.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture62 = new PictureBox
            {
                Name = "pictureBox62",
                Image = Image.FromFile(@"../../hiragana/F wa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture63 = new PictureBox
            {
                Name = "pictureBox63",
                Image = Image.FromFile(@"../../hiragana/F wo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture64 = new PictureBox
            {
                Name = "pictureBox64",
                Image = Image.FromFile(@"../../hiragana/F ya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture65 = new PictureBox
            {
                Name = "pictureBox65",
                Image = Image.FromFile(@"../../hiragana/F yo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture66 = new PictureBox
            {
                Name = "pictureBox66",
                Image = Image.FromFile(@"../../hiragana/F yu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture67 = new PictureBox
            {
                Name = "pictureBox67",
                Image = Image.FromFile(@"../../hiragana/F za.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture68 = new PictureBox
            {
                Name = "pictureBox68",
                Image = Image.FromFile(@"../../hiragana/F ze.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture69 = new PictureBox
            {
                Name = "pictureBox69",
                Image = Image.FromFile(@"../../hiragana/F zo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture70 = new PictureBox
            {
                Name = "pictureBox70",
                Image = Image.FromFile(@"../../hiragana/F zu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture71 = new PictureBox
            {
                Name = "pictureBox71",
                Image = Image.FromFile(@"../../hiragana/F zu2.png"),
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
                   default:
                    _pic2 = picture71;
                    break;
            }



        }


        private void fPeek2(int nValue, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"../../katakana/F a.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../katakana/F ba.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"../../katakana/F be.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"../../katakana/F bi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"../../katakana/F bo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"../../katakana/F bu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"../../katakana/F bya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"../../katakana/F byo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"../../katakana/F byu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"../../katakana/F cha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"../../katakana/F chi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"../../katakana/F cho.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"../../katakana/F chu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"../../katakana/F da.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"../../katakana/F de.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"../../katakana/F do.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"../../katakana/F e.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"../../katakana/F fu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"../../katakana/F ga.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"../../katakana/F ge.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"../../katakana/F gi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"../../katakana/F go.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"../../katakana/F gu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"../../katakana/F gya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"../../katakana/F gyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../katakana/F gyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"../../katakana/F ha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"../../katakana/F he.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"../../katakana/F hi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"../../katakana/F ho.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"../../katakana/F hya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"../../katakana/F hyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"../../katakana/F hyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture34 = new PictureBox
            {
                Name = "pictureBox34",
                Image = Image.FromFile(@"../../katakana/F i.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture35 = new PictureBox
            {
                Name = "pictureBox35",
                Image = Image.FromFile(@"../../katakana/F ja.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture36 = new PictureBox
            {
                Name = "pictureBox36",
                Image = Image.FromFile(@"../../katakana/F ji.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture37 = new PictureBox
            {
                Name = "pictureBox37",
                Image = Image.FromFile(@"../../katakana/F ji2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture38 = new PictureBox
            {
                Name = "pictureBox38",
                Image = Image.FromFile(@"../../katakana/F jo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture39 = new PictureBox
            {
                Name = "pictureBox39",
                Image = Image.FromFile(@"../../katakana/F ju.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture40 = new PictureBox
            {
                Name = "pictureBox40",
                Image = Image.FromFile(@"../../katakana/F ka.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture41 = new PictureBox
            {
                Name = "pictureBox41",
                Image = Image.FromFile(@"../../katakana/F ke.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture42 = new PictureBox
            {
                Name = "pictureBox42",
                Image = Image.FromFile(@"../../katakana/F ki.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture43 = new PictureBox
            {
                Name = "pictureBox43",
                Image = Image.FromFile(@"../../katakana/F ko.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture44 = new PictureBox
            {
                Name = "pictureBox44",
                Image = Image.FromFile(@"../../katakana/F ku.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture45 = new PictureBox
            {
                Name = "pictureBox45",
                Image = Image.FromFile(@"../../katakana/F kya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture46 = new PictureBox
            {
                Name = "pictureBox46",
                Image = Image.FromFile(@"../../katakana/F kyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture47 = new PictureBox
            {
                Name = "pictureBox47",
                Image = Image.FromFile(@"../../katakana/F kyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture48 = new PictureBox
            {
                Name = "pictureBox48",
                Image = Image.FromFile(@"../../katakana/F ma.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture49 = new PictureBox
            {
                Name = "pictureBox49",
                Image = Image.FromFile(@"../../katakana/F me.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture50 = new PictureBox
            {
                Name = "pictureBox50",
                Image = Image.FromFile(@"../../katakana/F mi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture51 = new PictureBox
            {
                Name = "pictureBox51",
                Image = Image.FromFile(@"../../katakana/F mo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture52 = new PictureBox
            {
                Name = "pictureBox52",
                Image = Image.FromFile(@"../../katakana/F mu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture53 = new PictureBox
            {
                Name = "pictureBox53",
                Image = Image.FromFile(@"../../katakana/F mya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture54 = new PictureBox
            {
                Name = "pictureBox54",
                Image = Image.FromFile(@"../../katakana/F myo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture55 = new PictureBox
            {
                Name = "pictureBox55",
                Image = Image.FromFile(@"../../katakana/F myu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture56 = new PictureBox
            {
                Name = "pictureBox56",
                Image = Image.FromFile(@"../../katakana/F n.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture57 = new PictureBox
            {
                Name = "pictureBox57",
                Image = Image.FromFile(@"../../katakana/F na.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture58 = new PictureBox
            {
                Name = "pictureBox58",
                Image = Image.FromFile(@"../../katakana/F ne.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture59 = new PictureBox
            {
                Name = "pictureBox59",
                Image = Image.FromFile(@"../../katakana/F ni.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture60 = new PictureBox
            {
                Name = "pictureBox60",
                Image = Image.FromFile(@"../../katakana/F no.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture61 = new PictureBox
            {
                Name = "pictureBox61",
                Image = Image.FromFile(@"../../katakana/F nu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture62 = new PictureBox
            {
                Name = "pictureBox62",
                Image = Image.FromFile(@"../../katakana/F nya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture63 = new PictureBox
            {
                Name = "pictureBox63",
                Image = Image.FromFile(@"../../katakana/F nyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture64 = new PictureBox
            {
                Name = "pictureBox64",
                Image = Image.FromFile(@"../../katakana/F nyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture65 = new PictureBox
            {
                Name = "pictureBox65",
                Image = Image.FromFile(@"../../katakana/F o.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture66 = new PictureBox
            {
                Name = "pictureBox66",
                Image = Image.FromFile(@"../../katakana/F o2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture67 = new PictureBox
            {
                Name = "pictureBox67",
                Image = Image.FromFile(@"../../katakana/F pa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture68 = new PictureBox
            {
                Name = "pictureBox68",
                Image = Image.FromFile(@"../../katakana/F pe.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture69 = new PictureBox
            {
                Name = "pictureBox69",
                Image = Image.FromFile(@"../../katakana/F pi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture70 = new PictureBox
            {
                Name = "pictureBox70",
                Image = Image.FromFile(@"../../katakana/F po.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture71 = new PictureBox
            {
                Name = "pictureBox71",
                Image = Image.FromFile(@"../../katakana/F pu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture72 = new PictureBox
            {
                Name = "pictureBox72",
                Image = Image.FromFile(@"../../katakana/F pya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture73 = new PictureBox
            {
                Name = "pictureBox73",
                Image = Image.FromFile(@"../../katakana/F pyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture74 = new PictureBox
            {
                Name = "pictureBox74",
                Image = Image.FromFile(@"../../katakana/F pyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture75 = new PictureBox
            {
                Name = "pictureBox75",
                Image = Image.FromFile(@"../../katakana/F ra.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture76 = new PictureBox
            {
                Name = "pictureBox76",
                Image = Image.FromFile(@"../../katakana/F re.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture77 = new PictureBox
            {
                Name = "pictureBox77",
                Image = Image.FromFile(@"../../katakana/F ri.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture78 = new PictureBox
            {
                Name = "pictureBox78",
                Image = Image.FromFile(@"../../katakana/F ro.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture79 = new PictureBox
            {
                Name = "pictureBox79",
                Image = Image.FromFile(@"../../katakana/F ru.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture80 = new PictureBox
            {
                Name = "pictureBox80",
                Image = Image.FromFile(@"../../katakana/F rya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture81 = new PictureBox
            {
                Name = "pictureBox81",
                Image = Image.FromFile(@"../../katakana/F ryo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture82 = new PictureBox
            {
                Name = "pictureBox82",
                Image = Image.FromFile(@"../../katakana/F ryu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture83 = new PictureBox
            {
                Name = "pictureBox83",
                Image = Image.FromFile(@"../../katakana/F sa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture84 = new PictureBox
            {
                Name = "pictureBox84",
                Image = Image.FromFile(@"../../katakana/F se.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture85 = new PictureBox
            {
                Name = "pictureBox85",
                Image = Image.FromFile(@"../../katakana/F sha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture86 = new PictureBox
            {
                Name = "pictureBox86",
                Image = Image.FromFile(@"../../katakana/F shi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture87 = new PictureBox
            {
                Name = "pictureBox87",
                Image = Image.FromFile(@"../../katakana/F sho.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture88 = new PictureBox
            {
                Name = "pictureBox88",
                Image = Image.FromFile(@"../../katakana/F shu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture89 = new PictureBox
            {
                Name = "pictureBox89",
                Image = Image.FromFile(@"../../katakana/F so.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture90 = new PictureBox
            {
                Name = "pictureBox90",
                Image = Image.FromFile(@"../../katakana/F su.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture91 = new PictureBox
            {
                Name = "pictureBox91",
                Image = Image.FromFile(@"../../katakana/F ta.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture92 = new PictureBox
            {
                Name = "pictureBox92",
                Image = Image.FromFile(@"../../katakana/F te.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture93 = new PictureBox
            {
                Name = "pictureBox93",
                Image = Image.FromFile(@"../../katakana/F to.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture94 = new PictureBox
            {
                Name = "pictureBox94",
                Image = Image.FromFile(@"../../katakana/F tsu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture95 = new PictureBox
            {
                Name = "pictureBox95",
                Image = Image.FromFile(@"../../katakana/F u.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture96 = new PictureBox
            {
                Name = "pictureBo9x6",
                Image = Image.FromFile(@"../../katakana/F wa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture97 = new PictureBox
            {
                Name = "pictureBox97",
                Image = Image.FromFile(@"../../katakana/F ya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture98 = new PictureBox
            {
                Name = "pictureBox98",
                Image = Image.FromFile(@"../../katakana/F yo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture99 = new PictureBox
            {
                Name = "pictureBox99",
                Image = Image.FromFile(@"../../katakana/F yu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture100 = new PictureBox
            {
                Name = "pictureBox100",
                Image = Image.FromFile(@"../../katakana/F za.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture101 = new PictureBox
            {
                Name = "pictureBox101",
                Image = Image.FromFile(@"../../katakana/F ze.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture102 = new PictureBox
            {
                Name = "pictureBox102",
                Image = Image.FromFile(@"../../katakana/F zo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture103 = new PictureBox
            {
                Name = "pictureBox103",
                Image = Image.FromFile(@"../../katakana/F zu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture104 = new PictureBox
            {
                Name = "pictureBox104",
                Image = Image.FromFile(@"../../katakana/F zu2.png"),
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
                default:
                    _pic2 = picture104;
                    break;
            }



        }

        private void fPeek3(int nValue, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"../../hangul/F a.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../hangul/F ae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"../../hangul/F ba.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"../../hangul/F bae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"../../hangul/F beo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"../../hangul/F beu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"../../hangul/F bi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"../../hangul/F bo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"../../hangul/F bu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"../../hangul/F bya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"../../hangul/F byeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"../../hangul/F byo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"../../hangul/F byu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"../../hangul/F cha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"../../hangul/F chae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"../../hangul/F cheo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"../../hangul/F cheu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"../../hangul/F chi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"../../hangul/F cho.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"../../hangul/F chu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"../../hangul/F chya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"../../hangul/F chyeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"../../hangul/F chyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"../../hangul/F chyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"../../hangul/F da.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../hangul/F dae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"../../hangul/F deo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"../../hangul/F deu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"../../hangul/F di.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"../../hangul/F do.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"../../hangul/F du.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"../../hangul/F dya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"../../hangul/F dyeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture34 = new PictureBox
            {
                Name = "pictureBox34",
                Image = Image.FromFile(@"../../hangul/F dyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture35 = new PictureBox
            {
                Name = "pictureBox35",
                Image = Image.FromFile(@"../../hangul/F dyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture36 = new PictureBox
            {
                Name = "pictureBox36",
                Image = Image.FromFile(@"../../hangul/F eo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture37 = new PictureBox
            {
                Name = "pictureBox37",
                Image = Image.FromFile(@"../../hangul/F eu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture38 = new PictureBox
            {
                Name = "pictureBox38",
                Image = Image.FromFile(@"../../hangul/F ga.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture39 = new PictureBox
            {
                Name = "pictureBox39",
                Image = Image.FromFile(@"../../hangul/F gae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture40 = new PictureBox
            {
                Name = "pictureBox40",
                Image = Image.FromFile(@"../../hangul/F geo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture41 = new PictureBox
            {
                Name = "pictureBox41",
                Image = Image.FromFile(@"../../hangul/F geu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture42 = new PictureBox
            {
                Name = "pictureBox42",
                Image = Image.FromFile(@"../../hangul/F gi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture43 = new PictureBox
            {
                Name = "pictureBox43",
                Image = Image.FromFile(@"../../hangul/F go.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture44 = new PictureBox
            {
                Name = "pictureBox44",
                Image = Image.FromFile(@"../../hangul/F gu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture45 = new PictureBox
            {
                Name = "pictureBox45",
                Image = Image.FromFile(@"../../hangul/F gya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture46 = new PictureBox
            {
                Name = "pictureBox46",
                Image = Image.FromFile(@"../../hangul/F gyeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture47 = new PictureBox
            {
                Name = "pictureBox47",
                Image = Image.FromFile(@"../../hangul/F gyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture48 = new PictureBox
            {
                Name = "pictureBox48",
                Image = Image.FromFile(@"../../hangul/F gyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture49 = new PictureBox
            {
                Name = "pictureBox49",
                Image = Image.FromFile(@"../../hangul/F i.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture50 = new PictureBox
            {
                Name = "pictureBox50",
                Image = Image.FromFile(@"../../hangul/F ja.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture51 = new PictureBox
            {
                Name = "pictureBox51",
                Image = Image.FromFile(@"../../hangul/F jae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture52 = new PictureBox
            {
                Name = "pictureBox52",
                Image = Image.FromFile(@"../../hangul/F jeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture53 = new PictureBox
            {
                Name = "pictureBox53",
                Image = Image.FromFile(@"../../hangul/F jeu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture54 = new PictureBox
            {
                Name = "pictureBox54",
                Image = Image.FromFile(@"../../hangul/F ji.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture55 = new PictureBox
            {
                Name = "pictureBox55",
                Image = Image.FromFile(@"../../hangul/F jo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture56 = new PictureBox
            {
                Name = "pictureBox56",
                Image = Image.FromFile(@"../../hangul/F ju.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture57 = new PictureBox
            {
                Name = "pictureBox57",
                Image = Image.FromFile(@"../../hangul/F jya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture58 = new PictureBox
            {
                Name = "pictureBox58",
                Image = Image.FromFile(@"../../hangul/F jyeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture59 = new PictureBox
            {
                Name = "pictureBox59",
                Image = Image.FromFile(@"../../hangul/F jyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture60 = new PictureBox
            {
                Name = "pictureBox60",
                Image = Image.FromFile(@"../../hangul/F jyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture61 = new PictureBox
            {
                Name = "pictureBox61",
                Image = Image.FromFile(@"../../hangul/F ka.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture62 = new PictureBox
            {
                Name = "pictureBox62",
                Image = Image.FromFile(@"../../hangul/F kae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture63 = new PictureBox
            {
                Name = "pictureBox63",
                Image = Image.FromFile(@"../../hangul/F keo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture64 = new PictureBox
            {
                Name = "pictureBox64",
                Image = Image.FromFile(@"../../hangul/F keu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture65 = new PictureBox
            {
                Name = "pictureBox65",
                Image = Image.FromFile(@"../../hangul/F ki.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture66 = new PictureBox
            {
                Name = "pictureBox66",
                Image = Image.FromFile(@"../../hangul/F ko.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture67 = new PictureBox
            {
                Name = "pictureBox67",
                Image = Image.FromFile(@"../../hangul/F ku.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture68 = new PictureBox
            {
                Name = "pictureBox68",
                Image = Image.FromFile(@"../../hangul/F kya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture69 = new PictureBox
            {
                Name = "pictureBox69",
                Image = Image.FromFile(@"../../hangul/F kyeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture70 = new PictureBox
            {
                Name = "pictureBox70",
                Image = Image.FromFile(@"../../hangul/F kyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture71 = new PictureBox
            {
                Name = "pictureBox71",
                Image = Image.FromFile(@"../../hangul/F kyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture72 = new PictureBox
            {
                Name = "pictureBox72",
                Image = Image.FromFile(@"../../hangul/F ma.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture73 = new PictureBox
            {
                Name = "pictureBox73",
                Image = Image.FromFile(@"../../hangul/F mae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture74 = new PictureBox
            {
                Name = "pictureBox74",
                Image = Image.FromFile(@"../../hangul/F meo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture75 = new PictureBox
            {
                Name = "pictureBox75",
                Image = Image.FromFile(@"../../hangul/F meu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture76 = new PictureBox
            {
                Name = "pictureBox76",
                Image = Image.FromFile(@"../../hangul/F mi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture77 = new PictureBox
            {
                Name = "pictureBox77",
                Image = Image.FromFile(@"../../hangul/F mo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture78 = new PictureBox
            {
                Name = "pictureBox78",
                Image = Image.FromFile(@"../../hangul/F mu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture79 = new PictureBox
            {
                Name = "pictureBox79",
                Image = Image.FromFile(@"../../hangul/F mya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture80 = new PictureBox
            {
                Name = "pictureBox80",
                Image = Image.FromFile(@"../../hangul/F myeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture81 = new PictureBox
            {
                Name = "pictureBox81",
                Image = Image.FromFile(@"../../hangul/F myo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture82 = new PictureBox
            {
                Name = "pictureBox82",
                Image = Image.FromFile(@"../../hangul/F myu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture83 = new PictureBox
            {
                Name = "pictureBox83",
                Image = Image.FromFile(@"../../hangul/F na.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture84 = new PictureBox
            {
                Name = "pictureBox84",
                Image = Image.FromFile(@"../../hangul/F nae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture85 = new PictureBox
            {
                Name = "pictureBox85",
                Image = Image.FromFile(@"../../hangul/F neo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture86 = new PictureBox
            {
                Name = "pictureBox86",
                Image = Image.FromFile(@"../../hangul/F neu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture87 = new PictureBox
            {
                Name = "pictureBox87",
                Image = Image.FromFile(@"../../hangul/F ni.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture88 = new PictureBox
            {
                Name = "pictureBox88",
                Image = Image.FromFile(@"../../hangul/F no.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture89 = new PictureBox
            {
                Name = "pictureBox89",
                Image = Image.FromFile(@"../../hangul/F nu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture90 = new PictureBox
            {
                Name = "pictureBox90",
                Image = Image.FromFile(@"../../hangul/F nya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture91 = new PictureBox
            {
                Name = "pictureBox91",
                Image = Image.FromFile(@"../../hangul/F nyeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture92 = new PictureBox
            {
                Name = "pictureBox92",
                Image = Image.FromFile(@"../../hangul/F nyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture93 = new PictureBox
            {
                Name = "pictureBox93",
                Image = Image.FromFile(@"../../hangul/F nyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture94 = new PictureBox
            {
                Name = "pictureBox94",
                Image = Image.FromFile(@"../../hangul/F o.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture95 = new PictureBox
            {
                Name = "pictureBox95",
                Image = Image.FromFile(@"../../hangul/F pa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture96 = new PictureBox
            {
                Name = "pictureBo9x6",
                Image = Image.FromFile(@"../../hangul/F pae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture97 = new PictureBox
            {
                Name = "pictureBox97",
                Image = Image.FromFile(@"../../hangul/F peo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture98 = new PictureBox
            {
                Name = "pictureBox98",
                Image = Image.FromFile(@"../../hangul/F peu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture99 = new PictureBox
            {
                Name = "pictureBox99",
                Image = Image.FromFile(@"../../hangul/F pi.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture100 = new PictureBox
            {
                Name = "pictureBox100",
                Image = Image.FromFile(@"../../hangul/F po.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            PictureBox picture101 = new PictureBox
            {
                Name = "pictureBox101",
                Image = Image.FromFile(@"../../hangul/F pu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture102 = new PictureBox
            {
                Name = "pictureBox102",
                Image = Image.FromFile(@"../../hangul/F pya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture103 = new PictureBox
            {
                Name = "pictureBox103",
                Image = Image.FromFile(@"../../hangul/F pyeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture104 = new PictureBox
            {
                Name = "pictureBox104",
                Image = Image.FromFile(@"../../hangul/F pyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture105 = new PictureBox
            {
                Name = "pictureBox105",
                Image = Image.FromFile(@"../../hangul/F pyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture106 = new PictureBox
            {
                Name = "pictureBox106",
                Image = Image.FromFile(@"../../hangul/F ra.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture107 = new PictureBox
            {
                Name = "pictureBox107",
                Image = Image.FromFile(@"../../hangul/F rae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture108 = new PictureBox
            {
                Name = "pictureBox108",
                Image = Image.FromFile(@"../../hangul/F reo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture109 = new PictureBox
            {
                Name = "pictureBox109",
                Image = Image.FromFile(@"../../hangul/F reu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture110 = new PictureBox
            {
                Name = "pictureBox110",
                Image = Image.FromFile(@"../../hangul/F ri.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture111 = new PictureBox
            {
                Name = "pictureBox111",
                Image = Image.FromFile(@"../../hangul/F ro.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture112 = new PictureBox
            {
                Name = "pictureBox112",
                Image = Image.FromFile(@"../../hangul/F ru.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture113 = new PictureBox
            {
                Name = "pictureBox113",
                Image = Image.FromFile(@"../../hangul/F rya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture114 = new PictureBox
            {
                Name = "pictureBox114",
                Image = Image.FromFile(@"../../hangul/F ryeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture115 = new PictureBox
            {
                Name = "pictureBox115",
                Image = Image.FromFile(@"../../hangul/F ryo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture116 = new PictureBox
            {
                Name = "pictureBox116",
                Image = Image.FromFile(@"../../hangul/F ryu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture117 = new PictureBox
            {
                Name = "pictureBox117",
                Image = Image.FromFile(@"../../hangul/F sa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture118 = new PictureBox
            {
                Name = "pictureBox118",
                Image = Image.FromFile(@"../../hangul/F sae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture119 = new PictureBox
            {
                Name = "pictureBox119",
                Image = Image.FromFile(@"../../hangul/F seo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture120 = new PictureBox
            {
                Name = "pictureBox120",
                Image = Image.FromFile(@"../../hangul/F seu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture121 = new PictureBox
            {
                Name = "pictureBox121",
                Image = Image.FromFile(@"../../hangul/F si.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture122 = new PictureBox
            {
                Name = "pictureBox122",
                Image = Image.FromFile(@"../../hangul/F so.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture123 = new PictureBox
            {
                Name = "pictureBox123",
                Image = Image.FromFile(@"../../hangul/F su.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture124 = new PictureBox
            {
                Name = "pictureBox124",
                Image = Image.FromFile(@"../../hangul/F sya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture125 = new PictureBox
            {
                Name = "pictureBox125",
                Image = Image.FromFile(@"../../hangul/F sya2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture126 = new PictureBox
            {
                Name = "pictureBox126",
                Image = Image.FromFile(@"../../hangul/F syeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture127 = new PictureBox
            {
                Name = "pictureBox127",
                Image = Image.FromFile(@"../../hangul/F syu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture128 = new PictureBox
            {
                Name = "pictureBox128",
                Image = Image.FromFile(@"../../hangul/F ta.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture129 = new PictureBox
            {
                Name = "pictureBox129",
                Image = Image.FromFile(@"../../hangul/F ta2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture130 = new PictureBox
            {
                Name = "pictureBox130",
                Image = Image.FromFile(@"../../hangul/F tae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture131 = new PictureBox
            {
                Name = "pictureBox131",
                Image = Image.FromFile(@"../../hangul/F teo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture132 = new PictureBox
            {
                Name = "pictureBox132",
                Image = Image.FromFile(@"../../hangul/F teu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture133 = new PictureBox
            {
                Name = "pictureBox133",
                Image = Image.FromFile(@"../../hangul/F to.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture134 = new PictureBox
            {
                Name = "pictureBox134",
                Image = Image.FromFile(@"../../hangul/F tu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture135 = new PictureBox
            {
                Name = "pictureBox135",
                Image = Image.FromFile(@"../../hangul/F tya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture136 = new PictureBox
            {
                Name = "pictureBox136",
                Image = Image.FromFile(@"../../hangul/F tyeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture137 = new PictureBox
            {
                Name = "pictureBox137",
                Image = Image.FromFile(@"../../hangul/F tyo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture138 = new PictureBox
            {
                Name = "pictureBox138",
                Image = Image.FromFile(@"../../hangul/F tyu.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture139 = new PictureBox
            {
                Name = "pictureBox139",
                Image = Image.FromFile(@"../../hangul/F u.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture140 = new PictureBox
            {
                Name = "pictureBox140",
                Image = Image.FromFile(@"../../hangul/F ya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture141 = new PictureBox
            {
                Name = "pictureBox141",
                Image = Image.FromFile(@"../../hangul/F yeo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture142 = new PictureBox
            {
                Name = "pictureBox142",
                Image = Image.FromFile(@"../../hangul/F yo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture143 = new PictureBox
            {
                Name = "pictureBox143",
                Image = Image.FromFile(@"../../hangul/F yu.png"),
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
                case 105:
                    _pic2 = picture105;
                    break;
                case 106:
                    _pic2 = picture106;
                    break;
                case 107:
                    _pic2 = picture107;
                    break;
                case 108:
                    _pic2 = picture108;
                    break;
                case 109:
                    _pic2 = picture109;
                    break;
                case 110:
                    _pic2 = picture110;
                    break;
                case 111:
                    _pic2 = picture111;
                    break;
                case 112:
                    _pic2 = picture112;
                    break;
                case 113:
                    _pic2 = picture113;
                    break;
                case 114:
                    _pic2 = picture114;
                    break;
                case 115:
                    _pic2 = picture115;
                    break;
                case 116:
                    _pic2 = picture116;
                    break;
                case 117:
                    _pic2 = picture117;
                    break;
                case 118:
                    _pic2 = picture118;
                    break;
                case 119:
                    _pic2 = picture119;
                    break;
                case 120:
                    _pic2 = picture120;
                    break;
                case 121:
                    _pic2 = picture121;
                    break;
                case 122:
                    _pic2 = picture122;
                    break;
                case 123:
                    _pic2 = picture123;
                    break;
                case 124:
                    _pic2 = picture124;
                    break;
                case 125:
                    _pic2 = picture125;
                    break;
                case 126:
                    _pic2 = picture126;
                    break;
                case 127:
                    _pic2 = picture127;
                    break;
                case 128:
                    _pic2 = picture128;
                    break;
                case 129:
                    _pic2 = picture129;
                    break;
                case 130:
                    _pic2 = picture130;
                    break;
                case 131:
                    _pic2 = picture131;
                    break;
                case 132:
                    _pic2 = picture132;
                    break;
                case 133:
                    _pic2 = picture133;
                    break;
                case 134:
                    _pic2 = picture134;
                    break;
                case 135:
                    _pic2 = picture135;
                    break;
                case 136:
                    _pic2 = picture136;
                    break;
                case 137:
                    _pic2 = picture137;
                    break;
                case 138:
                    _pic2 = picture138;
                    break;
                case 139:
                    _pic2 = picture139;
                    break;
                case 140:
                    _pic2 = picture140;
                    break;
                case 141:
                    _pic2 = picture141;
                    break;
                case 142:
                    _pic2 = picture142;
                    break;
                default:
                    _pic2 = picture143;
                    break;
            }



        }

        private void fPeek4(int nValue, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"../../cyrillic/F a.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../cyrillic/F b.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"../../cyrillic/F d.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"../../cyrillic/F e.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"../../cyrillic/F f.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"../../cyrillic/F g.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"../../cyrillic/F i.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"../../cyrillic/F j.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"../../cyrillic/F ja.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"../../cyrillic/F je.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"../../cyrillic/F jo.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"../../cyrillic/F ju.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"../../cyrillic/F k.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"../../cyrillic/F l.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"../../cyrillic/F m.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"../../cyrillic/F n.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"../../cyrillic/F n2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"../../cyrillic/F n3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"../../cyrillic/F n4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"../../cyrillic/F o.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"../../cyrillic/F p.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"../../cyrillic/F r.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"../../cyrillic/F s.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"../../cyrillic/F sh.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"../../cyrillic/F shch.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../cyrillic/F t.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"../../cyrillic/F tch.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"../../cyrillic/F ts.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"../../cyrillic/F u.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"../../cyrillic/F v.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"../../cyrillic/F x.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"../../cyrillic/F z.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"../../cyrillic/F zch.png"),
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
                 default:
                    _pic2 = picture33;
                    break;
            }



        }

        private void fPeek5(int nValue, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"../../georgian/F a.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../georgian/F b.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"../../georgian/F ch.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"../../georgian/F che.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"../../georgian/F d.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"../../georgian/F dz.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"../../georgian/F e.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"../../georgian/F g.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"../../georgian/F gh.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"../../georgian/F h.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"../../georgian/F i.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"../../georgian/F j.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"../../georgian/F ke.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"../../georgian/F kh.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"../../georgian/F kh2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"../../georgian/F l.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"../../georgian/F m.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"../../georgian/F n.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"../../georgian/F o.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"../../georgian/F pe.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"../../georgian/F ph.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"../../georgian/F qe.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"../../georgian/F r.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"../../georgian/F s.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"../../georgian/F sh.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../georgian/F te.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"../../georgian/F th.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"../../georgian/F tse.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"../../georgian/F tsh.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"../../georgian/F u.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"../../georgian/F v.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"../../georgian/F z.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"../../georgian/F zh.png"),
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
                default:
                    _pic2 = picture33;
                    break;
            }



        }

        private void fPeek6(int nValue, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"../../malayalam/F ba.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../malayalam/F bha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"../../malayalam/F ca.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"../../malayalam/F cha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"../../malayalam/F da.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"../../malayalam/F da2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"../../malayalam/F dha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"../../malayalam/F dha2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"../../malayalam/F ga.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"../../malayalam/F gha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"../../malayalam/F ha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"../../malayalam/F ja.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"../../malayalam/F jha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"../../malayalam/F ka.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"../../malayalam/F kha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"../../malayalam/F la.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"../../malayalam/F la2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"../../malayalam/F la3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"../../malayalam/F ma.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"../../malayalam/F na.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"../../malayalam/F na2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"../../malayalam/F na3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"../../malayalam/F nya.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"../../malayalam/F nya2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"../../malayalam/F pa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"../../malayalam/F pha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"../../malayalam/F ra.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"../../malayalam/F ra2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"../../malayalam/F sa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"../../malayalam/F sa2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"../../malayalam/F sae.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"../../malayalam/F ta.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"../../malayalam/F ta2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture34 = new PictureBox
            {
                Name = "pictureBox34",
                Image = Image.FromFile(@"../../malayalam/F ta3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture35 = new PictureBox
            {
                Name = "pictureBox35",
                Image = Image.FromFile(@"../../malayalam/F tha.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture36 = new PictureBox
            {
                Name = "pictureBox36",
                Image = Image.FromFile(@"../../malayalam/F tha2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture37 = new PictureBox
            {
                Name = "pictureBox37",
                Image = Image.FromFile(@"../../malayalam/F va.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture38 = new PictureBox
            {
                Name = "pictureBox38",
                Image = Image.FromFile(@"../../malayalam/F ya.png"),
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
                    default:
                    _pic2 = picture38;
                    break;
            }



        }

        private void fReset()
        {
            Random rnd1 = new Random();
        
            sAnswer1 = null;
            sAnswer2 = null;
            sAnswer3 = null;
            for (int i = 1; i <= 10; i++)
            {
                sAnswer1 = sAnswer1 + " ";
                sAnswer2 = sAnswer2 + "-";
                sAnswer3 = sAnswer3 + "N";
            }
            for (int i = 1; i <= 150; i++)
            {
                _data1[i - 1] = null;
                _data3[i - 1] = null;
                switch (mnMode)
                {
                    case 1:
                        _data2[i - 1] = _lookup1[i - 1];
                        break;
                    case 2:
                        _data2[i - 1] = _lookup2[i - 1];
                        break;
                    case 3:
                        _data2[i - 1] = _lookup3[i - 1];
                        break;
                    case 4:
                        _data2[i - 1] = _lookup4[i - 1];
                        break;
                    case 5:
                        _data2[i - 1] = _lookup5[i - 1];
                        break;
                    default:
                        _data2[i - 1] = _lookup6[i - 1];
                        break;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                _place[i - 1] = rnd1.Next(1, _count[mnMode-1]); 
            }

            txtAnswer1.Text = sAnswer1;
            txtAnswer3.Text = sAnswer3;
            fUpdateStatus();


        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType;

            switch (mnMode)
            {
                case 1:
                    nType = _place[0];
                    fPeek1(nType, ref _pic);
                    pic1.Image = _pic.Image;
                    nType = _place[1];
                    fPeek1(nType, ref _pic);
                    pic2.Image = _pic.Image;
                    nType = _place[2];
                    fPeek1(nType, ref _pic);
                    pic3.Image = _pic.Image;
                    nType = _place[3];
                    fPeek1(nType, ref _pic);
                    pic4.Image = _pic.Image;
                    nType = _place[4];
                    fPeek1(nType, ref _pic);
                    pic5.Image = _pic.Image;
                    nType = _place[5];
                    fPeek1(nType, ref _pic);
                    pic6.Image = _pic.Image;
                    nType = _place[6];
                    fPeek1(nType, ref _pic);
                    pic7.Image = _pic.Image;
                    nType = _place[7];
                    fPeek1(nType, ref _pic);
                    pic8.Image = _pic.Image;
                    nType = _place[8];
                    fPeek1(nType, ref _pic);
                    pic9.Image = _pic.Image;
                    nType = _place[9];
                    fPeek1(nType, ref _pic);
                    pica.Image = _pic.Image;
                    break;
                case 2:
                    nType = _place[0];
                    fPeek2(nType, ref _pic);
                    pic1.Image = _pic.Image;
                    nType = _place[1];
                    fPeek2(nType, ref _pic);
                    pic2.Image = _pic.Image;
                    nType = _place[2];
                    fPeek2(nType, ref _pic);
                    pic3.Image = _pic.Image;
                    nType = _place[3];
                    fPeek2(nType, ref _pic);
                    pic4.Image = _pic.Image;
                    nType = _place[4];
                    fPeek2(nType, ref _pic);
                    pic5.Image = _pic.Image;
                    nType = _place[5];
                    fPeek2(nType, ref _pic);
                    pic6.Image = _pic.Image;
                    nType = _place[6];
                    fPeek2(nType, ref _pic);
                    pic7.Image = _pic.Image;
                    nType = _place[7];
                    fPeek2(nType, ref _pic);
                    pic8.Image = _pic.Image;
                    nType = _place[8];
                    fPeek2(nType, ref _pic);
                    pic9.Image = _pic.Image;
                    nType = _place[9];
                    fPeek2(nType, ref _pic);
                    pica.Image = _pic.Image;
                    break;
                case 3:
                    nType = _place[0];
                    fPeek3(nType, ref _pic);
                    pic1.Image = _pic.Image;
                    nType = _place[1];
                    fPeek3(nType, ref _pic);
                    pic2.Image = _pic.Image;
                    nType = _place[2];
                    fPeek3(nType, ref _pic);
                    pic3.Image = _pic.Image;
                    nType = _place[3];
                    fPeek3(nType, ref _pic);
                    pic4.Image = _pic.Image;
                    nType = _place[4];
                    fPeek3(nType, ref _pic);
                    pic5.Image = _pic.Image;
                    nType = _place[5];
                    fPeek3(nType, ref _pic);
                    pic6.Image = _pic.Image;
                    nType = _place[6];
                    fPeek3(nType, ref _pic);
                    pic7.Image = _pic.Image;
                    nType = _place[7];
                    fPeek3(nType, ref _pic);
                    pic8.Image = _pic.Image;
                    nType = _place[8];
                    fPeek3(nType, ref _pic);
                    pic9.Image = _pic.Image;
                    nType = _place[9];
                    fPeek3(nType, ref _pic);
                    pica.Image = _pic.Image;
                    break;
                case 4:
                    nType = _place[0];
                    fPeek4(nType, ref _pic);
                    pic1.Image = _pic.Image;
                    nType = _place[1];
                    fPeek4(nType, ref _pic);
                    pic2.Image = _pic.Image;
                    nType = _place[2];
                    fPeek4(nType, ref _pic);
                    pic3.Image = _pic.Image;
                    nType = _place[3];
                    fPeek4(nType, ref _pic);
                    pic4.Image = _pic.Image;
                    nType = _place[4];
                    fPeek4(nType, ref _pic);
                    pic5.Image = _pic.Image;
                    nType = _place[5];
                    fPeek4(nType, ref _pic);
                    pic6.Image = _pic.Image;
                    nType = _place[6];
                    fPeek4(nType, ref _pic);
                    pic7.Image = _pic.Image;
                    nType = _place[7];
                    fPeek4(nType, ref _pic);
                    pic8.Image = _pic.Image;
                    nType = _place[8];
                    fPeek4(nType, ref _pic);
                    pic9.Image = _pic.Image;
                    nType = _place[9];
                    fPeek4(nType, ref _pic);
                    pica.Image = _pic.Image;
                    break;
                case 5:
                    nType = _place[0];
                    fPeek5(nType, ref _pic);
                    pic1.Image = _pic.Image;
                    nType = _place[1];
                    fPeek5(nType, ref _pic);
                    pic2.Image = _pic.Image;
                    nType = _place[2];
                    fPeek5(nType, ref _pic);
                    pic3.Image = _pic.Image;
                    nType = _place[3];
                    fPeek5(nType, ref _pic);
                    pic4.Image = _pic.Image;
                    nType = _place[4];
                    fPeek5(nType, ref _pic);
                    pic5.Image = _pic.Image;
                    nType = _place[5];
                    fPeek5(nType, ref _pic);
                    pic6.Image = _pic.Image;
                    nType = _place[6];
                    fPeek5(nType, ref _pic);
                    pic7.Image = _pic.Image;
                    nType = _place[7];
                    fPeek5(nType, ref _pic);
                    pic8.Image = _pic.Image;
                    nType = _place[8];
                    fPeek5(nType, ref _pic);
                    pic9.Image = _pic.Image;
                    nType = _place[9];
                    fPeek5(nType, ref _pic);
                    pica.Image = _pic.Image;
                    break;
                default:
                    nType = _place[0];
                    fPeek6(nType, ref _pic);
                    pic1.Image = _pic.Image;
                    nType = _place[1];
                    fPeek6(nType, ref _pic);
                    pic2.Image = _pic.Image;
                    nType = _place[2];
                    fPeek6(nType, ref _pic);
                    pic3.Image = _pic.Image;
                    nType = _place[3];
                    fPeek6(nType, ref _pic);
                    pic4.Image = _pic.Image;
                    nType = _place[4];
                    fPeek6(nType, ref _pic);
                    pic5.Image = _pic.Image;
                    nType = _place[5];
                    fPeek6(nType, ref _pic);
                    pic6.Image = _pic.Image;
                    nType = _place[6];
                    fPeek6(nType, ref _pic);
                    pic7.Image = _pic.Image;
                    nType = _place[7];
                    fPeek6(nType, ref _pic);
                    pic8.Image = _pic.Image;
                    nType = _place[8];
                    fPeek6(nType, ref _pic);
                    pic9.Image = _pic.Image;
                    nType = _place[9];
                    fPeek6(nType, ref _pic);
                    pica.Image = _pic.Image;
                    break;
            }

        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            mnMode = 1;
            fReset();
            fUpdateDisplay();
            fUpdateList();

        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            mnMode = 2;
            fReset();
            fUpdateDisplay();
            fUpdateList();

        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            mnMode = 3;
            fReset();
            fUpdateDisplay();
            fUpdateList();

        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            mnMode = 4;
            fReset();
            fUpdateDisplay();
            fUpdateList();

        }

        private void btnStart5_Click(object sender, EventArgs e)
        {
            mnMode = 5;
            fReset();
            fUpdateDisplay();
            fUpdateList();

        }

        private void btnStart6_Click(object sender, EventArgs e)
        {
            mnMode = 6;
            fReset();
            fUpdateDisplay();
            fUpdateList();

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            fInput(1, txtInput.Text);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            fInput(2, txtInput.Text);

        }

        private void pic3_Click(object sender, EventArgs e)
        {
            fInput(3, txtInput.Text);

        }

        private void pic4_Click(object sender, EventArgs e)
        {
            fInput(4, txtInput.Text);

        }

        private void pic5_Click(object sender, EventArgs e)
        {
            fInput(5, txtInput.Text);

        }

        private void pic6_Click(object sender, EventArgs e)
        {
            fInput(6, txtInput.Text);

        }

        private void pic7_Click(object sender, EventArgs e)
        {
            fInput(7, txtInput.Text);

        }

        private void pic8_Click(object sender, EventArgs e)
        {
            fInput(8, txtInput.Text);

        }

        private void pic9_Click(object sender, EventArgs e)
        {
            fInput(9, txtInput.Text);

        }

        private void pica_Click(object sender, EventArgs e)
        {
            fInput(10, txtInput.Text);

        }

        private void lstPopup_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lstPopup.SelectedIndex + 1;
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            String sName = "dlg.txt";
            String sSearch = _index[mnMode - 1].Substring(mnItem-1,1); ;
            int nTop, nBottom;

            switch (mnMode)
            {
                case 1:
                    nTop = _index1a[mnItem - 1];
                    nBottom = _index1b[mnItem - 1];
                    break;
                case 2:
                    nTop = _index2a[mnItem - 1];
                    nBottom = _index2b[mnItem - 1];
                    break;
                case 3:
                    nTop = _index3a[mnItem - 1];
                    nBottom = _index3b[mnItem - 1];
                    break;
                case 4:
                    nTop = _index4a[mnItem - 1];
                    nBottom = _index4b[mnItem - 1];
                    break;
                case 5:
                    nTop = _index5a[mnItem - 1];
                    nBottom = _index5b[mnItem - 1];
                    break;
                default:
                    nTop = _index6a[mnItem - 1];
                    nBottom = _index6b[mnItem - 1];
                    break;
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                file.WriteLine("LIST");
                file.WriteLine(Convert.ToString(mnMode));
                file.WriteLine(Convert.ToString(mnItem));
                file.WriteLine(sSearch);
                file.WriteLine(Convert.ToString(nTop));
                file.WriteLine(Convert.ToString(nBottom));
             }

            fPopup _dlg = new fPopup();
            _dlg.ShowDialog();
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            if (txtAnswer1.Text == txtAnswer3.Text)
            {
                fReset();
                fUpdateDisplay();
                fUpdateList();
                txtInput.Text = null;
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            nScore = 0;
            lblScore.Text = "Score = 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnMode = 1;
            fReset();
            fUpdateDisplay();
            fUpdateList();
        }
    }
}
