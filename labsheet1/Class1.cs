using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1
{
    public abstract class Band
    {
        public string Bandname { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }

    
    public class RockBand : Band 
    {
            public override string ToString()
            {
                return (this.Bandname + " - Rock");
            }
        }
        public class PopBand : Band
        {
            public override string ToString()
            {
                return (this.Bandname + " - Pop");
            }
        }
        public class IndieBand : Band
        {
            public override string ToString()
            {
                return (this.Bandname + " - Indie");
            }
        }
    }      
}
