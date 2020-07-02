using System;

namespace Extra_Mochila
{
    class Program
    {
        static void Main(string[] args)
        {
            Objeto Va = new Objeto("V", "Vacio", 0);
            Objeto Pl = new Objeto("Pl", "Platano", 40);
            Objeto Pa = new Objeto("P", "Pan", 70);
            Objeto Ma = new Objeto("Ma", "Manzana", 250);
            Objeto PB = new Objeto("PB", "Papel de Baño", 320);
            Objeto Br = new Objeto("Br", "Brujula", 350);
            Objeto Cu = new Objeto("Cu", "Cuerda", 1000);
            Objeto BA = new Objeto("BA", "Botella de Agua", 1100);

            Mochila backpack = new Mochila(new Objeto[3, 4]{{ Va,   Br,   Ma,   Va },
                                                           { Pa,    BA,   Cu,   Pl },
                                                           { PB,   BA,   Cu,   Pl }});


            backpack.checkWeight();                                               
            
        }
    }
}
