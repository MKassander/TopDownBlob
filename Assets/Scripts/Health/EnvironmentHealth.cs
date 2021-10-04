
public class EnvironmentHealth : Health
{
    protected override void Death()
    {
        Destroy(gameObject);
    }
}
