using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float attack_Timer = .5f;
    private float current_Attack_Timer;
    private bool canAttack;


    public float BulletForce = 20f;

    void Start()
    {
        current_Attack_Timer = attack_Timer;
    }


    void Update()
    {  
     Attack();
    }

    void Attack()
    {
        attack_Timer += Time.deltaTime;
        if (attack_Timer > current_Attack_Timer)
        {
            canAttack = true;
        }

        if (canAttack)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                canAttack = false;
                attack_Timer = 0f;
                Shot();
            }
        }
    }

        void Shot()
        {
        GameObject bullet =  Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * BulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 2f);
        }
}
