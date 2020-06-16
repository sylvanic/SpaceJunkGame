using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAsteroids : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int bulletsAmount = 10;
    [SerializeField] private float startAngle = 90f, endAngle = 270f;
    private Vector2 bulletMoveDirection;

    private void Start()
    {
        InvokeRepeating("Fire", 0f, 2f);
    }

    private void Fire()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirZ = transform.position.z + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, 0f, bulDirZ);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = AsteroidBulletPool.bulletPoolInstance.GetBullet();
            if(bul!=null){
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<AsteroidBullet>().SetMoveDirection(bulDir);
            }

            angle += angleStep;
        }


    }

}
