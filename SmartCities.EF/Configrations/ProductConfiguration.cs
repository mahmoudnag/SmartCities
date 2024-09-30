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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)

        {

            builder.HasData(

                new Product
                {
                    Id="1",
                    Name="gate1",
                    Description="gate1 discription",
                    ImageUrl= "/img/project-1.jpg",
                    Logo= "/img/project-1.jpg",
                    CreateBy= "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy= "8e445865-a24d-4543-a6c6-9443d048cdb9"






                },

                new Product
                {
                    Id = "2",
                    Name = "gate2",
                    Description = "gate2 discription",
                    ImageUrl = "/img/project-1.jpg",
                    Logo = "/img/project-1.jpg",
                    CreateBy= "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                },
                 new Product
                 {
                     Id = "3",
                     Name = "gate3",
                     Description = "gate1 discription",
                     ImageUrl = "/img/project-1.jpg",
                     Logo = "/img/project-1.jpg",
                     CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                     UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                 },

                new Product
                {
                    Id = "4",
                    Name = "gate4",
                    Description = "gate2 discription",
                    ImageUrl = "/img/project-1.jpg",
                    Logo = "/img/project-1.jpg",
                    CreateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UpdateBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"






                }

                );


        }
    }
}
