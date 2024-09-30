using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCities.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.EF.Configrations
{
    
    public  class CompanyConfiguration:IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            {

                builder.HasData(

                    new Company
                    {
                        Id = "1",
                        Name = "google",
                        Logo = "",
                        Email ="mahmfci57@gmail.com",
                        PhoneNumber = "",
                        AboutUs = "",
                        vision = "xxxxxxxxxxxxxx",
                        Mission = "xxxxxxxxxxxx",
                        Address = "Assuit",
                        FaceBookUr = "x",
                        LinkedInUrl = "x",
                        InstagramUrl = "x",
                        TwiterUrl = "x",
                        youtubeUrl = "x",






                    }
                    );
            }
        }
        }
    }

