namespace Afisha.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(AfishaDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
