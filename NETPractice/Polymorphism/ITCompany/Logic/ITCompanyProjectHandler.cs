using System.IO;
using System.Linq;
using NETPractice.Polymorphism.ITCompany.Entities;
using NETPractice.Polymorphism.ITCompany.Entities.Code;
using NETPractice.Polymorphism.ITCompany.Entities.Employees;

namespace NETPractice.Polymorphism.ITCompany.Logic
{
    public class ITCompanyProjectHandler
    {
        public void Work()
        {
            foreach (Project project in ITCompanyDataHolder.Projects)
            {
                WorkAt(project);
            }
        }

        public void WorkAt(Project project)
        {
            if (project == null)
            {
                throw new InvalidDataException("project can't be null");
            }

            foreach (Developer developer in project.Developers)
            {
                ProgrammingCode programmingCode = developer.WriteCode();

                foreach (Tester tester in project.Testers)
                {
                    tester.FindBugs(programmingCode);
                }

                developer.Fix(programmingCode);

                if (programmingCode.Bugs.All(x => x.IsFixed))
                {
                    project.Code.Add(programmingCode);
                }
            }
        }
        
    }
    
}
