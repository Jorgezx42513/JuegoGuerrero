using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoGuerrero
{
    class objeto
    {
        public int _idObj;
        private int idObj { 
            get { return _idObj; }
            set { _idObj = value; } 
        }

        public string _nombreObj;
        private string nombreObj{ 
            get { return _nombreObj; }
            set { _nombreObj = value; }
        }

        public int _efecto;
        private int  efecto {
            get { return _efecto; }        
            set { _efecto = value; }
        }
    }
}
