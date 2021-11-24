
namespace aulas.Entities
{
    class Department
    {
       public string Name { get; set; } // propriedade

       public Department() // construtor
        {
        } 

        public Department(string name)
        {
            Name = name;
        }
    }
}
