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
    internal class ProjectConfiguration:IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)

        {

            builder.HasData(

                new Project
                {
                    Id = "1",
                    Name = "Project1",
                    Description = "Project discription",
                    ImageUrl = "/img/project-1.jpg",
                    Logo = "/img/project-1.jpg",
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"

                },

                new Project
                {
                    Id = "2",
                    Name = "Project2",
                    Description = "Project2 discription",
                    ImageUrl = "/img/project-1.jpg",
                    Logo = "/img/project-1.jpg",
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                },
                 new Project
                 {
                     Id = "3",
                     Name = "Project3",
                     Description = "Project3 discription",
                     ImageUrl = "/img/project-1.jpg",
                     Logo = "/img/project-1.jpg",
                     CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                     UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                 },

                new Project
                {
                    Id = "4",
                    Name = "Project4",
                    Description = "Project4 discription",
                    ImageUrl = "/img/project-1.jpg",
                    Logo = "/img/project-1.jpg",
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                }

                );


        }
    }
}
