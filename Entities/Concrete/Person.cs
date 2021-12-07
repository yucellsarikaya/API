using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person : IEntity
    {
        public int id { get; set; }
        public string  name { get; set; }
        public string surname { get; set; }
        public string department { get; set; }
        public int  salary { get; set; }

    }
}
