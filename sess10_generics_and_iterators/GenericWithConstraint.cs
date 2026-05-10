namespace sess10_generics_and_iterators
{
    /// <summary>
    /// This class demonstrates creating a generic class with constraints. This class will accept a type parameter of type
    /// <see cref="Person"/> or its derived classes.
    /// </summary>
    public class GenericWithConstraint<T> where T : Person
    {
        public List<T> genericPersons = new List<T>();
    }

    public class DemoGenericWithConstraint
    {
        static void Main(string[] args)
        {
            // Declare and instantiate generic classes
            GenericWithConstraint<Student> student = new GenericWithConstraint<Student>();
            GenericWithConstraint<Staff> edulinkStaff = new GenericWithConstraint<Staff>();
            //GenericWithConstraint<string> studentNames = new GenericWithConstraint<string>();

            // Prompt the user for the number of students
            Console.WriteLine("How many students are in the class?");
            int n, numOfPersons = int.Parse(Console.ReadLine());

            try
            {
                // Read in the student's details
                for (n = 0; n < numOfPersons; n++)
                {
                    Console.WriteLine($"Please enter the name of student {n + 1} -> ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine($"Please enter {studentName}'s student number -> ");
                    string studentNo = Console.ReadLine();
                    Console.WriteLine($"Please enter {studentName}'s birth date: ");
                    DateTime dob = DateTime.Parse(Console.ReadLine()); //DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine($"Please enter {studentName}'s binary gender (M/F): ");
                    char gender = char.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {studentName}'s email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine($"Please enter {studentName}'s course: ");
                    string course= Console.ReadLine();
                    Console.WriteLine($"Please enter {studentName}'s Current semester: ");
                    int currSem = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {studentName}'s nationality: ");
                    string nationality = Console.ReadLine();

                    // Add the above details to the student's list
                    student.genericPersons.Add(new Student(studentName, dob, gender, email, nationality, studentNo, course, (byte)currSem));
                }

                // Display each student's details
                foreach (Student s in student.genericPersons)
                    Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.GetType().ToString().Replace("System.", string.Empty)} occured.");
            }


            // TODO 2: Prompt the user for the number of staff members
            Console.WriteLine("How many students are in the class?");
            int numOfStaff = int.Parse(Console.ReadLine());

            try
            {
                // TODO 3: Read in and display the details of at least 3 Edulink staff members.
                for (n = 0; n < numOfStaff; n++)
                {
                    Console.WriteLine($"Please enter the name of staff member {n + 1} -> ");
                    string staffName = Console.ReadLine();
                    Console.WriteLine($"Please enter {staffName}'s staff ID -> ");
                    string staffId = Console.ReadLine();
                    Console.WriteLine($"Please enter {staffName}'s birth date: ");
                    DateTime dob = DateTime.Parse(Console.ReadLine()); //DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine($"Please enter {staffName}'s binary gender (M/F): ");
                    char gender = char.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {staffName}'s email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine($"Please enter {staffName}'s date of employment: ");
                    DateTime empDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {staffName}'s designation/job title: ");
                    string designation = Console.ReadLine();
                    Console.WriteLine($"Please enter {staffName}'s nationality: ");
                    string nationality = Console.ReadLine();

                    // Add the above details to the staff's list
                    edulinkStaff.genericPersons.Add(new Staff(staffName, dob, gender, email, nationality, staffId, empDate, designation));

                    // Display each staff's details
                    foreach (Staff s in edulinkStaff.genericPersons)  
                        Console.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.GetType().ToString().Replace("System.", string.Empty)} occured.");
            }
        }
    }
}
