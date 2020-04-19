using System;

namespace HW10
{
    class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Value must be not empty");
                }
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value > 140)
                {
                    throw new ArgumentException("Value must be correct");
                }
                _age = value;
            }
        }


        public int GrowingUp(int years)
        {
            if (years < 0)
            {
                throw new ArgumentException("Value must be correct");
            }
            return Age + years;
        }

        public string Description =>
            $"Name: {Name}, age in 4 years: {GrowingUp(years: 4)}";
    }
}
