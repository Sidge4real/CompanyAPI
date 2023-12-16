using CompanyAPI.entities;
using CompanyAPI.models;
using CompanyAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.controllers
{
    [Route("[controller]")]
    public class ApiController : Controller
    {
        private readonly ICorporationCompanyGoalData goalCompanyGroupData;
        public ApiController(ICorporationCompanyGoalData goalCompanyGroupData)
        {
            this.goalCompanyGroupData = goalCompanyGroupData;
        }

        [Route("Goals")]
        [HttpGet]
        public ActionResult ReadGoals()
        {
            return Ok(goalCompanyGroupData.GetGoals());
        }
        [Route("Goals/{id}")]
        [HttpGet]
        public ActionResult ReadGoal(int id)
        {
            return Ok(goalCompanyGroupData.GetGoal(id));
        }
        [Route("Goals")]
        [HttpPost]
        public IActionResult CreateGoal([FromBody] GoalCreateViewModel goalCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newGoal = new Goal
            {
                Name = goalCreateViewModel.Name,
                Description = goalCreateViewModel.Description,
                Image = goalCreateViewModel.Image,
                CompanyId = goalCreateViewModel.CompanyId
            };
            goalCompanyGroupData.AddGoal(newGoal);
            return CreatedAtAction(nameof(ReadGoal), new { newGoal.Id }, newGoal);
        }
        [Route("Goals/{id}")]
        [HttpDelete]
        public IActionResult DeleteGoal(int id)
        {
            var goal = goalCompanyGroupData.GetGoal(id);
            if (goal == null)
            {
                return NotFound();
            }
            goalCompanyGroupData.DeleteGoal(goal);
            return NoContent();
        }
        [Route("Goals/{id}")]
        [HttpPut]
        public IActionResult UpdateGoal(int id, [FromBody] GoalUpdateViewModel goalCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var goal = goalCompanyGroupData.GetGoal(id);
            if (goal == null)
            {
                return NotFound();
            }
            var updated = new Goal
            {
                Id = goal.Id,
                Name = goalCreateViewModel.Name,
                Description = goalCreateViewModel.Description,
                Image = goalCreateViewModel.Image,
                CompanyId = goalCreateViewModel.CompanyId
            };
            goalCompanyGroupData.UpdateGoal(updated);
            return NoContent();
        }





        [Route("Companies")]
        [HttpGet]
        public IActionResult ReadCompanies()
        {
            return Ok(goalCompanyGroupData.GetCompanies());
        }
        [Route("Companies")]
        [HttpPost]
        public IActionResult CreateCompany([FromBody] CompanyCreateViewModel companyCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newCompany = new Company
            {
                Name = companyCreateViewModel.Name,
                Description = companyCreateViewModel.Description,
                Image = companyCreateViewModel.Image,
                GroupId = companyCreateViewModel.GroupId,
                Sector = companyCreateViewModel.Sector
            };
            goalCompanyGroupData.AddCompany(newCompany);
            return CreatedAtAction(nameof(ReadCompany), new { newCompany.Id }, newCompany);
        }
        [Route("Companies/{id}")]
        [HttpGet]
        public IActionResult ReadCompany(int id)
        {
            return Ok(goalCompanyGroupData.GetCompany(id));
        }
        [Route("Companies/{id}")]
        [HttpDelete()]
        public IActionResult DeleteCompany(int id)
        {
            var company = goalCompanyGroupData.GetCompany(id);
            if (company == null)
            {
                return NotFound();
            }
            goalCompanyGroupData.DeleteCompany(company);
            return NoContent();
        }
        [Route("Companies/{id}")]
        [HttpPut]
        public IActionResult UpdateCompany(int id, [FromBody] CompanyUpdateViewModel companyUpdateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var company = goalCompanyGroupData.GetCompany(id);
            if (company == null)
            {
                return NotFound();
            }
            var updated = new Company
            {
                Id = company.Id,
                Name = companyUpdateViewModel.Name,
                Description = companyUpdateViewModel.Description,
                Image = companyUpdateViewModel.Image,
                Sector = companyUpdateViewModel.Sector
            };
            goalCompanyGroupData.UpdateCompany(updated);
            return NoContent();
        }




        [Route("Corporation")]
        [HttpGet]
        public IActionResult ReadCorporations()
        {
            return Ok(goalCompanyGroupData.GetCorporations());
        }
        [Route("Corporation/{id}")]
        [HttpGet]
        public IActionResult ReadCorporation(int id)
        {
            return Ok(goalCompanyGroupData.GetCorporation(id));
        }
        [Route("Corporation")]
        [HttpPost]
        public IActionResult CreateCorporation([FromBody] CorporationCreateViewModel companyGroupCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Newcorporation = new Corporation
            {
                Name = companyGroupCreateViewModel.Name,
                Description = companyGroupCreateViewModel.Description,
                Image = companyGroupCreateViewModel.Image,
            };
            goalCompanyGroupData.AddCorporation(Newcorporation);
            return CreatedAtAction(nameof(ReadCorporation), new { Newcorporation.Id }, Newcorporation);
        }
        [Route("Corporation/{id}")]
        [HttpDelete]
        public IActionResult DeleteCorporation(int id)
        {
            var corporation = goalCompanyGroupData.GetCorporation(id);
            if (corporation == null)
            {
                return NotFound();
            }
            goalCompanyGroupData.DeleteCorporation(corporation);
            return NoContent();
        }
        [Route("Corporation/{id}")]
        [HttpPut]
        public IActionResult UpdateCorporation(int id, [FromBody] CorporationUpdateViewModel companyGroupUpdateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var corporation = goalCompanyGroupData.GetCorporation(id);
            if (corporation == null)
            {
                return NotFound();
            }
            var updated = new Corporation
            {
                Id = corporation.Id,
                Name = companyGroupUpdateViewModel.Name,
                Description = companyGroupUpdateViewModel.Description,
                Image = companyGroupUpdateViewModel.Image
            };
            goalCompanyGroupData.UpdateCorporation(updated);
            return NoContent();
        }
    }
}
