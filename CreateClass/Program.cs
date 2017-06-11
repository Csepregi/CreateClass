using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person joe = new Employee("Joe", 1987, 500000,"programmer");
            Console.WriteLine(joe);
            Room room = new Room(100);
           
           
            room.roomNumber = 100;
            Console.WriteLine(room.roomNumber);

            Employee Kovacs = new Employee("Géza", 1987, 1000, "léhűtő");
            Kovacs.room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.room.roomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();

            Console.ReadKey(true);

        }
    }
}
