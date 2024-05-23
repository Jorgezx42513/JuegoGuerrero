using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoGuerrero
{
    class mochila
    {
        protected List<objeto> mochilaContent;
        private int capacidad;

        public mochila()
        {
            mochilaContent = new List<objeto>();
            capacidad = 10;
        }

        protected void agregarObj(objeto objeto) {
            if (mochilaContent.Count < capacidad) {
                mochilaContent.Add(objeto);
            }
        }

        protected void desecharObj(int idObj) {

        }

        protected void userObj(guerrero guerrero) { 

        }


    }
}
