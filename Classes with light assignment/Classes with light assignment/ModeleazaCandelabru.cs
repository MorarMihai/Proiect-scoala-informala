using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_with_light_assignment
{
    class ModeleazaCandelabru
    {
        private BecRglabil[] _becuri;
        private int putereCurenta;
        private int putereMaxima;
        private int _putereCurentaTotal = 0;

        public ModeleazaCandelabru(params double[] puterimaxime)
        {
            _becuri = new BecRglabil[puterimaxime.Length];
            for(int i = 0;i < puterimaxime.Length; i++)
            {
                _becuri[i] = new BecRglabil(0, puterimaxime[i]);
            }
        }
         public bool Aprins
        {
            get
            {
                foreach(var bec in _becuri)
                {
                    if (bec.Aprins)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public double PutereCurenta
        {
            get
            {
                double putereTotala = 0;
                foreach(var bec in _becuri)
                {
                    putereTotala += bec.PutereCurenta;
                }
                return putereTotala;
            }
        }
        public double PutereMaxima
        {
            get
            {
                double putereTotalaMaxima = 0;
                foreach (var bec in _becuri)
                {
                    putereTotalaMaxima += bec.PutereMaxima;
                }
                return putereTotalaMaxima;
            }
        }
        public void Aprinde()
        {
            foreach (var bec in _becuri)
            {
                bec.Aprinde();
            }
        }
        public void Stinge()
        {
            foreach(var bec in _becuri)
            {
                bec.Stinge();
            }
        }
        public void MaresteLumina2(int a)
        {
            foreach(var bec in _becuri)
            {
                bec.MaresteLumina(80);
            }
        }
        public void ReduceLumina()
        {
            double valoareImplicita = 0; // sau orice altă valoare implicită dorești
            foreach (var bec in _becuri)
            {
                bec.ReduceLumina(valoareImplicita);
            }
        }
        //public void ReduceLumina()
        //{
        //    foreach(var bec in _becuri)
        //    {
        //        bec.ReduceLumina();
        //    }
        //}
        public void AfiseazaStareaCandelabru(ModeleazaCandelabru candelabru)
        {
            if (candelabru.Aprins)
            {
                Console.WriteLine("Candelabrul este aprins.");
            }
            else
            {
                Console.WriteLine("Candelabrul este stins.");
            }
        }
        public void AfiseazaPutereaMaxima()
        {
            double putereMaximaTotala = 0;
            foreach (var bec in _becuri)
            {
                putereMaximaTotala += bec.PutereMaxima;
            }
            Console.WriteLine($"Puterea maxima a candelabrului este: {putereMaximaTotala}");
        }
        public void AprindeCandelabrul()
        {
            foreach (var bec in _becuri)
            {
                bec.Aprinde();
            }
            Console.WriteLine("Candelabrul a fost aprins.");
        }
        public void AfiseazaStarea()
        {
            for (int i = 0; i < _becuri.Length; i++)
            {
                if (_becuri[i].Aprins)
                {
                    Console.WriteLine($"Candelabrul {i + 1} este aprins.");
                }
                else
                {
                    Console.WriteLine($"Candelabrul {i + 1} este stins.");
                }
            }
        }
        public void AfiseazaPutereaCurenta()
        {
            for (int i = 0; i < _becuri.Length; i++)
            {
                Console.WriteLine($"Puterea curentă a candelabrului {i + 1} este: {_becuri[i].PutereCurenta}");
            }
        }
        public void StingeCandelabrul()
        {
            foreach (var bec in _becuri)
            {
                bec.Stinge();
            }
            Console.WriteLine("Candelabrul a fost stins.");
        }
        public void AfiseazaStareaCandelabrului()
        {
            for (int i = 0; i < _becuri.Length; i++)
            {
                if (_becuri[i].Aprins)
                {
                    Console.WriteLine($"Candelabrul {i + 1} este aprins.");
                }
                else
                {
                    Console.WriteLine($"Candelabrul {i + 1} este stins.");
                }
            }
        }
        public void MaresteLumina1(int a)
        {
            foreach (var candelabru in _becuri)
            {
                candelabru.MaresteLumina(80);
            }
            Console.WriteLine("Lumina a fost mărită cu 80 la fiecare obiect Candelabru.");
        }
       public void ReduLumina(int a)
        {
            foreach(var candelabru in _becuri)
            {
                candelabru.ReduceLumina(50);
            }
        }
    }
}
