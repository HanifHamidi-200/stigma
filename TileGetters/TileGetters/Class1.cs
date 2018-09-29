using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileGetters
{
   public  class cLookup
    {
        private int mode;  
        public int Mode   
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }

        private int letter;
        public int Letter
        {
            get
            {
                return letter;
            }
            set
            {
                letter = value;
            }
        }

        private int item;
        public int Item
        {
            get
            {
                return item;
            }
            set
            {
                switch (mode)
                {
                    case 1:
                        item = value;
                        break;
                    case 2:
                        item = value+26;
                        break;
                    case 3:
                        item = value+26+26;
                        break;
                    default:
                        item = value+26+26+26;
                        break;
                }
            }
        }
    }
}
