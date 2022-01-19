using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cv : EntityBase
    {
        public string Name { get; set; }
        public int ExperienceInformationId { get; set; }
        public ExperienceInformation ExperienceInformation { get; set; }
        public int PersonalInformationId { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
