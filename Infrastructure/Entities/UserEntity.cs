using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }
        
        [Column(TypeName = "datetime2")]
        public DateTime LastModified { get; set; }

    }

    public class UserProfilesEntity
    {
        [Key]
        public int userId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; } = null!;

        [Column(TypeName = "varchar(20)")]
        public string? Phone { get; set; }

    }

    public class AddressesEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string StreetName { get; set; } = null!;

        [Required]
        [Column(TypeName = "varchar(6)")]
        public string ZipCode { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; } = null!;
    }



}
