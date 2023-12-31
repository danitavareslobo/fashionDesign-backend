﻿using fashionDesign.Models.Enums;

namespace fashionDesign.Models
{
    public class User
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }

        public ICollection<Collection> Collections { get; set; }
        public virtual Company Company { get; set; }
    }
}
