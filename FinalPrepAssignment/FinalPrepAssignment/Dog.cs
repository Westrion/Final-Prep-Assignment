using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrepAssignment {
    class Dog:Animal {

        private int _Height;
        private bool _BeenNeutered;
        private Spiecies _Breed;
        private AdultSize _Size;

        public enum Spiecies { MutentRat, Lab, Retriever, SmallHorse, SmallBear}
        public enum AdultSize { Small, Medium, Large, XLarge}



        public int Height {
            get { return _Height; }
            set { _Height = value; }
        }
        public bool BeenNeutered {
            get { return _BeenNeutered; }
            set { _BeenNeutered = value; }
        }
        public Spiecies Breed {
            get { return _Breed; }
            set { _Breed = value; }
        }
        public AdultSize Size {
            get { return _Size; }
            set { _Size = value; }
        }

        public Dog(string name) {
            Name = name;
        }

        public override string ToString() {
            return "*" + Name;
        }

    }
}
