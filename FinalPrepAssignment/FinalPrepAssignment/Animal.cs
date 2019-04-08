using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrepAssignment {
    public abstract class  Animal : IComparable<Animal> {
        private string _Name;
        private string _HairColor;
        private int _Age;
        private Gender _Sex;

        public enum Gender { Male,Female};

        public string Name {
            get { return _Name; }
            set { _Name = value; }
        }
        public string HairColor {
            get { return _HairColor; }
            set { _HairColor = value; }
        }
        public int Age {
            get { return _Age; }
            set { _Age = value; }
        }
        public Gender Sex {
            get { return _Sex; }
            set { _Sex = value; }
        }

        
        public int CompareTo(Animal other) {
            return this.Name[0].CompareTo(other.Name[0]);
        }
    }
}
