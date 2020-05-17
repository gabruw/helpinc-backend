using System;

namespace Domain.Entity
{
    public class SkillLevel : Default
    {
        public long Id { get; set; }
        public long IdSkill { get; set; }
        public virtual Skill SkillLevelSkill { get; set; }
        public int Level { get; set; }

        public virtual Provider ProviderSkill { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}