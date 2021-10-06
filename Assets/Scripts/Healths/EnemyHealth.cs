using UnityEngine;

namespace Healths
{
    public class EnemyHealth : Health
    {
        protected override void Death()
        {
            Progress.instance.AddProgress();
            Destroy(gameObject);
        }
    }
}
