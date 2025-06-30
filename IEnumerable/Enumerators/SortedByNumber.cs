
using System.Collections;
using IEnumerable.Models;

namespace IEnumerable.Enumerators
{
    class SortedByNumber : IEnumerator<PhoneNumber>
    {   
        public int counter { get; set; }

        public List<PhoneNumber> SortedByPhoneNumber { get; set; }
        public PhoneNumber Current => this.SortedByPhoneNumber[counter++];

        object IEnumerator.Current => Current;


        public SortedByNumber(List<PhoneNumber> phoneNumbers)
        {
            this.SortedByPhoneNumber = phoneNumbers
                .OrderBy(num => num.Number)
                .ToList();
            Reset();
        }

        public bool MoveNext()
        {
            if (this.SortedByPhoneNumber.Count <= counter)
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