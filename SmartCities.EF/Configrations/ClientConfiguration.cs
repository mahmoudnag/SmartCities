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
    public class ClientConfiguration:IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData(
                  new Client
                  {
                      Id = "1",
                      Name = "google",
                      level="a",

                      Logo = "/img/project-1.jpg",
                      Email = "mahmoudfci57@gmail.com",
                      phoneNumber = "0000000000",
                      WebSiteUrl ="xxxxxxxxxxxxxxxxx",
                      Country ="Egypt",
                      Area = "Assuit",
                      City ="Assuit",
                      CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                      UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                  },

                new Client
                {
                    Id = "2",
                    Name = "microsoft",
                    level = "a",

                    Logo = "/img/project-1.jpg",
                    Email = "mahmoudfci57@gmail.com",
                    phoneNumber = "0000000000",
                    WebSiteUrl = "xxxxxxxxxxxxxxxxx",
                    Country = "Egypt",
                    Area = "Assuit",
                    City = "Assuit",
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"


                },
                  new Client
                  {
                      Id = "3",
                      Name = "google",
                      level = "a",
                      Logo = "/img/project-1.jpg",
                      Email = "mahmoudfci57@gmail.com",
                      phoneNumber = "0000000000",
                      WebSiteUrl = "xxxxxxxxxxxxxxxxx",
                      Country = "Egypt",
                      Area = "Assuit",
                      City = "Assuit",
                      CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                      UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                  },

                new Client
                {
                    Id = "4",
                    Name = "microsoft",
                    level = "a",
                    Logo = "/img/project-1.jpg",
                    Email = "mahmoudfci57@gmail.com",
                    phoneNumber = "0000000000",
                    WebSiteUrl = "xxxxxxxxxxxxxxxxx",
                    Country = "Egypt",
                    Area = "Assuit",
                    City = "Assuit",
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"


                }

               );
        }
    }
}
