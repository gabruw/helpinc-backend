using System.Linq;
using System.Collections.Generic;

namespace Domain.Entity
{
    public abstract class Default
    {
        private List<string> ValidationMessage { get; set; }

        protected List<string> GetValidationMessage
        {
            get
            {
                return ValidationMessage ?? (ValidationMessage = new List<string>());
            }
        }

        protected void ClearValidationMessage()
        {
            ValidationMessage.Clear();
        }

        protected void AddError(string message)
        {
            ValidationMessage.Add(message);
        }

        public abstract void Validate();

        protected bool isValid
        {
            get
            {
                return ValidationMessage.Any();
            }
        }
    }
}