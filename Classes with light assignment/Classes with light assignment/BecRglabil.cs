using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_with_light_assignment
{
    class BecRglabil
    {
        private double _putereMaxima;
        private double _putereCurenta;
        private bool esteAprins;

        public BecRglabil(double putereCurenta,double putereMaxima)
        {
            _putereMaxima = putereMaxima;
            _putereCurenta = putereCurenta;
        }
        public double PutereCurenta
        {
            get { return _putereCurenta; }
        }

        public void SeteazaPutereCurenta(int putere)
        {
            if (putere >= 0 && putere <= _putereMaxima)
            {
                _putereCurenta = putere;
            }
        }
        public double PutereMaxima
        {
            get { return _putereMaxima; }
        }
        public bool Aprins
        {
            get { return _putereCurenta > 0; }
        }
        public double Aprinde()
        {
            return _putereCurenta = _putereMaxima;
        }
        public double Stinge()
        {
            return _putereCurenta = 0;
        }

        public void MaresteLumina(double valoare)
        {
            double newPower = _putereCurenta + valoare;
            if (newPower > _putereMaxima)
            {
                _putereCurenta = _putereMaxima + valoare;
            }
            else
            {
                _putereCurenta = newPower;
            }
        }
        public void ReduceLumina(double valoare)
        {
            double newPower = _putereCurenta - valoare;
            if (newPower < 0)
            {
                _putereCurenta = _putereCurenta;
            }
            else
            {
               _putereCurenta = newPower;
            }
        }
    }
}
