using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ReproDevartBug.OData.DataModel;
using ReproDevartBug.OData.Entities;
using System.Linq;

namespace ReproDevartBug.OData.Controllers
{
   public class ActivitiesController : ODataController
   {
      private readonly CoreEntities _entities;

      public ActivitiesController(CoreEntities entities)
      {
         _entities = entities;
      }

      [HttpGet]
      [EnableQuery(MaxExpansionDepth = Consts.MaxExpansionDepth, MaxAnyAllExpressionDepth = Consts.MaxAnyAllExpressionDepth, MaxNodeCount = Consts.MaxNodeCount)]
      public IQueryable<Activity> Get()
      {
         return _entities.Activities;
      }
   }
}