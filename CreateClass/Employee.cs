using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{

   public class Employee : Person, ICloneable
    {
        protected int salary { get; set; }
        protected string profession { get; set; }
        public Room room;

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            return newEmployee;
        }

        public Employee(string name, int birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            this.name = name;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return base.ToString() + salary + " " + profession;
        }

       

    }
    

}

