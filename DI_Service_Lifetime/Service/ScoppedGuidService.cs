namespace DI_Service_Lifetime.Service
{
    public class ScoppedGuidService : IScoppedGuidService
    {
        private readonly Guid Id;

        public ScoppedGuidService()
        {
                Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
