namespace Vektorel.Inheritance.Providers;

internal abstract class Identity
{
    public string Label
    {
        get
        {
            return $"{Prefix}-{IdentityNumber.ToString().PadLeft(5, '0')}";
        }
    }
    public int IdentityNumber { get; set; }
    protected string Prefix { get; set; }
    //Yalnızca Identity class'ını kalıtım yoluyla alanlar erişebilir
}
