
namespace IEnumerable.Models;

public class PhoneNumber
{
    public Person Person { get; set; }
    public string Number { get; set; }

    public PhoneNumber(string number, string name, string surname, Gender gender)
    {
        this.Number = number;
        this.Person = new Person(name, surname, gender);
        
    }
}
