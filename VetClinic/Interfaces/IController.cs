using System.Collections.Generic;

namespace VetClinic.interfaces
{
    public interface IController
    {
        List<object[]> GetAllRecords();
        object[] GetRecord(int id);
        void AddRecord(object[] values);
        void UpdateRecord(int id, object[] values);
        void DeleteRecord(int id);
    }
}
