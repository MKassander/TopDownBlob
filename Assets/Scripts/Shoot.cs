
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [HideInInspector]public GameObject projectile;
    public Transform spawnPoint;
    private bool Ready = true;
    public int delay;

    public void Fire()
    {
        var proj = Instantiate(projectile);
        proj.transform.position = spawnPoint.position;
        proj.transform.rotation = spawnPoint.rotation;

        Ready = false;
        
        Invoke(nameof(SetReady), delay);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Ready)
        {
            Fire();
        }
    }

    void SetReady()
    {
        Ready = true;
    }
}
