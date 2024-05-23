using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoGuerrero
{
    class enemigo
    {
        public int _vida;
        private int vida {
            get { return _vida; }
            set { _vida = value; }
        }
        public float _puntos_de_daño;
        private float puntos_de_daño
        {
            get { return _puntos_de_daño; }
            set { _puntos_de_daño = value; }
        }
        public  int _nivel;
        private int nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        public void atacar(guerrero guerrero) {

        }
        public void morir() { 

        }



    }
}
