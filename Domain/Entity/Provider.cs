using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class Provider : User
    {
        public long IdGroup { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<SkillLevel> Skills { get; set; }

        public virtual Group ProviderGroup { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}