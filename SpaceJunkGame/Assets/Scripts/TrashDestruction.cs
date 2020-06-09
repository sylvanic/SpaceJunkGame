using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDestruction : MonoBehaviour
{
    public GameObject spaceTrashDrop;
    public int trashCount = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void BigTrashDeath(){
        Destroy(gameObject);
        for(int i =0;i<=trashCount;i++)
        {       
             Instantiate(spaceTrashDrop,transform.position +
                         new Vector3(Random.Range(-1f,1f),0,Random.Range(-.5f,.5f)),
                         Quaternion.identity);
        }
        
        
    }


}
