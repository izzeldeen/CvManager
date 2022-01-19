using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExperienceInformation : EntityBase
    {
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string CompaynField { get; set; }
    }
}
