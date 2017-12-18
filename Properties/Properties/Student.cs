namespace Properties
{
    class Student
    {
        private string _code = "N/A";
        private string _name;
        private int _age;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = "unknown";
                }
                _name = value; 
                
            }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public override string ToString()
        {
            return "Code = "+Code +", Name = "+ Name+ ", Age = " + Age;
        }
    }
}