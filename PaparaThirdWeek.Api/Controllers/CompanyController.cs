using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.Abstracts;
using PaparaThirdWeek.Services.Concretes;
using PaparaThirdWeek.Services.DTOs;

namespace PaparaThirdWeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpPost]
        public IActionResult Post(CompanyDto company)
        {
            var companyDto = new Company
            {
                Name = company.Name,
                Adress = company.Adress,
                City = company.City,
                CreatedBy = "Samet",
                CreatedDate = System.DateTime.Now,
                Email = company.Email,
                IsDeleted = false,
                TaxNumber = company.TaxNumber
            };
            companyService.Add(companyDto);
            return Ok();
        }

       [HttpPost]
       [Route("Add")]
        [Consumes("application/json")]
        public IActionResult Add(Company company)
        {
            companyService.Post(company);
            return Ok();
        }
     
       [HttpGet]
        public IActionResult GetAll()
        {
            var result = companyService.GetAll();
            return Ok(result);
        }
     
      
        
       [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            companyService.GetById(id);
            return Ok();
        }

       [HttpDelete]
        [Consumes("application/json")]
        public IActionResult Delete(Company company)
        {
            companyService.Delete(company);
            return Ok();
        }
      

     [HttpPut]
        [Consumes("application/json")]
        public IActionResult Update(Company company)
        {
            companyService.Update(company);
            return Ok();
        }
    }
}
