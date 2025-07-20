using demo.Enums;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region enums
            #region ex1
            //Person p = new Person();
            //p.Id = 1;
            //p.Name = "raghad";
            //p.Gender = Gender.female;

            //Grade g= new Grade();
            //Console.WriteLine(g);

            #endregion

            #region Ex 02
            //Student student = new Student();
            //bool isParsed;

            //Console.WriteLine("Please Enter Student Data :");

            //// Get and validate ID
            //Console.WriteLine("Id => ");
            //int id;
            //do
            //{
            //    isParsed = int.TryParse(Console.ReadLine(), out id);
            //} while (!isParsed);
            //student.Id = id;

            //// Get Name
            //Console.WriteLine("Name => ");
            //student.Name = Console.ReadLine();


            //Console.WriteLine("gender => ");
            //object genderInput;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out genderInput);
            //} while (!isParsed);
            //student.Gender=(Gender)genderInput;

            //Console.WriteLine("Grade => ");
            //object gradeInput;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(Grade), Console.ReadLine(), true, out gradeInput);
            //} while (!isParsed);
            //student.Grade = (Grade)gradeInput;
            //Console.WriteLine($"Name {student.Name} , Id {student.Id} , Gender {student.Gender} , grade {student.Grade}");
            #endregion
            #region ex3
            //User user = new User();

            //user.Id = 1;

            //user.Permissions[0] = true; // Write [true, false, true, false]
            //user.Permission = (Permission)4;
            //user.Permission = (Permission)15;
            //Console.WriteLine(user.Permission);

            //user.Permission = user.Permission ^ Permission.Read;
            //Console.WriteLine(user.Permission);

            //user.Permission = user.Permission ^ Permission.Read;
            //Console.WriteLine(user.Permission);

            //user.Permission = user.Permission | Permission.Delete;
            //Console.WriteLine(user.Permission);

            //user.Permission = user.Permission & Permission.Write;
            //Console.WriteLine(user.Permission);


            //Console.WriteLine(user.Permission);
            #endregion
            #region method
            //string branch = "Alex";

            //Branch branch1 = (Branch)Enum.Parse(typeof(Branch), branch);

            //string[] branchesNames = Enum.GetNames(typeof(Branch));

            //foreach (string branchName in branchesNames)
            //    Console.WriteLine(branchName);

            //Array branchesValues = Enum.GetValues(typeof(Branch));

            //foreach (var branchValue in branchesValues)
            //    Console.WriteLine((int)branchValue);

            //bool isExist = Enum.IsDefined(typeof(Branch), 70);

            //Console.WriteLine(isExist);
            #endregion
            #endregion
        }
    }
}
