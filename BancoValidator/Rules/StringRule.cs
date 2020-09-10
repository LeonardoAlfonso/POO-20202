namespace BancoValidator.Rules
{
    public class StringRule : IRule
    {
        public bool CheckValue(object value)
        {
            return value is string;
        }
    }
}