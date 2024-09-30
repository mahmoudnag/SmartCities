using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SmartCities.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.EF.Configrations
{
    public class CommentConfiguration: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                  new Comment
                  {
                      Id = 1,
                      Description ="comment1",
                     ClientId="1",
                      CreateBy = "external",
                      UpdateBy = "external"






                  },

              new Comment
              {
                  Id = 2,
                  Description = "comment2",
                  ClientId = "2",
                  CreateBy = "external",
                  UpdateBy = "external"






              },
                 new Comment
                 {
                     Id = 3,
                     Description = "comment3",
                     ClientId="3",
                     CreateBy = "external",
                     UpdateBy = "external"






                 },

               new Comment
               {
                   Id = 4,
                   Description = "comment4",
                   ClientId="4",
                   CreateBy = "external",
                   UpdateBy = "external"






               }

               );
        }
    }
}
