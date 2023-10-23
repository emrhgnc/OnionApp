﻿using OnionApp.Domain.Common;
using OnionApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();

        Task<T> GetById(Guid id);

        Task<T> AddAsync(T entity);
    }
}
