using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandAndSee
{
    
    class cHouse
    {
        private List<int> _col = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _row = new List<int> { 0, 0, 0, 0, 0, 0 };
        private int mnHouse;

        public void fSet(int nHouse)
        {
            mnHouse = nHouse;
        }
        public void fSet2(int nHouse,int nCol,int nRow)
        {
            mnHouse = nHouse;
            _col[mnHouse - 1] = nCol;
            _row[mnHouse - 1] = nRow;
        }
        public int fGet()
        {
            return mnHouse;
        }

         public int fGetCol()
        {
            return _col[mnHouse -1];
        }
        public int fGetRow()
        {
            return _row[mnHouse - 1];
        }
    }
}
