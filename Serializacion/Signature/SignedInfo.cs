using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion.Signature
{
    public class SignedInfo
    {
        public string CanonicalizationMethod;
        public string SignatureMethod;
        public Reference Reference;
    }
}
