namespace DI_Service_Lifetime.Service
{
    public class Transient : ITransientGuidService
    {
        private readonly Guid Id;
        public Transient()
        {
                Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
           return Id.ToString();
        }
    }
}
