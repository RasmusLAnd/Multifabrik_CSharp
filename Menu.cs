using System;
using static System.Console;
using System.Collections.Generic;

namespace multifabrik_CS
{
    class Menu
    {
        public void Welcome()
        {
            int valg, valg2;

            List<Car> CarList= new List<Car>(); 
            List<Candy> CandyList= new List<Candy>(); 
            List<Pipe> PipeList= new List<Pipe>(); 
            List<Milk> MilkList= new List<Milk>(); 

            do 
            {

             WriteLine("\n\t  Welcome to The MultiFabrik  ");

                    WriteLine("\tNew Car         -           enter 1 ");
                    WriteLine("\tNew Candy       -           enter 2 ");
                    WriteLine("\tNew Pipe        -           enter 3 ");    
                    WriteLine("\tNew Oatmilk     -           enter 4 ");
                    WriteLine("\tSee all items   -          enter 5 ");
                    WriteLine("\tEnd program     -          enter 9 ");
                    Write("\tIndtast dit valg        -           ");
                    
                    valg = Convert.ToInt32(ReadLine());

                    switch (valg)
                        {
                            case 1:
                            WriteLine("Creating a new car");
                            Car automobile= new Car();
                            automobile.SetData();
                            CarList.Add(automobile);                               
                            break;

                            case 2:
                            WriteLine("Creating new candy"); 
                            Candy sweets= new Candy();
                            sweets.SetData();
                            CandyList.Add(sweets);                            
                            break;

                            case 3:
                            WriteLine("Creating a new pipe");  
                            Pipe tube= new Pipe();
                            tube.SetData();
                            PipeList.Add(tube);                             
                            break;

                            case 4:
                            WriteLine("Creating new oatmilk");      
                            Milk milk = new Milk();
                            milk.SetData();  
                            MilkList.Add(milk);                     
                            break;

                            case 5:                           

                                WriteLine("\n\t  See selected items ");

                                WriteLine("\tListed Cars         -           enter 1 ");
                                WriteLine("\tListed Candy        -           enter 2 ");
                                WriteLine("\tListed Pipes        -           enter 3 ");    
                                WriteLine("\t Listed Oatmilk     -           enter 4 ");
                                WriteLine("\tSee all items       -           enter 5 ");
                                
                                valg2 = Convert.ToInt32(ReadLine());

                                switch (valg2)
                                {
                                    
                                case 1:
                                foreach (Car c in CarList){
                                WriteLine($"{c.Number} {c.Color}  {c.Brand} "); }
                                break;

                                case 2:
                                foreach (Candy c in CandyList){
                                WriteLine($"{c.Taste} {c.Number} "); }
                                break;

                                case 3:
                                foreach (Pipe p in PipeList){
                                WriteLine($"{p.Diameter} {p.Length} "); }
                                break;

                                case 4:
                                foreach (Milk m in MilkList){
                                WriteLine($"{m.Fat} {m.Volume} "); }
                                break; 

                                case 5:
                                WriteLine("In list of cars");
                                foreach (Car c in CarList){
                                WriteLine($"{c.Number} {c.Color}  {c.Brand} "); }

                                WriteLine("in list of Candy");
                                foreach (Candy c in CandyList){
                                WriteLine($"{c.Taste} {c.Number} "); }

                                WriteLine("in list of pipes");
                                foreach (Pipe p in PipeList){
                                WriteLine($"{p.Diameter} {p.Length} "); }

                                WriteLine("in list of Milk");
                                foreach (Milk m in MilkList){
                                WriteLine($"{m.Fat} {m.Volume} "); }
                                
                                break; 
                                }

                            break;
                           

                            case 9:
                            WriteLine("Exiting Program");                            
                            break;

                        }                        
            }while (valg != 9);
        }

    }
}