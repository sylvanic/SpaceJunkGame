using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHitCheck : MonoBehaviour
{
    //DisplayTextBoxes
    public GameObject astronautInteraction;
    public GameObject intro9;
    public GameObject intro10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool introDisplay5 = true;
    public void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Asteroid" )
        {
            if (introDisplay5)
            {
                StartCoroutine(StartIntro5());
                introDisplay5 = false;
            }
        }
    }

    public IEnumerator StartIntro5()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro9.SetActive(true);
        yield return new WaitForSeconds(3);
        intro9.SetActive(false);
        intro10.SetActive(true);
        yield return new WaitForSeconds(3);
        intro10.SetActive(false);
        astronautInteraction.SetActive(false);
    }
}
