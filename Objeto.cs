using System;

namespace Extra_Mochila
{
    class Objeto
    {
        public string initial {get; set;}

        public string name {get; set;}

        public int weight {get; set;}

        public Objeto(string initial, string name, int weight)
        {
            this.initial = initial;
            this.name = name;
            this.weight = weight;
        }

        public string getInitial()
        {
            return initial;
        }

        public string getName()
        {
            return name;
        }

        public int getWeight()
        {
            return weight;
        }
    }
}
