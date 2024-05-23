using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoGuerrero
{
    class mision
    {
        public int dificultad;
        public List<objeto> objetosMision;
        public List<enemigo> enemigosMision;
        public bool estadoMision;
        public string nombre;
        public mision()
        {
            genNombre();
            genDifilcultad();
            objetosMision = new List<objeto>();
            genObjetos();
            enemigosMision = new List<enemigo>();
            genEnemigos();
        }
        private Random random = new Random();
        private void genObjetos() {
            for (int i = 0; i < 6; i++)
            {
                objeto objeto = new objeto();
                var num = random.Next(1, 3);
                if (num == 1)
                {
                    objeto._idObj = random.Next(1, 4);
                    objeto._nombreObj = "Medicina";
                    if (objeto._idObj == 1)
                    {
                        objeto._efecto = 10;
                    }
                    else
                    {
                        if (objeto._idObj == 2)
                        {
                            objeto._efecto = 20;
                        }
                        else {
                            objeto._efecto = 50;
                        }
                    }
                    objetosMision.Add(objeto);

                }
                else {
                    if (num == 2)
                    {
                        objeto._idObj = random.Next(4, 7);
                        objeto._nombreObj = "Municion volter";
                        if (objeto._idObj == 4)
                        {
                            objeto._efecto = 10;
                        }
                        else
                        {
                            if (objeto._idObj == 5)
                            {
                                objeto._efecto = 20;
                            }
                            else
                            {
                                objeto._efecto = 30;
                            }
                        }
                        objetosMision.Add(objeto);
                    }
                }
            }
        }
        private void genEnemigos()
        {
            for (int i = 0; i < 6; i++)
            {
                enemigo enemigo = new enemigo();
                var num = random.Next(1, 4);
                enemigo._nivel = num;
                enemigo._puntos_de_daño = 10 * num;
                enemigo._vida = 50 * num;
                enemigosMision.Add(enemigo);
            }

        }
        private void genDifilcultad()
        {
            dificultad = random.Next(1,11);
        }
        private void genNombre()
        {
            int num = random.Next(1, 4);
            if (num == 1)
            {
                nombre = "Signus Prime";
            }
            else {
                if (num == 2)
                {
                    nombre = "Hyperion";
                }
                else {
                    nombre = "Calivan";
                }
            }
        }
    }
}
