using Donation_App.Designs;
using Donation_App.Models;
using Donation_App.UserControls;

namespace Donation_App
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            //var _context = new DbClass();
            //Organization org1 = new Organization()
            //{
            //    OrgEmail = "egyptianrc@gmail.org",
            //    OrgPassword = "Helal11$",
            //    Name = "Red Crescent"
            //};
            //_context.Organizations.Add(org1);
            //_context.SaveChanges();

            //Organization org2 = new Organization()
            //{
            //    OrgEmail = "resala@gmail.org",
            //    OrgPassword = "Resala12$",
            //    Name = "Resala"
            //};
            //_context.Organizations.Add(org2);
            //_context.SaveChanges();

            //Organization org3 = new Organization()
            //{
            //    OrgEmail = "alorman@gmail.org",
            //    OrgPassword = "Orman13$",
            //    Name = "Orman"
            //};
            //_context.Organizations.Add(org3);
            //_context.SaveChanges();

            //Organization org4 = new Organization()
            //{
            //    OrgEmail = "baheya@gmail.org",
            //    OrgPassword = "Baheya14$",
            //    Name = "Baheya"
            //};
            //_context.Organizations.Add(org4);
            //_context.SaveChanges();

            //Organization org5 = new Organization()
            //{
            //    OrgEmail = "egyptianfoodbank@gmail.org",
            //    OrgPassword = "Bank15$",
            //    Name = "Food Bank"
            //};
            //_context.Organizations.Add(org5);
            //_context.SaveChanges();

            //Organization org6 = new Organization()
            //{
            //    OrgEmail = "magdiyacoub@gmail.org",
            //    OrgPassword = "magdi16$",
            //    Name = "Magdi Yacoub"
            //};
            //_context.Organizations.Add(org6);
            //_context.SaveChanges();

            ApplicationConfiguration.Initialize();
            Application.Run(new UHome());

        }
    }
}

//Application.Run(new UHome());
//Application.Run(new Home());