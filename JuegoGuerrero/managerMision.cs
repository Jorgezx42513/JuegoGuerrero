using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoGuerrero
{
    class managerMision
    {
        public guerrero Player;
        readonly mision MisionAct;
        public managerMision()
        {
            Player = new guerrero();
            MisionAct =  new mision();
        }

        public string InicarMision() {
            string objetos = "";
            MisionAct.objetosMision.ForEach((objeto e) => { objetos += $"nombre:{e._nombreObj},{e._idObj},{e._efecto}"+"\n";  });

            string enemigos = "";
            foreach (var item in MisionAct.enemigosMision)
            {
                enemigos += "Valor:"+ item._vida + "," + item._nivel + "," + item._puntos_de_daño +  "\n";
            }

            string misonInfo = $"Nombre: {MisionAct.nombre}" +  "\n" +
                $"Dificultad: {MisionAct.dificultad}" + "\n" +
                $"estado: {MisionAct.estadoMision}" + "\n" + "\n" +
                $"objetos:" + "\n" + $"{objetos}" + "\n" +
                $"enemigos:" + "\n" + $"{enemigos}" + "\n";
            return misonInfo;
        }

        public void FinalizarMision() {

        }
    }
}
