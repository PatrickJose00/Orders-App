using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto
{
    class ModelExeption:Exception
    {
        public ModelExeption(string msg) : base(msg)
        {

        }
    }
}
