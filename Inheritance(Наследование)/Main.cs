using Inheritance;
using MainProgram;

namespace MainProgram
{
    public class Student : Helper//класс наследник : базовый класс (так ли это)?
    {
        public int id;
        protected int age;
        public string lastName;
        private string firstName;

        public Student(string nameOne, string nameTwo)//создалм конструктор класса с двумя параметрами
        {
            lastName = nameTwo;
            firstName = nameOne;

        }
        public Student(int a, int b, string nameTwo, string nameOne)
        {
            lastName = nameTwo;
            firstName = nameOne;
            id = a;
            age = b;
        }
        public void SetLastName(string lastname)
        {
            this.lastName = lastName;
        } 
       
        private static void Main(string[] args)
        {
            Student program = new Student(5, 18, "Alex", "Sed");
            Student program1 = program;
            program.SetLastName("++++++++++");
            program.Say();

            Console.WriteLine(program1.id);
            Console.WriteLine(program1.age);
            Console.WriteLine(program1.firstName);
            Console.WriteLine(program1.lastName);

            
        }

        public void Say()
        {



        }
    }
}
class Men//Почему я не могу создать экземпляр этого класса в классе Program?
{
    Men men = new Men();
    Student program1 = new Student("", "");


    public void Hi()
    {
        //program1.Say();
    }
}



