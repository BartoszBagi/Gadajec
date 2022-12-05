using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Domain.Exceptions
{
    public class EncryptorException : Exception
    {
        public EncryptorException(string password, Exception ex) : base($"Password \"{password}\"is invalid.", ex)
        {

        }
    }
}
