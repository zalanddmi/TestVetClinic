﻿using System.Collections.Generic;

namespace VetClinic.interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update (int id, T entity);
        void Delete(int id);
    }
}
