using crudRepo.Data;
using crudRepo.Models;
using crudRepo.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace crudRepo.Repository.Service
{
    public class PersonService : IPerson
    {
        public readonly ApplicationDbContext context;
        public PersonService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<int> AddPerson(Person person)
        {
            await context.persons.AddAsync(person);
            await context.SaveChangesAsync();
            return person.PersonID;
        }

        public async Task<IEnumerable<Person>> GetPerson()
        {
            var data = await context.persons.ToListAsync();
            return data;
        }

        public async Task<Person> GetPersonById(int id)
        {
            var data = await context.persons.Where(w => w.PersonID == id).FirstOrDefaultAsync();
            return data;
        }

        public async Task<bool> RecordDelete(int id)
        {
            
            bool status = false;
            if (id != null)
            {
                var data = await context.persons.Where(w => w.PersonID == id).FirstOrDefaultAsync();
                context.persons.Remove(data);
                await context.SaveChangesAsync();
                status = true;
            }
            return status;
        }

        public async Task<bool> UpdateRecord(Person person)
        {
            bool status= false;
            if (person != null)
            {
                context.persons.Update(person);
                await context.SaveChangesAsync();
                status = true;
            }
            return status;
        }
    }
}
