using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evo.Domain;
using Evo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Evo.Web.Api.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Assessment")]
    public class AssessmentController : Controller
    {
        private readonly IAssessmentRepository _assessmentRepository;

        public AssessmentController(IAssessmentRepository assessmentRepository)
        {
            _assessmentRepository = assessmentRepository;
        }

        // GET: api/assessment
        [HttpGet]
        public Task<IEnumerable<Assessment>> Get()
        {
            return GetAssessmentInternal();
        }

        private async Task<IEnumerable<Assessment>> GetAssessmentInternal()
        {
            var assessments = await _assessmentRepository.GetAllAssesments();
            return assessments;
        }

        // GET api/assessment/5
        [HttpGet("{id}")]
        public Task<Assessment> Get(string id)
        {
            return GetAssessmentByIdInternal(id);
        }

        private async Task<Assessment> GetAssessmentByIdInternal(string id)
        {
            var assessment = await _assessmentRepository.GetAssessment(id) ?? new Assessment();
            return assessment;
        }

        // POST api/assessment
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _assessmentRepository.AddAssessment(
                new Assessment() {Body = value, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now});
        }

        // PUT api/assessment/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            _assessmentRepository.UpdateAssessment(id, value);
        }

        // DELETE api/assessment/5
        public void Delete(string id)
        {
            _assessmentRepository.RemoveAssessment(id);
        }
    }
}