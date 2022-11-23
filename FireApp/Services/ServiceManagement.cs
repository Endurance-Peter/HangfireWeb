namespace FireApp.Services;

public class ServiceManagement : IServiceManagement
{
    public void GenerateMerchandise()
    {
        System.Console.WriteLine($"Gennerate Merchandise: Long running task {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
    }

    public void SendEmail()
    {
        System.Console.WriteLine($"Send Email: Short running task {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
    }

    public void SyncData()
    {
        System.Console.WriteLine($"Sync Data: Short running task {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
    }

    public void UpdateDatabase()
    {
        System.Console.WriteLine($"Update Database: Short running task {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
    }
}