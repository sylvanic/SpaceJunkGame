using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBullet : MonoBehaviour
{
    private Vector2 moveDirection;
    public float moveSpeed;
    [SerializeField]private float lifeTime;

    private void OnEnable()
    {
        Invoke("Destroy", lifeTime);
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}
