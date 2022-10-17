using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Common.Helpers
{
    public class Encryptor : IEncryptor
    {
        public string Decrypt(string encryptedPassword)
        {
            var result = "";
            try
            {
                byte[] encodedDataAsBytes = System.Convert.FromBase64String(encryptedPassword);
                result = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);

                return (result);
            }
            catch (Exception ex)
            {

                throw new EncryptorException(encryptedPassword, ex);
            }
            
        }

        public string Encrypt(string password)
        {
            var result = "";
            try
            {
                byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(password);
                result = Convert.ToBase64String(toEncodeAsBytes);

                return (result);
            }
            catch (Exception ex)
            {

                throw new EncryptorException(password, ex);
            }
            
        }
    }
}
