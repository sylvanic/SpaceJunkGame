using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchTutorial : MonoBehaviour
{
    public Text part1;
    public Text part2;
    public Text part3;
    public Text part4;
    public Text part5;
    public Text part6;
    public Text part7;
    public Text part8;
    public Text part9;
    public Text part10;
    public Text part11;
    public Text part11point1;
    public Text part11point2;
    public Text part11point3;
    public Text part11point4;
    public Text part12;
    public Text part13;
    public Text part14;
    public Text part15;
    public TextMeshProUGUI OB1;
    public TextMeshProUGUI OB2;
    public TextMeshProUGUI CH1;
    public TextMeshProUGUI CH2;

    void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            part1.text = "Greetings, traveller. Welcome to Space Janitor. My name is Astro and I'll be your instructor.";
            part2.text = "We have a serious problem on hand! Earth's orbit is being polluted by space junk!";
            part3.text = "We need your help to clean up this mess. ";
            part4.text = "Don't worry, I'll guide you through the tutorial.";
            part5.text = "Lets start with the basics. To control your spaceship, use the direction pad on your screen.";
            part6.text = "Good! Now try to move around and collect 3 junk parts.";
            part7.text = "Once you have collected 3 pieces of junk, dispose of them at the spacestation.";
            part8.text = "Good Job! Now try to get hit by an asteroid.";
            part9.text = "Once you've been hit, you lose your load. But there is way to get rid of obstacles.";
            part10.text = "Press this button here to shoot lasers.";
            part11.text = "Nice work! This laser will destroy asteroids. Now you know how to defend yourself.";
            part11point1.text = "There is one other thing you can do with the laser.";
            part11point2.text = "Search around the area. You will find a burning piece of space junk.";
            part11point3.text = "This one is too big to pick up. You must shoot these flaming big pieces of space trash before you can clean it up. Try it out.";
            part11point4.text = "Good job! Now you know how to pick up big space junk.";
            part12.text = "Completing these objectives and achievements will give you bonus points.";
            part13.text = "Time is also limited, so think fast while the map will show you the way.";
            part14.text = "Minimap Legend:\n- Blue: Space trash.\n-Green: The space station.\n- Red: Asteroids.";
            part15.text = "That is it for the tutorial, good luck and have fun!";
            OB1.text = "Collected trash: 0 / 5";
            OB2.text = "Dump trash over 50% 0 / 2";
            CH1.text = "Get hit by astroid +5 points";
            CH2.text = "Collect 2 satellites +15 points";
        }
        else
        {
            part1.text = "Gegroet, reiziger. Welkom bij Ruimte Concierge. Mijn naam is Astro, en ik zal jou instructeur zijn.";
            part2.text = "We hebben een ernstig probleem! De baan van onze aarde wordt vervuild door ruimteafval!";
            part3.text = "We hebben jou hulp nodig om deze vervuiling op te ruimen.";
            part4.text = "Maak je geen zorgen, ik zal je leiden door deze les.";
            part5.text = "Laten we met het basis beginnen. Om je ruimteschip te bedienen, gebruik de richtingstoetsen op je scherm.";
            part6.text = "Goed zo! Probeer nu rond te bewegen en 3 stukken afval te verzamelen.";
            part7.text = "Wanneer je 3 stukken afval hebt verzamelt, gooi ze weg op het ruimtestation.";
            part8.text = "Goed gedaan! Probeer nu door een asteroid geraakt te worden.";
            part9.text = "Wanneer je geraakt wordt, verlies je wat van je lading. Maar er is een manier om van deze obstakels af te komen.";
            part10.text = "Druk op deze knop om je laser te schieten.";
            part11.text = "Goed zo! Deze laser kan astroiden verwoesten. Nu weet je hoe je jezelf kan beschermen.";
            part11point1.text = "Er is nog een ding dat je kan doen met je laser.";
            part11point2.text = "Zoek rond deze omgeving. Je zal een grote brandende stuk ruimteafval vinden.";
            part11point3.text = "Deze is te groot om op te pakken. Schiet het met je laser om hem op te ruimen. Probeer het nu.";
            part11point4.text = "Goed gedaan! Nu weet je hoe je grote ruimteafval kan opruimen.";
            part12.text = "Als je deze doelen en prestaties voltooit, zal je bonuspunten krijge.";
            part13.text = "Je tijd is beperkt, dus denk snel, de hemelkaart zal je de weg wijzen.";
            part14.text = "Hemelkaart legenda:\n-Blauw: ruimteafval.\n-Groen: Het ruimtestation.\n-Rood: astroiden.";
            part15.text = "Dat was het voor de tutorial, success en veel plezier!";
            OB1.text = "Verzamelde afval: 0 / 5";
            OB2.text = "Stort afval over 50%: 0 / 2";
            CH1.text = "Wordt geraakt door een astroid +5 punten";
            CH2.text = "Verzamel 20 satelieten +15 punten";
        }
    }
}
