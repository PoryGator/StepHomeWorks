
using System.Collections;
using IEnumerable.Enumerators;
using IEnumerable.obj;

namespace IEnumerable.Models;

public class PhoneBook : IEnumerable<PhoneNumber>
{
    public List<PhoneNumber> Numbers { get; set; }

    public ModeEnum EnumMode { get; set; }
    public PhoneBook()
    {
        this.Numbers = new List<PhoneNumber>();
        this.EnumMode = ModeEnum.SortedByName;

    }

    public IEnumerator<PhoneNumber> GetEnumerator()
    {   
        if (EnumMode == ModeEnum.SortedByName)
        {
            return new SortedByName(this.Numbers);
        }

        return new SortedByNumber(this.Numbers);
    }

    IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
