namespace BancoValidator.Rules
{
    public class IntRule : IRule
    {
        public bool CheckValue(object value)
        {
            return value is int;
        }
    }
}