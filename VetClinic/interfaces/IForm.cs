using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.interfaces
{
    public interface IForm
    {
        void ShowRecords();
        void AddRecord();
        void UpdateRecord();
        void DeleteRecord();
        void ChangeVisibleGroupBox(bool isVisible);
    }
}
