using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PaulTest.Models.Entities
{
    public class AppUser : IdentityUser
    {
        // Add profile data for application users by adding properties to this class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? AzureAdId  { get; set; }
    }
}