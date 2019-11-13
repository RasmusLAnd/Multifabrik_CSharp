using System;
using static System.Console;

namespace multifabrik_CS
{
    class Candy
    {
        string number, taste;

        public Candy(){}
           
        public string Taste => taste;
        public string Number => number;

        public void SetData()
        {                       
            Write("Taste?                       "); number = ReadLine().ToUpper().Trim();
            Write("Number of pieces?            "); taste = ReadLine().ToUpper().Trim(); 
        }
    }
}

