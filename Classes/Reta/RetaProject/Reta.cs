using System;
using System.Collections.Generic;
using System.Text;

namespace RetaProject
{
    class Reta
    {       
        private Ponto ponto_1 = new Ponto();
        private Ponto ponto_2 = new Ponto();

        public Reta()
        {
            ponto_1.setx(0);
            ponto_1.sety(0);
            ponto_2.setx(0);
            ponto_2.sety(0);
        }

        public Reta(int x1,int x2, int y1, int y2)
        {
            ponto_1.setx(x1);
            ponto_1.sety(y1);
            ponto_2.setx(x2);
            ponto_2.sety(y2);
        }
        
        public Reta(Ponto ponto1, Ponto ponto2)
        {
            ponto_1 = ponto1;
            ponto_2 = ponto2;
        }

        public override string ToString()
        {
            return "Os pontos são (" + ponto_1 + "," + ponto_2 + ")";
        }
    }
}

