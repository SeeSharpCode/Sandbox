﻿namespace Sandbox.Wpf
{
    public class Customer
    {
        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}