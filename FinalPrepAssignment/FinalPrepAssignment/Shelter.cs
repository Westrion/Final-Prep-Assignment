using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrepAssignment {
    class Shelter<A> {

        private List<A> _Inhabitants;

        public List<A> Inhabitants {
            get {
                if (_Inhabitants == null) _Inhabitants = new List<A>();
                return _Inhabitants;
            }
             set { _Inhabitants = value; }
        }
       
    }
}
