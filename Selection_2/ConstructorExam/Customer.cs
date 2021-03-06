﻿using System;
using System.Collections.Generic;

namespace Selection_2.ConstructorExam
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this()
        {
            this.Name = name;
        }
    }
}
