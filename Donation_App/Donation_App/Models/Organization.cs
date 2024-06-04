using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Donation_App.Models
{
    public class Organization:Encryption
    {
        [Key]
        [Required]
        [EmailAddress]
        public string OrgEmail { get; set; }

        [Required, MaxLength(12)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string OrgPassword { get; set; }
       
        public ICollection<Donor> Donors { get; set; }
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
