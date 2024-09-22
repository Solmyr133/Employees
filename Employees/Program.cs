namespace Employees
{
    class Employee {
        private int id;
        private string name;
        private int age;
        private int salary;

        public Employee(int id, string name, int age, int salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public override string? ToString()
        {
            return $"Név: {this.name}";
        }
    }
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void ReadFromFile()
        {
            string[] rawFileData = File.ReadAllLines("tulajdonsagok_100sor.txt");

            foreach (var item in rawFileData)
            {
                string[] splitItem = item.Split(";");

                employees.Add(new Employee(Convert.ToInt32(splitItem[0]), splitItem[1], Convert.ToInt32(splitItem[2]), Convert.ToInt32(splitItem[3])));
            }
        }

        static void Main()
        {
            // 1. - 2. Feladat
            ReadFromFile();

            // 3. Feladat
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
