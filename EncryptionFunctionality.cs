using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.ProgrammingInCSharp10.Models
{
    internal partial class Encryption
    {
        public string GetEncryptCode()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
