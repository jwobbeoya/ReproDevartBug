using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ReproDevartBug.OData.Entities
{
   [Table("ACTIVITY", Schema = Consts.Schema)]
   public class Activity
   {
      [Key]
      [Column("ACTIVITY_ID")]
      public virtual long ActivityId { get; set; }

      [DataMember]
      [Column("NOTES_TEXT")]
      public virtual string NotesText { get; set; }
   }
}