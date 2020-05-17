using System;

namespace Domain.Entity
{
    public class Skill : Default
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}