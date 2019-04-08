using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrepAssignment {
    class Rabbit: Animal {



        private int _Length;
       

        public int Length {
            get { return _Length; }
            set { _Length = value; }
        }

        public Rabbit(string name) {
            Name = name;
        }

        public override string ToString() {
            return "%" + Name;
        }

    }
}
