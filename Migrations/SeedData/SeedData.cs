using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.SeedData
{
    public class SeedData
    {
        public static async Task SeedAsync(StoreContext context)
        {

            if (!context.PersonalInformations.Any() && !context.Cvs.Any() && !context.ExperienceInformations.Any())
            {
                PersonalInformation personalInformations = new PersonalInformation()
                {
                    Id = 0,
                    CityName="Amman",
                    Email="izzeldeen_kalbouneh@outlook.com",
                    FullName="izzeldeen kalbouneh",
                    MobileNumbers = "797237416"
                };


                ExperienceInformation experienceInformation = new ExperienceInformation()
                {
                    Id = 0,
                   City = "Amman",
                   CompanyName ="Atb",
                   CompaynField = "Information Technology"
                };

                Cv cv = new Cv()
                {
                    Id = 0,
                   Name = "Izzeldeen",
                    ExperienceInformation = experienceInformation,
                    PersonalInformation = personalInformations
                };
                context.Cvs.Add(cv);
                await context.SaveChangesAsync();
            }


        }
    }
}
