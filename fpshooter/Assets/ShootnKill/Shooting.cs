using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpawn;
    public float fireRate;

    private Transform _bullet;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    public void Fire()
    {
      _bullet =  Instantiate(bullet.transform, bulletSpawn.transform.position, Quaternion.identity);

    }

}


