using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchLvl3Cutscene : MonoBehaviour
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

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            part1.text = "Good job, you have cleared the earth's atmosphere of space debris!";
            part2.text = "We on earth are very proud of your work. Thanks to you, we can now safely explore the galaxy!";
            part3.text = "But...";
            part4.text = "Our mission is not done yet.";
            part5.text = "Even though you've collected a lot of space trash today, it is only a fraction of what is out there in the sky.";
            part6.text = "Currently, there are 34,000 pieces of space debris, large enough to seriously damage equipment, in the sky, according to the European Space Agency.";
            part7.text = "This is still stopping us from going further into space. In there future, this number will only grow, to the point that we won't be able to contain it anymore.";
            part8.text = "There is not much ordinary people can do to help, other than being aware of this issue.";
            part9.text = "Thank you for playing Space Janitor, and we hope we have made you aware of this problem.";
        }
        else
        {
            part1.text = "Goed gedaan, je hebt de aarde’s atmosfeer van ruimteafval schoongemaakt!";
            part2.text = "Wij op aarde zijn erg trots op jou werk. Met dank aan jou kunnen we nu veilig het heelal verkennen!";
            part3.text = "Maar…";
            part4.text = "Onze missie is nog niet volbracht.";
            part5.text = "Ookal heb je erg veel ruimteafval opgeruimt vandaag, het is maar een klein deel van wat er in de lucht rond vliegt.";
            part6.text = "Op dit moment zijn er 34.000 stukken ruimteafval die rondvliegen in de lucht groot genoeg om ernstige schaden aan te richten aan apparatuur, volgens de Europese Ruimteagentschap.";
            part7.text = "Dit houdt ons alsnog tegen om verder de ruimte in te gaan. In de toekomst zal dit nummer groter worden, tot het punt dat het niet meer beheersbaar is.";
            part8.text = "Er is niet veel wat normale mensen kunnen doen, anders dan over dit onderwerp bekend zijn.";
            part9.text = "Dank je wel voor het spelen van Ruimte Concierge, we hopen dat we je meer bewust hebben gemaakt van dit probleem.";
        }
    }
}
