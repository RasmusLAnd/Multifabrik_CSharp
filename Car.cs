using System;
using static System.Console;
using System.Collections.Generic;

namespace multifabrik_CS
{
    public class Car
    {   
        string number, color, brand;

        public Car(){}
              
        public string Number => number;
        public string Color => color;
        public string Brand=> brand;

        public void SetData()
        {                       
            Write("Number plate?                       "); number = ReadLine().ToUpper().Trim();
            Write("Color?                              "); color = ReadLine().ToUpper().Trim(); 
            Write("Brand?                              "); brand = ReadLine().ToUpper().Trim();
        }
    }
}