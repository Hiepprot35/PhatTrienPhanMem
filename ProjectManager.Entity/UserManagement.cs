// <auto-generated />

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;

namespace ProjectManager.Entity
{
    public class UserManagement : Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
#pragma warning restore 1591
