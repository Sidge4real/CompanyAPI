using CompanyAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok( new { Message = "Welcome to CompanyAPI" } );
        }
    }
    [Route("Companies")]
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
        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            return Ok(_CompanyData.Get(id));
        }
        [HttpGet("{id}/Image")]
        public IActionResult GetCompanyImage(int id)
        {
            var company = _CompanyData.Get(id);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company.Image); // has to change to return of an real image
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
        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            return Ok(_CompanyGroupData.Get(id));
        }
        [HttpGet("{id}/Image")]
        public IActionResult GetCompanyImage(int id)
        {
            var group = _CompanyGroupData.Get(id);
            if (group == null)
            {
                return NotFound();
            }
            return Ok(group.Image); // has to change to return of an real image
        }
    }
    [Route("Goals")]
    public class GoalsController : Controller
    {
        private IGoalData goals;
        public GoalsController(IGoalData goalData)
        {
            goals = goalData;
        }
        public IActionResult Index()
        {
            var goalData = goals.GetAll();
            return new ObjectResult(goalData);
        }
    }
}
