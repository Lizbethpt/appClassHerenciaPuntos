using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaPuntos
{
    class Punto
    {
        protected double x;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public Punto()
        {
            x = 0;
        }
        public Punto(double x)
        {
            this.x = x;
        }
        
        public override string ToString()
        {
            return "X=" + x;
        }
    }
}
