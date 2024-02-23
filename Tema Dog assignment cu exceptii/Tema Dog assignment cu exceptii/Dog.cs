using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Dog_assignment_cu_exceptii
{
    class Dog
    {
        private string _name;
        private int _age;

        public Dog()
        {
            _name = string.Empty;
            _age = 0;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ApplicationException("Nu fiti zgarciti cu literele,pune-ti un nume mai frumos cainelui!");
                }

                _name = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Varsta aceasta nu exista!");
                }
                if (value > 100)
                {
                    throw new ApplicationException("Varsta aceasta este prea mare!");
                }

                _age = value;
            }
        }
    }
}
