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
    public class TeamConfiguration: IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)

        {

            builder.HasData(

                new Team
                {
                    Id = "1",
                    Name = "Mahmoud",
                    JobTitle  = "SoftWare Engineer",
                    ImageUrl = "/img/mahmoud.jpeg",
                    FaceBookUrl = "x",
                    Instagramurl = "y",
                    LinkedInUrl = "x",
                    TwitterUrl = "y",

                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                },

                new Team
                {
                    Id = "2",
                    Name = "Gamal",
                    JobTitle = "gate2 discription",
                    ImageUrl = "/img/gamal.jpg",
             
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    FaceBookUrl = "x",
                    Instagramurl = "y",
                    LinkedInUrl = "x",
                    TwitterUrl = "y",






                },
                 new Team
                 {
                     Id = "3",
                     Name = "Gamal",
                     JobTitle = "gate2 discription",
                     ImageUrl = "/img/gamal.jpg",
                     FaceBookUrl = "x",
                     Instagramurl = "y",
                     LinkedInUrl = "x",
                     TwitterUrl = "y",

                     CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                     UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    






                 },
                  new Team
                  {
                      Id = "4",
                      Name = "Gamal",
                      JobTitle = "gate2 discription",
                      ImageUrl = "/img/gamal.jpg",
                      FaceBookUrl = "x",
                      Instagramurl = "y",
                      LinkedInUrl = "x",
                      TwitterUrl = "y",

                      CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                      UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                  }

                );


        }
    }
}
