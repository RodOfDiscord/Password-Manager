namespace Services
{
    public interface ILoginService
    {
        bool Login(string name, string inputPassword);
    }
}