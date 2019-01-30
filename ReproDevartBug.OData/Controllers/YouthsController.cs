using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReproDevartBug.OData.DataModel;
using ReproDevartBug.OData.Entities;

namespace ReproDevartBug.OData.Controllers
{
   public class YouthsController : ODataController
   {
      private readonly CoreEntities _entities;
      public YouthsController(CoreEntities entities)
      {
         _entities = entities;
      }

      [HttpGet]
      [EnableQuery(MaxExpansionDepth = Consts.MaxExpansionDepth, MaxAnyAllExpressionDepth = Consts.MaxAnyAllExpressionDepth, MaxNodeCount = Consts.MaxNodeCount)]
      public IQueryable<Youth> Get()
      {
         return _entities.Youths;
      }

   }
}
