using System.Collections.Generic;
using System.IO;
using System.Linq;
using NETPractice.Polymorphism.ITCompany.Entities.Bugs;

namespace NETPractice.Polymorphism.ITCompany.Entities.Code
{
    public abstract class ProgrammingCode
    {
        private List<Bug> _bugs;

        public ProgrammingCode()
        {
            Bugs = new List<Bug>();
        }

        public ProgrammingCode(List<Bug> bugs)
        {
            Bugs = bugs;
        }
        
        public int StringCount { get; set; }

        public List<Bug> Bugs
        {
            get => _bugs;
            private set
            {
                if (value == null || value.Any(x => x == null))
                {
                    throw new InvalidDataException("list must contain bugs");
                }

                _bugs = value;
            }
        }
    }
    
}
