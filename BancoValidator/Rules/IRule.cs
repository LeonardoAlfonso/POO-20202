namespace BancoValidator.Rules
{
    public interface IRule
    {
        bool CheckValue(object value);
    }
}