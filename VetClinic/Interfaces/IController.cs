using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
