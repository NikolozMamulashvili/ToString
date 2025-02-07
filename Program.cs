using System;

namespace MyApp
{
    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Hello my name is {Name}";
        }
    }
}