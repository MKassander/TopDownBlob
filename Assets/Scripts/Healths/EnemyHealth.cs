using Player;
using UnityEngine;

namespace Healths
{
    public class EnemyHealth : Health
    {
        private Progress Progress => FindObjectOfType<Progress>();
        protected override void Death()
        {
            Progress.AddProgress();
            Destroy(gameObject);
        }
    }
}
