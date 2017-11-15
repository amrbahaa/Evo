using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evo.Domain;
using Evo.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Evo.Web.Api.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Admin")]
    public class AdminController : Controller
    {
        private readonly IAssessmentRepository _assessmentRepository;

        public AdminController(IAssessmentRepository assessmentRepository)
        {
            _assessmentRepository = assessmentRepository;
        }

        // Call an initialization - api/admin/init
        [HttpGet("{setting}")]
        public string Get(string setting)
        {
            if (setting == "init")
            {
                _assessmentRepository.RemoveAllAssessments();
                _assessmentRepository.AddAssessment(new Assessment()
                {
                    Id = "1",
                    Body = "Test note 1",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    UserId = 1
                });
                _assessmentRepository.AddAssessment(new Assessment()
                {
                    Id = "2",
                    Body = "Test note 2",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    UserId = 1
                });
                _assessmentRepository.AddAssessment(new Assessment()
                {
                    Id = "3",
                    Body = "Test note 3",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    UserId = 2
                });
                _assessmentRepository.AddAssessment(new Assessment()
                {
                    Id = "4",
                    Body = "Test note 4",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    UserId = 2
                });

                return "Done";
            }

            return "Unknown";
        }
    }
}