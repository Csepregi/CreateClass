using System;

namespace CreateClass
{
   public class Person
    {
        protected string name;
        protected int birthDate;

        enum Genders {Male, Female};

       public Person(string name, int birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
            
        }

        public string getName
        {
            get => name;
            set => name = value;
        }

        public int getbirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }



        public override string ToString()
        {
            return name + " " + birthDate + " " ;
        }
    }
}