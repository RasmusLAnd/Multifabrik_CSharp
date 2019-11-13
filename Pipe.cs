using System;
using static System.Console;

namespace multifabrik_CS
{
    class Pipe
    {
        string diameter, length;

        public Pipe(){}       

        public string Diameter => diameter;
        public string Length => length;

        public void SetData()
        {                       
            Write("Diameter?                            "); diameter = ReadLine().ToUpper().Trim();
            Write("Length?                              "); length = ReadLine().ToUpper().Trim(); 
        }
    }

}