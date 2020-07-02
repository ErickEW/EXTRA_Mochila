using System;

namespace Extra_Mochila
{
    class Mochila
    {
       public Objeto[,] backpack;

       public Mochila(Objeto[,] backpack)
       {
           this.backpack = backpack;
       }

       public void Print()
       {
           for (int i = 0; i < 3; i++)
           {
               for (int x = 0; x < 4; x++)
               {
                   Console.Write(backpack[i,x].getInitial() + " ");
               }
               Console.WriteLine();
           }
       }

       public void checkWeight()
       {
           int plus = backpack[0,1].getWeight() + backpack[1,1].getWeight();
           int plus2 = backpack[0,2].getWeight() + backpack[1,2].getWeight();

           if (backpack[0,0].getWeight()!=0 && backpack[0,3].getWeight()!=0)
           {
               Console.WriteLine("No se puede utilizar este espacio");
           }

           if (backpack[2,0].getWeight() < backpack[1,0].getWeight())
           {
               Console.WriteLine("Cuidado! El objeto "+ backpack[2,0].getName() +" esta siendo aplastado por " + backpack[1,0].getName());
           }

            if (backpack[2,1].getWeight() < backpack[1,1].getWeight())
           {
               Console.WriteLine("Cuidado! El objeto "+ backpack[2,1].getName() +" esta siendo aplastado por " + backpack[1,1].getName());
           }

            if (backpack[2,2].getWeight() < backpack[1,2].getWeight())
           {
               Console.WriteLine("Cuidado! El objeto "+ backpack[2,2].getName() +" esta siendo aplastado por " + backpack[1,2].getName());
           }

            if (backpack[2,3].getWeight() < backpack[1,3].getWeight())
           {
               Console.WriteLine("Cuidado! El objeto "+ backpack[2,3].getName() +" esta siendo aplastado por " + backpack[1,3].getName());
           }

            if (backpack[1,1].getWeight() < backpack[0,1].getWeight())
           {
               Console.WriteLine("Cuidado! El objeto "+ backpack[1,1].getName() +" esta siendo aplastado por " + backpack[0,1].getName());
           }
            if (backpack[1,2].getWeight() < backpack[0,2].getWeight())
           {
               Console.WriteLine("Cuidado! El objeto "+ backpack[1,2].getName() +" esta siendo aplastado por " + backpack[0,2].getName());
           }

           else if (backpack[2,0].getWeight() > backpack[1,0].getWeight() && backpack[2,1].getWeight() > backpack[1,1].getWeight() && backpack[1,1].getWeight() > backpack[0,1].getWeight() && backpack[2,2].getWeight() > backpack[1,2].getWeight() && backpack[1,2].getWeight() > backpack[0,2].getWeight() && backpack[2,3].getWeight() > backpack[1,3].getWeight()) 
           {
               Console.WriteLine("Has acomodado bien tus cosas. Puedes empezar tu viaje");
           }
           else if (backpack[1, 1].getWeight() != backpack[0, 1].getWeight() && backpack[1, 1].getWeight() != backpack[2, 1].getWeight() && (backpack[2, 1].getWeight() < plus))
            {
                if (backpack[2, 1].getWeight() < plus)
                {

                    Console.WriteLine(backpack[2, 1].getName() + " esta siendo aplastado");
                }

                else
                {
                    Print();
                }
            }


            else
            {
                Print();
            }
       }
    }
}
