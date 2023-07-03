using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.interfaces;
using VetClinic.owner.Services;

namespace VetClinic.owner.Controllers
{
    public class OwnerController : IController
    {
        private readonly IService _ownerService;

        public OwnerController()
        {
            _ownerService = new OwnerService();
        }

        public void AddRecord(object[] values)
        {
            _ownerService.Add(values);
        }

        public void DeleteRecord(int id)
        {
            _ownerService.Delete(id);
        }

        public List<object[]> GetAllRecords()
        {
            return _ownerService.GetAll();
        }

        public object[] GetRecord(int id)
        {
            return _ownerService.GetById(id);
        }

        public void UpdateRecord(int id, object[] values)
        {
            _ownerService.Update(id, values);
        }
    }
}
