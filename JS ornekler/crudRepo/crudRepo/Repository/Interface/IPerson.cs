using crudRepo.Models;

namespace crudRepo.Repository.Interface
{
    public interface IPerson
    {
        Task<IEnumerable<Person>> GetPerson();
        Task<int>AddPerson(Person person);
        Task<Person>GetPersonById(int id);
        Task<bool> UpdateRecord(Person person);
        Task<bool> RecordDelete(int id);
    }
}
