using System;
using Domain.DTO;

namespace Domain.Entity
{
    public class Actor : Default
    {
        public long Id { get; set; }
        public long IdLogin { get; set; }
        public virtual Login ActorLoginUser { get; set; }
        public long IdAddress { get; set; }
        public virtual Address ActorAddress { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Picture { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}