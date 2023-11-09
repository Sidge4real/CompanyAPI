﻿using CompanyAPI.entities;
using CompanyAPI.models;
using CompanyAPI.services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace CompanyAPI.controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok( new { Message = "Welcome to CompanyAPI" } );
        }
    }
    [Route("Companies")]
    public class CompaniesController : Controller
    {
        private ICompanyData _CompanyData;
        public CompaniesController(ICompanyData companyData)
        {
            _CompanyData = companyData;
        }
        [HttpGet]
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
        [HttpPost()] // 201
        public IActionResult Create([FromBody] CompanyCreateViewModel companyCreateViewModel)
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
            _CompanyData.Add(newCompany);
            return CreatedAtAction(nameof(Detail), new { newCompany.Id }, newCompany);
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
        [HttpGet]
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
        [HttpPost()] // 201
        public IActionResult Create([FromBody] CompanyGroupCreateViewModel companyGroupCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newGroup = new CompanyGroup
            {
                Name = companyGroupCreateViewModel.Name,
                Description = companyGroupCreateViewModel.Description,
                Image = companyGroupCreateViewModel.Image
            };
            _CompanyGroupData.Add(newGroup);
            return CreatedAtAction(nameof(Detail), new { newGroup.Id }, newGroup);
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
        [HttpGet]
        public IActionResult Index()
        {
            var goalData = goals.GetAll();
            return new ObjectResult(goalData);
        }
        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            return Ok(goals.Get(id));
        }
        [HttpGet("{id}/Image")]
        public IActionResult GetCompanyImage(int id)
        {
            var goal = goals.Get(id);
            if (goal == null)
            {
                return NotFound();
            }
            return Ok(goal.Image); // has to change to return of an real image
        }

        [HttpPost()] // 201
        public IActionResult Create([FromBody] GoalCreateViewModel goalCreateViewModel)
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
            goals.Add(newGoal);
            return CreatedAtAction(nameof(Detail), new { newGoal.Id }, newGoal);
        }
    }
}

