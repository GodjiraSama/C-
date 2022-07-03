using System;
using System.Collections.Generic;
using System.Text;

namespace RetaProject
{
    class Ponto
    {
        private int x;
        private int y;


        public Ponto()
        {
            x = 0;
            y = 0;
        }

        public Ponto(int x1, int y1)
        {
            this.x = x1;
            this.y = y1;
        }

        public Ponto(Ponto p)
        {
            this.x = p.getx();
            this.y = p.gety();
        }

        public int getx()
        {
            return x;
        }

        public int gety()
        {
            return y;
        }

        public void setx(int x1)
        {
            x = x1;
        }
        public void sety(int y1)
        {
            x = y1;
        }

        public override string ToString()
        {
            return "As coordenadas do ponto são (" + x + "," + y + ")";
        }
    }
}
