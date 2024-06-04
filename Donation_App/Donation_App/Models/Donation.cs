using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Donation_App.Models
{
    public class Donation:Encryption
    {
        [Key]
        public int DonationId { get; set; }
       
        public string DonorEmail { get; set; }
        public Donor Donor { get; set; }
        
        public string OrganizationEmail { get; set; }
        public Organization Organization { get; set; }
       
        public DateTime Date { get; set; }=DateTime.Now;
        [Required]
        public int Amount { get; set; }
        
        public string  Card_number { get; set; }
        [Required]
        public string Card_Name { get; set; }

        [Required]
       
        public string CVC { get; set; }
        [Required]
        public DateTime Expiration_date { get; set; }
        public override string Hash(string card)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(card));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
       

    }
}