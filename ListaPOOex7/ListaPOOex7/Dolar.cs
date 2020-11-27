using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPOOex7
{
    class Dolar
    {
        private double dol;
        private double real;
        private double cot;

        public void setCot(double p)
        {
            cot = p;
        }

        public void setDol(double p)
        {
            dol = p;
        }

        public double getCot()
        {
            return cot;
        }

        public double getDol()
        {
            return dol;
        }

        public double getReal()
        {
            return real;
        }

        public void converterMoeda()
        {
            real = dol * cot;
        }
    }
}
