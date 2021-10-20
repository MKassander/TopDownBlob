
namespace Healths
{
    public class EnvironmentHealth : HealthBase
    {
        protected override void Death()
        {
            Destroy(gameObject);
        }
    }
}
