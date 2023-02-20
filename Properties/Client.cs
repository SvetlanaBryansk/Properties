using System;

namespace Properties
{
    class Client
    {
        private string _name;
        private int _age;

        public string Name { get; set; } = "Default";
        
        public int Age
        { 
            get => _age;
            set
            { 
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Возраст не может быть отрицательным");

                _age = value; 
            }
        }
    }
}
