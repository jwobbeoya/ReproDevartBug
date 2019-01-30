using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReproDevartBug.OData.Entities
{
   [Table("YOUTH", Schema = Consts.Schema)]
   public class Youth
   {

      [Column("YOUTH_ID")]
      [Key]
      public long YouthId { get; set; }

      [Column("JJIS_NUMBER")]
      public string JjisNumber { get; set; }
   }
}