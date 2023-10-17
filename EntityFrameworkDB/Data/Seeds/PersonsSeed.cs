using EntityFrameworkDB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Seeds
{
    public class PersonsSeed: IEntityTypeConfiguration<Persons>
    {
        public void Configure(EntityTypeBuilder<Persons> builder)
        {
            builder.HasData(
                new Persons {Id=1,Name="Felipe",Deleted=null,Created=DateTime.Now,Updated=DateTime.Now },
                new Persons { Id=2,Name = "Carlos", Deleted = null, Created = DateTime.Now, Updated = DateTime.Now });
        }
    }
}
