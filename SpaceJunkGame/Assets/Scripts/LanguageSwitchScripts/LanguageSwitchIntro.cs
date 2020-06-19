using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LanguageSwitchIntro : MonoBehaviour
{
    public TextMesh story;
    public TextMesh textSkip;
    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            story.text = "Space. The final frontier.\n\n\n\nOr at least, it would have\nbeen.\n\n\nThe year is 2050. Mankind\nhas advanced their\nscientific capabilities to the\npoint where space travel is\npossible.\n\n\nOur planet, the place we\nhave called home for as\nlong as we existed, has\nnot only provided for us,\nbut has enriched our\nminds and exposed us to\nits beauty.\n\nNow, as earth's population\ncontinues to grow, a need\nfor galactic colonization has\ncome, not only for the\nexpansion of humanity's\nliving space, but to explore\nstrange new worlds, and go\nwhere no man has gone\nbefore.\n\n\nHowever, we currently face\na crisis, very close to our\nhome.\n\n\nWe cannot send any\nequipment beyond our orbit\nwithout serious damage\nfrom space debris.\n\n\nIt's your mission to clean up\nearth's orbit from any junk\nand make our dream of\ninterstellar space travel\npossible.";
            textSkip.text = "Press screen to fast forward text";
            textSkip.fontSize = 40;
        }
        else
        {
            story.text = "Ruimte. De laatste grens.\n\n\nOf te minste, dat zou het\nmoeten zijn.\n\n\nHet jaar is 2050. De mensheid\nheeft zijn wetenschappelijke\nmogelijkheid zo bevorderd\ndat ruimtevaart nu mogelijk\nis.\n\n\nOnze planeet, de plaats wat\nwe ons thuis hebben genoemd\nvoor zolang als we bestaan,\nheeft niet alleen voor ons\ngezorgt, maar heeft onze\ngeestelijk verrijkt en haar\nschoonheid aan ons laten\nzien.\n\n\nNu, terwijl de bevolking\nvan de aarde blijft groeien, \nkrijgt de mensheid een\nbehoefte voor galactische\nkolonisatie, niet alleen \nvoor het uitbreiding van de\nmensheid's leefruimte, maar \nook om het verkennen van\nvreemde nieuwe werelden, en\nnaar plekken waar niemand\ngeweest is gaan.\n\n\nEchter, we worden momenteel\ngeconfronteerd met\neen crisis, veel dichter\nbij ons thuis.\n\n\n\nWe kunnen geen apparatuur \nver van de aarde versturen\nzonder dat zeernstige schade\nvan ruimteafval krijgen.\n\n\nHet is jouw missie om de\nruimteafval rondom de aarde\nop te ruimen, en onze droom\nvan interstellaire ruimtevaart\nmogelijk te maken.";
            textSkip.text = "Hou het scherm ingedrukt om tekst te versnellen";
            textSkip.fontSize = 26;
        }
    }
}