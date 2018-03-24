using System;
using NETPractice.Polymorphism.ITCompany.Entities;
using NETPractice.Polymorphism.ITCompany.Entities.Employees;
using NETPractice.Polymorphism.TransportCompany.Entities;
using NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport;
using NETPractice.Polymorphism.TransportCompany.Logic;
using NETPractice.Polymorphism.ITCompany.Logic;

namespace NETPractice 
{
    internal class Program 
    {       
        public static void Main(string[] args)
        {
            TransportCompanyDataHolder.Add(
                new Car {
                    Speed = 60.0,
                    ElevatingCapacity = 300.0,
                    Brand = "Jeep",
                    StaffCount = 2,
                    PassengerCount = 2
                }
            );
            
            TransportCompanyDataHolder.Add(
                new Helicopter {
                    Speed = 100.0,
                    ElevatingCapacity = 200.0,
                    Brand = "MI",
                    StaffCount = 4,
                    PassengerCount = 0
                }
            );

            string result = TransportCompanyOrderHandler.Accept(
                new Order {
                    Cargo = new Cargo {
                        Content = "Pizza Pepperoni",
                        Weight = 10.0
                    },
                    DestinationAddress = "Saratov, ulitsa Volskaya, 10a, 416"
                }
            );
            
            Console.WriteLine(result);
            
            // ===============================

            Project project = new Project(
                "Большая Дагга", 
                new Customer("Трофилиус Данила Людвикович")
            );
            
            project.Developers.Add(
                new FrontendDeveloper {
                    Level = "Developer",
                    Name = "Петров Афанасий Егорович",
                    StartWorkingDate = new DateTime(2013, 11, 5)
                }
            );
            
            project.Developers.Add(
                new BackendDeveloper {
                    Level = "Senior",
                    Name = "Афанасьев Пётр Егорович",
                    StartWorkingDate = new DateTime(2010, 1, 23)
                }
            );
            
            project.Testers.Add(
                new AutomatedTestingTester {
                    Level = "Junior",
                    Name = "Егоров Афанасий Петрович",
                    StartWorkingDate = new DateTime(2017, 3, 5)
                }
            );
            
            project.Testers.Add(
                new ManualTestingTester {
                    Level = "Junior",
                    Name = "Афанасьев Егор Петрович",
                    StartWorkingDate = new DateTime(2017, 5, 3)
                }
            );
            
            ITCompanyDataHolder.Projects.Add(project);
            
            ITCompanyProjectHandler.Work();
        }

    }

}
