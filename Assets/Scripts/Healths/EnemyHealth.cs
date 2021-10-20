using Player;
using UnityEngine;

namespace Healths
{
    public class EnemyHealth : HealthBase
    {
        private Progress Progress => FindObjectOfType<Progress>();
        protected override void Death()
        {
            Progress.AddProgress();
            Destroy(gameObject);
        }
    }
}
