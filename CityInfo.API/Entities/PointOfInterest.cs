using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        // Explicit approach.  No need to explicitly state Foregin key for convention based,
        // which will automatically map the class name {city} as the prefix, followed by "Id".
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int CityId { get; set; }
    }
}
