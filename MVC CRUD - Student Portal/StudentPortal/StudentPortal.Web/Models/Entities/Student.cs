using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StudentPortal.Web.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Subscribed { get; set; }



    }
}
