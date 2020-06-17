using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PlayerStats : MonoBehaviour
{
    //Capacity UI and Stats
    public Slider capacitySlider;
    public TextMeshProUGUI capacityText;
    public int capacity = 0;
    public int maxCapacity = 0;
    

    //score
    public static int currentScore;
    public static int totalScore;
    public TextMeshProUGUI scoreText;
    [SerializeField]private int scoreMultiplier = 0;
    private SoundManager soundManager;
    [SerializeField] private Image exclamation_mark;
    public static int hitAmount;


    public GameObject explosionPrefab;

    void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        if(capacitySlider){
        capacitySlider.maxValue = maxCapacity;
        }

        
    }

    void Update()
    {
        CapacitySliderUpdate();
    
    }
   

    private void CapacitySliderUpdate()
    {
        capacity = Mathf.Clamp(capacity, 0, maxCapacity);
        if(capacitySlider){
            capacitySlider.value = capacity;
        }
       
        if(capacityText){
            capacityText.text = capacity.ToString();
        }
        currentScore = capacity;

        if (capacity == maxCapacity)
        {
            Debug.Log("here");
            exclamation_mark.gameObject.SetActive(true);
        }

        else if(capacity != maxCapacity)
                {
            exclamation_mark.gameObject.SetActive(false);
        }

    }

    private IEnumerator MeshBlinking(int blinkCount,float blinkTime){
        
        for(int i = 0; i<blinkCount;i++)
        {
        
        ParticleSystemRenderer[] flames;
        flames = GetComponentsInChildren<ParticleSystemRenderer>();

        foreach(ParticleSystemRenderer flame in flames)
        {
            flame.enabled=false;
        }

        GetComponentInChildren<Renderer>().enabled=false;
        yield return new WaitForSeconds(blinkTime);
        
        foreach(ParticleSystemRenderer flame in flames)
        {
            flame.enabled=true;
        }    
        
        GetComponentInChildren<Renderer>().enabled=true;    
        yield return new WaitForSeconds(blinkTime);
        
       

        }

    }   




    public void UpdateScore(){
        
        currentScore *= scoreMultiplier;
        totalScore += currentScore;
        scoreText.text = "Punten: " + totalScore;
        
    }

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Asteroid")
        { 
            soundManager.AsteroidCrash.Play();
            capacity--;
            Debug.Log("!!!!!!asteroid collision idk");
            other.gameObject.SetActive(false);
            StartCoroutine(MeshBlinking(3,.5f));
        }
    }

    public void OnCollisionEnter(Collision obj)
    {      
       
        if (obj.gameObject.tag == "Asteroid")
        {
            hitAmount++;
            capacity--;
            Destroy(obj.gameObject,.1f);
            Debug.Log("asteroid collision idk");
            soundManager.AsteroidCrash.Play();
            StartCoroutine(MeshBlinking(6,.1f));

            Instantiate(explosionPrefab, obj.transform.position, Quaternion.identity);
        }
        
    }
}
