using System.Collections.Generic;
using BancoValidator.Rules;

namespace BancoValidator.Validator
{
    public class ValidateObject
    {
        public object Value { get; set; }
        public List<IRule> Rules { get; set; }

        public ValidateObject()
        {
            Rules = new List<IRule>();
        }

        public bool ValidateField()
        {
            bool response = true;
            Rules.ForEach(r => {
                bool result = r.CheckValue(Value);
                response = response && result;
            });
            return response;
        }
    }
}