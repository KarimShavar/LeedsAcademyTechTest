using System.Collections.Generic;

namespace TechTest.Repositories.Models 
{
    public class PersonUpdate 
    {
        public bool Authorised { get; set; }
        
        public bool Enabled { get; set; }

        public IEnumerable<Colour> Colours { get; set; }
    }
}
