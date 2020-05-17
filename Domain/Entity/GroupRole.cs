using System;

namespace Domain.Entity
{
    public class GroupRole : Default
    {
        public long Id { get; set; } 
        public long IdProvider { get; set; }
        public virtual Provider ProviderOfficer { get; set; }
        public int Role { get; set; }

        public virtual Group GroupRoleGroup { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}