using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Donation_App.Models
{
    public enum _Gender { Male, Female }
    public enum _Country
    {
        Egypt, Sudan, Saudi_Arabia, Tunisia, Somalia, Algeria,
        Morocco, Iraq, Syria, Yemen, Libya, Jordan, Palestine, Bahrain, Qatar, Oman, Kuwait
    }
    public class Donor:Encryption
    {
        [Key]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required, MaxLength(12)]
        public string FirstName { get; set; }
        [Required, MaxLength(12)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, MaxLength(11)]
        public string PhoneNumber { get; set; }
        [Required]
        public _Country Country { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string DonorImage { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public _Gender Gender { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public List<Donation> Donations { get; set; }
       

        public override string Hash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the hashed bytes to a hexadecimal string
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
