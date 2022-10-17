using Gadajec.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Domain.ValueObjects
{
    public class UserName : ValueObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Surname;  
        }
    }
}
