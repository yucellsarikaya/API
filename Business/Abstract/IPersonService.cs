using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonService
    {
        Person GetById(int id); //id ye göre getirir
        List<Person> GetList(); //tüm listeyi getirir
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);
    }
}
