﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Application.Common.Interfaces
{
    public interface IEncryptor
    {
        string Encrypt(string password);
        string Decrypt(string encryptedPassword);
    }
}
