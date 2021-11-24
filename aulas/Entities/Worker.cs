using aulas.Entities.Enums;

namespace aulas.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel  Level{ get; set; }
        public double BaseSalary { get; set; }
        public Department Departament { get; set; }


        public Worker()
        {
        }

        public Worker(string name, int workeLevel, double baseSalary)
        {
            Name = name;
            WorkeLevel = workeLevel;
            BaseSalary = baseSalary;
        }
    }
}
