using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1
{
    public class Band
    {
        public string Bandname { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }

    
    public Band(string name, int yearformed, string members)
    {
            Bandname = name;
            YearFormed = yearformed;
            Members = members;

          

    }
    public override string ToString()
    {
        //formatting string

        return $"{Bandname}\t{YearFormed}\t{Members}";
    }
    }
}
