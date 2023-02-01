namespace HangfireApp.Services
{
    public class ServiceMangement : IServiceManagement
    {
        public void GenerateMerchandise()
        {
            Console.WriteLine($"Generate Merchandise : long running task {DateTime.Now.ToString()}");
        }

        public void SendEmail()
        {
            Console.WriteLine($"Send Email : short running task {DateTime.Now.ToString()}");
        }

        public void SyncData()
        {
            Console.WriteLine($"Sync Data : short running task {DateTime.Now.ToString()}");
        }

        public void UpdateDatabase()
        {
            Console.WriteLine($"Update database : long running task {DateTime.Now.ToString()}");
        }
    }
}
