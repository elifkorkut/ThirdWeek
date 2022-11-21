using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PaparaThirdWeek.Services.Abstracts
{
    public interface ICompanyService
    {
        
        public IEnumerable<Company> GetAll();
       
        public void Add(Company company);
        public void Post(Company company);
        public void Update(Company company);
        public void Delete(Company company);
        public void GetById(int id);
    }
}