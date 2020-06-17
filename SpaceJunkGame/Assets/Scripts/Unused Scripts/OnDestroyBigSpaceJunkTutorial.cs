using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroyBigSpaceJunkTutorial : MonoBehaviour
{
    public TutorialInteraction tutoInte;
    private void OnDestroy()
    {
        tutoInte.intro7popup = true;
    }
}
