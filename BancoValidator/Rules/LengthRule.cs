namespace BancoValidator.Rules
{
    public class LengthRule : IRule
    {
        public bool CheckValue(object value)
        {
            string val = value as string;
            return val.Length >= 8;
        }
    }
}