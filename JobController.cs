using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCApp.Controllers
{
    public class JobController : Controller
    {
        private static readonly List<JobListing> JobListings = new()
        {
            new JobListing { Id = 1, Title = "Software Engineer", CompanyName = "TechCorp", Location = "AL Madinah", JobType = JobType.FullTime, PostedDate = DateTime.Now.AddDays(-5) },
            new JobListing { Id = 2, Title = "Project Manager", CompanyName = "BizGroup", Location = "Jeddah", JobType = JobType.Contract, PostedDate = DateTime.Now.AddDays(-10) },
            new JobListing { Id = 3, Title = "Data Analyst", CompanyName = "DataCorp", Location = "AL Riyadh", JobType = JobType.Remote, PostedDate = DateTime.Now.AddDays(-2) },
            new JobListing { Id = 4, Title = "Marketing Specialist", CompanyName = "AdAgency", Location = "AL Madinah", JobType = JobType.PartTime, PostedDate = DateTime.Now.AddDays(-7) },
            new JobListing { Id = 5, Title = "DevOps Engineer", CompanyName = "CloudTech", Location = "Jeddah", JobType = JobType.FullTime, PostedDate = DateTime.Now.AddDays(-15) }
        };

        // Route: /Job
        public IActionResult Index()
        {
            return View(JobListings);
        }

        // Route: /Job/Details/{id}
        public IActionResult Details(int id)
        {
            var job = JobListings.FirstOrDefault(j => j.Id == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }
    }
}
