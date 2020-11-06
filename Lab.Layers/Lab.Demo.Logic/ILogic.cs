﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public interface ILogic<T>
    {
        List<T> GetAll();
        T GetByID(int id);
        void Insert(T Entity);
        void Delete(T Entity);

    }
}
