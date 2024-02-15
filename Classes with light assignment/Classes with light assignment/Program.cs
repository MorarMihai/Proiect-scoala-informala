using System;

namespace Classes_with_light_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ModeleazaCandelabru firstLight = new ModeleazaCandelabru(60,75,100);
            ModeleazaCandelabru secondLight = new ModeleazaCandelabru(40, 60, 75, 75, 100);
            firstLight.AfiseazaStareaCandelabru(firstLight);
            secondLight.AfiseazaStareaCandelabru(secondLight);
            Console.WriteLine("Puteri maxime");
            firstLight.AfiseazaPutereaMaxima();
            secondLight.AfiseazaPutereaMaxima();
            Console.WriteLine("Stare candelabru");
            firstLight.AprindeCandelabrul();
            secondLight.AprindeCandelabrul();
            firstLight.AfiseazaStarea();
            secondLight.AfiseazaStarea();
            Console.WriteLine("Putere curenta");
            firstLight.AfiseazaPutereaCurenta();
            secondLight.AfiseazaPutereaCurenta();
            Console.WriteLine("stare candelabru");
            firstLight.StingeCandelabrul();
            secondLight.StingeCandelabrul();
            firstLight.AfiseazaStareaCandelabrului();
            secondLight.AfiseazaStareaCandelabrului();
            Console.WriteLine("Putere marita cu 80");
            firstLight.MaresteLumina1(80);
            secondLight.MaresteLumina1(80);
            Console.WriteLine("Stare candelabru");
            firstLight.AfiseazaStareaCandelabrului();
            secondLight.AfiseazaStareaCandelabrului();
            Console.WriteLine("Putere curenta");
            firstLight.AfiseazaPutereaCurenta();
            secondLight.AfiseazaPutereaCurenta();
            firstLight.ReduLumina(50);
            secondLight.ReduLumina(50);
            Console.WriteLine("Putere noua dupa reducerea luminii");
            firstLight.AfiseazaPutereaCurenta();
            secondLight.AfiseazaPutereaCurenta();
            Console.WriteLine("Stare candelabru");
            firstLight.AfiseazaStareaCandelabrului();
            secondLight.AfiseazaStareaCandelabrului();
            Console.WriteLine("Putere curenta");
            firstLight.AfiseazaPutereaCurenta();
            secondLight.AfiseazaPutereaCurenta();


        }
    }
}
