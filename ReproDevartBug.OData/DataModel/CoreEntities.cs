using Microsoft.EntityFrameworkCore;
using ReproDevartBug.OData.Entities;

namespace ReproDevartBug.OData.DataModel
{
   public partial class CoreEntities : DbContext
   {
      public CoreEntities(DbContextOptions options) : base(options)
      {
      }

      public virtual DbSet<Youth> Youths { get; set; }

      public virtual DbSet<Activity> Activities{ get; set; }
   }
}
