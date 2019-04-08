using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrepAssignment {
    class Cat : Animal {
        private Personality _Attitude;
        private int _Height;
        private bool _HaveClaws;
        private bool _BeenNeutered;

        public enum Personality { aggitated, Happy, Angry};

        public Personality Attitude {
            get { return _Attitude; }
            set { _Attitude = value; }
        }
        public int Height {
            get { return _Height; }
            set { _Height = value; }
        }
        public bool HaveClaws {
            get { return _HaveClaws; }
            set { _HaveClaws = value; }
        }
        public bool BeenNeutered {
            get { return _BeenNeutered; }
            set { _BeenNeutered = value; }
        }

        public Cat(string name) {
            Name = name;
        }

        public override string ToString() {
            return "+" + Name;
        }


    }
}
