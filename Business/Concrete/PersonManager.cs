using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal persondal;

        public PersonManager(IPersonDal persondal)
        {
            this.persondal = persondal;
        }

        public void Add(Person person)
        {
            persondal.Add(person);
        }

        public void Delete(Person person)
        {
            persondal.Delete(person);
        }

        public Person GetById(int id)
        {
            return persondal.Get(p => p.id == id); //gelen id ye eşit olan verileri getitir
        }

        public List<Person> GetList()
        {
            return persondal.GetList().ToList(); //tüm listeyi döndürür
        }

        public void Update(Person person)
        {
            persondal.Update(person);
        }
    }
}
