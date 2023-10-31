using CompanyAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok(new { Message = "Welcome to CompanyAPI" });
        }
    }
    [Route("Company")]
    public class CompanyController : Controller
    {
        private ICompanyData _CompanyData;
        public CompanyController(ICompanyData companyData)
        {
            _CompanyData = companyData;
        }
        public IActionResult Index()
        {
            var companyData = _CompanyData.GetAll();
            return new ObjectResult(companyData);
        }
    }
    [Route("Companygroup")]
    public class CompanygroupController : Controller 
    {
        private ICompanyGroupData _CompanyGroupData;
        public CompanygroupController(ICompanyGroupData companyGroupData)
        {
            _CompanyGroupData = companyGroupData;
        }
        public IActionResult Index()
        {
            var companyGroupData = _CompanyGroupData.GetAll();
            return new ObjectResult(companyGroupData);
        }
    }
}
