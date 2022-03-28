using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCheck
{
    public class Model
    {
        public string Dep { get; set; }
        public List<Unit> lsUnit { get; set; }
    }

    public class Unit 
    {
    public string Name { get; set; }
    public List<string> Phones { get; set; }
    }
}
