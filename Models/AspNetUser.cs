//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentPlanner.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            this.AspNetUserClaims = new HashSet<AspNetUserClaim>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogin>();
            this.AspNetRoles = new HashSet<AspNetRole>();
            this.ToDoes = new HashSet<ToDo>();
            this.AspNetRoles1 = new HashSet<AspNetRole>();
            this.AspNetRoles2 = new HashSet<AspNetRole>();
            this.AspNetRoles3 = new HashSet<AspNetRole>();
            this.AspNetRoles4 = new HashSet<AspNetRole>();
            this.Cours = new HashSet<Cours>();
            this.AspNetRoles5 = new HashSet<AspNetRole>();
            this.AspNetRoles6 = new HashSet<AspNetRole>();
        }
    
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }
    
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
        public virtual ICollection<ToDo> ToDoes { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles1 { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles2 { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles3 { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles4 { get; set; }
        public virtual ICollection<Cours> Cours { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles5 { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles6 { get; set; }
    }
}
