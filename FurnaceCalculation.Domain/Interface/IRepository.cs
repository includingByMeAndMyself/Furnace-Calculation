
using System.Collections.Generic;

namespace FurnaceCalculation.Domain.Interface
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(); // получение всех объектов		
        T Get(string email); // получение одного объекта по id		
        void Add(T item); // добавление объекта					
        void Update(T item); // обновление объекта
        bool Delete(string email); // удаление объекта по id
    }
}
