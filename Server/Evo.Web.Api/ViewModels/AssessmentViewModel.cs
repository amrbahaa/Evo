using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evo.Web.Api.ViewModels
{
    public class AssessmentViewModel
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
    }
}
