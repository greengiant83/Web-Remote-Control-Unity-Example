using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform LaunchPoint;

    public void Fire(float x, float y, float power)
    {
        var v = new Vector3(x, y, 0) * 100;
        transform.rotation = Quaternion.FromToRotation(Vector3.forward, v);

        var bullet = Instantiate<GameObject>(BulletPrefab);
        var bulletBody = bullet.GetComponent<Rigidbody>();
        bullet.transform.position = LaunchPoint.position;
        bulletBody.velocity = v;
    }
}
