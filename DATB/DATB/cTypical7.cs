using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATB
{
    class cTypical7
    {

        private List<String> _col1 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col3 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col4 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col5 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col6 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col7 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private int mnRecord;

        public void fSet(int nRecord)
        {
            mnRecord = nRecord;
        }
        public void fSet2(int nRecord, String s1, String s2, String s3, String s4, String s5, String s6,String s7)
        {
            mnRecord = nRecord;
            _col1[mnRecord - 1] = s1;
            _col2[mnRecord - 1] = s2;
            _col3[mnRecord - 1] = s3;
            _col4[mnRecord - 1] = s4;
            _col5[mnRecord - 1] = s5;
            _col6[mnRecord - 1] = s6;
            _col7[mnRecord - 1] = s7;

        }

        public int fGet()
        {
            return mnRecord;
        }

        public String fGetCol(int nCol)
        {
            switch (nCol)
            {
                case 1:
                    return _col1[mnRecord - 1];
                case 2:
                    return _col2[mnRecord - 1];
                case 3:
                    return _col3[mnRecord - 1];
                case 4:
                    return _col4[mnRecord - 1];
                case 5:
                    return _col5[mnRecord - 1];
                case 6:
                    return _col6[mnRecord - 1];
                default:
                    return _col7[mnRecord - 1];
            }

        }
    }
}
