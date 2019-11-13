using System;
using static System.Console;

namespace multifabrik_CS
{
    class Milk{
        
        string fat, volume;

        public Milk(){}       
        
        public string Fat => fat;
        public string Volume => volume;

        public void SetData()
        {                       
            Write("Fat - %?                       "); fat = ReadLine().ToUpper().Trim();
            Write("Volume - L?                    "); volume = ReadLine().ToUpper().Trim(); 
        }
    }

}