using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchTutorial : MonoBehaviour
{
    public Text part1;
    public Text part2;
    public Text part3;
    public Text part3point1;
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
    public Text part11point5;
    public Text part11point6;
    public Text part11point7;
    public Text part11point8;
    public Text part11point9;
    public Text part11point10;
    public Text part12;
    public Text part13;
    public Text part14;
    public Text part15;
    public Text part15yes;
    public Text part15no;
    public Text part16;
    public Text part17;
    public TextMeshProUGUI Goal1;
    public TextMeshProUGUI Goal2;
    public TextMeshProUGUI Goal3;
    public TextMeshProUGUI Goal4;
    public TextMeshProUGUI Goal5;
    public TextMeshProUGUI Goal6;

    void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            part1.text = "Greetings, traveller. Welcome to Space Janitor. My name is Astro and I'll be your instructor.";
            part2.text = "We have a serious problem on hand! Earth's orbit is being polluted by space junk!";
            part3.text = "It's your job to handle the situation and clean up this mess.";
            part3point1.text = "If you know how to play already, please press the skip button, here.";
            part4.text = "Don't worry, I'll guide you through the tutorial.";
            part5.text = "Lets start with the basics. To control your spaceship, press this virtual joystick here.";
            part5.fontSize = 24;
            part6.text = "Good! Now try to move around and collect 3 junk parts.";
            part7.text = "Once you have collected 3 pieces of junk, dispose of them at the space station.";
            part8.text = "Good Job! Now try to get hit by an asteroid.";
            part9.text = "Once you've been hit, you lose your load. But there is way to get rid of obstacles.";
            part10.text = "Press this button here to shoot lasers.";
            part11.text = "Nice work! This laser will destroy asteroids. Now you know how to defend yourself.";
            part11point1.text = "There is one other thing you can do with the laser.";
            part11point2.text = "Search around the area. You will find a burning piece of space junk.";
            part11point3.text = "This one is too big to pick up. You must shoot these flaming big pieces of space trash before you can clean it up. Try it out.";
            part11point4.text = "Good job! Now you know how to pick up big space trash.";
            part11point5.text = "There is one last thing I want to teach you.";
            part11point6.text = "These are upgrades. After you beat a level, you can choose one.";
            part11point7.text = "This is the booster upgrade. It will let you go faster with your ship.";
            part11point8.text = "This is the weapon upgrade. It will make your laser more powerful.";
            part11point9.text = "This is the capacity upgrade. With this, you can carry more junk.";
            part11point10.text = "This is the immunity upgrade. You're invincible from asteroids with his for a while.";
            part12.text = "Objectives and achievements will appear here. Completing these give you bonus points.";
            part13.text = "Time is also limited, so think fast while the map will show you the way.";
            part14.text = "Minimap Indicator\n\n- Blue: Space trash\n\n-Green: The space station\n\n- Red: Asteroids";
            part15.text = "That is it for the tutorial, are you ready for the main game?";
            part15yes.text = "Ready";
            part15no.text = "Not Ready (replay tutorial)";
            part15no.fontSize = 12;
            part16.text = "Then good luck, and have fun!";
            part17.text = "Then we will go over this again.";
            Goal1.text = "Move your ship with the virtual joystick on your screen.";
            Goal2.text = "Collect 3 pieces of space trash.";
            Goal3.text = "Dump the pieces of trash at the space station.";
            Goal4.text = "Get hit by an asteroid.";
            Goal5.text = "Shoot your laser.";
            Goal6.text = "Shoot the big space junk in the area.";
        }
        else
        {
            part1.text = "Gegroet, reiziger. Welkom bij Ruimte Schoonmaker. Mijn naam is Astro, en ik zal jouw instructeur zijn.";
            part2.text = "We hebben een ernstig probleem! De baan van onze aarde wordt vervuild door ruimteafval!";
            part3.text = "Aan jou de taak om deze vervuiling op te ruimen.";
            part3point1.text = "Als je al weet hoe je moet spelen, druk op deze skip knop.";
            part4.text = "Maak je geen zorgen, ik zal je leiden door deze les.";
            part5.text = "Laten we met het basis beginnen. Om je ruimteschip te bedienen, gebruik deze virtuele joystick.";
            part5.fontSize = 20;
            part6.text = "Goed zo! Probeer nu rond te bewegen en 3 stukken afval te verzamelen.";
            part7.text = "Wanneer je 3 stukken afval hebt verzamelt, gooi ze weg op het ruimtestation.";
            part8.text = "Goed gedaan! Probeer nu door een asteroïde geraakt te worden.";
            part9.text = "Wanneer je geraakt wordt, verlies je wat van je lading. Maar er is een manier om van deze obstakels af te komen.";
            part10.text = "Druk op deze knop om je laser te schieten.";
            part11.text = "Goed zo! Deze laser kan asteroïden verwoesten. Nu weet je hoe je jezelf kan beschermen.";
            part11point1.text = "Er is nog een ding dat je kan doen met je laser.";
            part11point2.text = "Zoek rond deze omgeving. Je zal een grote brandende stuk ruimteafval vinden.";
            part11point3.text = "Deze is te groot om op te pakken. Schiet het met je laser om hem op te ruimen. Probeer het nu.";
            part11point4.text = "Goed gedaan! Nu weet je hoe je grote ruimteafval kan opruimen.";
            part11point5.text = "Er is nog een laatste ding dat ik je wil leren.";
            part11point6.text = "Dit zijn upgrades. Nadat je een level haalt, kan je een upgrade kiezen om te gebruiken.";
            part11point7.text = "Dit is de booster upgrade. Hiermee kan je sneller gaan met je schip.";
            part11point8.text = "Dit is de wapen upgrade. Hiermee is je laser krachtiger.";
            part11point9.text = "Dit is de capaciteitsupgrade. Hiermee kan je meer afval dragen.";
            part11point10.text = "Dit is de immuniteitsupgrade. Hiermee wordt je voor een korte tijd onraakbaar door asteroïden.";
            part12.text = "Hier staan je doelen en prestaties. Als je ze voltooit, zul je bonuspunten krijgen.";
            part13.text = "Je tijd is beperkt, dus denk snel, de hemelkaart zal je de weg wijzen.";
            part14.text = "Hemelkaart legenda\n\n-Blauw: ruimteafval\n\n-Groen: Het ruimtestation\n\n-Rood: asteroïden";
            part15.text = "Dat was het voor de tutorial, ben je klaar voor het hoofdspel?";
            part15yes.text = "Klaar";
            part15no.text = "Niet klaar (herspeel instructies)";
            part15no.fontSize = 15;
            part16.text = "Veel geluk, en veel speelplezier!";
            part17.text = "Dan zullen we weer overnieuw beginnen met deze instructie.";
            Goal1.text = "Beweeg je schip met het virtuele joystick.";
            Goal2.text = "Verzamel 3 stukken ruimteafval.";
            Goal3.text = "Stort ruimteafval bij de ruimtestation.";
            Goal4.text = "Wordt geraakt door een asteroid.";
            Goal5.text = "Schiet je laser.";
            Goal6.text = "Schiet de grote ruimteafval in je omgeving.";
        }
    }
}
