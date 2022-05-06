public enum Gender
{
    Male = 1,
    Female = 2,
    Dinosaurio = 3,
    Helicoptero = 4,
    Tractor = 5,
}

public class BaseEntity
{ 
    public int Id { get; set; } 

}

public class Person : BaseEntity 
{
    public string? Name { get; set; }
    public Gender Gender { get; set; }
    public int Age { get; set; }

    public Person(int Id,string Name, Gender Gender, int Age)
    {
        this.Id = Id;
        this.Name = Name;
        this.Gender = Gender;
        this.Age = Age;

    } 
    public void createPerson()
    {
        Person Person1 = new Person(Id, Name, Gender, Age);


        Console.WriteLine("Ingrese Id");
        Person1.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese Nombre");
        Person1.Name = Console.ReadLine();

        Console.WriteLine("Ingrese edad");
        Person1.Age = int.Parse(Console.ReadLine());


    }
    public void Main(string[] args)
    {
        createPerson();
        
    }


}






