namespace NETPractice.Polymorphism.ITCompany.Entities.Bugs
{
    public abstract class Bug
    {
        public Bug() { }

        public Bug(bool isFixed)
        {
            IsFixed = isFixed;
        }
        
        public bool IsFixed { get; set; }
        
    }   
}
