using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo_2
{
    class Object
    {
        private string name { get; set; }
        private static long nextId = 1;
        private long id = nextId++;

        public Object(string name)
        {
            if (name != null)
            {
                this.name = name;
              //  this.id++;
            }
        }

        public override string ToString()
        {
            return String.Format("id {0}: {1}\n", id, name );
        }
    }
}
