using Likja.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Likja.Conthread
{
    [Table("conthread")]
    public class Conthread : DomainEntity
    {
        [Column("title")]
        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("created_by")]
        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("content_type")]
        public ContentType ContentType { get; set; }

        [NotMapped]
        public string HashId
        {
            get
            {
                return Id.ConvertToHash();
            }
        }
    }
}
