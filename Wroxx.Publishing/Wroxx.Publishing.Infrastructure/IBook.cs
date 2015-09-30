namespace Wroxx.Publishing.Infrastructure
{
    public interface IBook
    {
        string ISBN { get; set; }
        string Title { get; set; }

        string GetContents();
    }
}
