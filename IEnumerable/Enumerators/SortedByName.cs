
using System.Collections;
using IEnumerable.Models;

namespace IEnumerable.Enumerators
{   

    class SortedByName : IEnumerator<PhoneNumber>
    {
        public int counter { get; set; }

        public List<PhoneNumber> PhoneNumbersSortedByName{ get; set; }
        public PhoneNumber Current => PhoneNumbersSortedByName[counter++];

        object IEnumerator.Current => Current;

        public SortedByName(List<PhoneNumber> phoneNumbers)
        {
            this.PhoneNumbersSortedByName = phoneNumbers
                .OrderBy(number => number.Person.Name)
                .ThenBy(number => number.Person.Surname)
                .ToList();
            Reset();
        }


        public bool MoveNext()
        {
            if (this.PhoneNumbersSortedByName.Count <= counter)
            {
                Reset();
                return false;
            }
            return true;

        }

        public void Reset()
        {
            this.counter = 0;
        }
        public void Dispose()
        {

        }
    }
}