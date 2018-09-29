using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandAndSee
{
    

    class cFloat
    {
        private int mnCol,mnRow,mnRotate;
    
        public void fSet(int nCol,int nRow,int nRotate)
        {
            mnCol = nCol;
            mnRow = nRow;
            mnRotate = nRotate;
        }
        
        public int fGetCol()
        {
            return mnCol;
        }
        public int fGetRow()
        {
            return mnRow;
        }
        public int fGetRotate()
        {
            return mnRotate;
        }


    }
}
