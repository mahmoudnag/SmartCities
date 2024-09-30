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
    public class PartenerConfiguration :IEntityTypeConfiguration<Partener>
    {
        public void Configure(EntityTypeBuilder<Partener> builder)

        {

            builder.HasData(

                new Partener
                {
                    Id = "1",
                    Name = "google",
                   
                    LogoUrl = "/img/project-1.jpg",
                    Email ="mahmoudfci57@gmail.com",
                    phoneNumber="0000000000",
                  Address ="Assuit",
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                },

                new Partener
                {
                    Id = "2",
                    Name = "microsoft",

                    LogoUrl = "/img/project-1.jpg",
                    Email = "mahmoudfci57@gmail.com",
                    phoneNumber = "0000000000",
                    Address = "cairo",
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                },


                       new Partener
                       {
                           Id = "3",
                           Name = "google",

                           LogoUrl = "/img/project-1.jpg",
                           Email = "mahmoudfci57@gmail.com",
                           phoneNumber = "0000000000",
                           Address = "Assuit",
                           CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                           UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                       },
                          new Partener
                          {
                              Id = "4",
                              Name = "google",

                              LogoUrl = "/img/project-1.jpg",
                              Email = "mahmoudfci57@gmail.com",
                              phoneNumber = "0000000000",
                              Address = "Assuit",
                              CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                              UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                }

                );


        }
    }
}
