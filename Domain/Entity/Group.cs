using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class Group : Default
    {
        public long Id { get; set; }
        public long IdProvider { get; set; }
        public virtual ICollection<Provider> GroupProvider { get; set; }
        public long IdGroupRole { get; set; }
        public virtual ICollection<GroupRole> GroupGroupRole { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}