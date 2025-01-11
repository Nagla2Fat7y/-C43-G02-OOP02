
namespace Ass2
{
    
    internal struct  Person
    {
        #region Question 1

        //Attributes
        private string? Name;
         private int Age;

        //properties
        public string? name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int age
        {
             get { return Age; }
             set { Age = value; }
        }
        //Constructor
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }


        public override string ToString()
        {
            return $"Name:{Name}\tAge:{Age}";
        }

    }
    #endregion
}
