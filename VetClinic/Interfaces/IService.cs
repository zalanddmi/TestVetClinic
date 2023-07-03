using System.Collections.Generic;

namespace VetClinic.interfaces
{
    public interface IService
    {
        List<object[]> GetAll();
        object[] GetById(int id);
        void Add(object[] values);
        void Update(int id, object[] values);
        void Delete(int id);
    }
}
