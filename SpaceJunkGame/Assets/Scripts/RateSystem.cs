using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RateSystem : MonoBehaviour
{
    public Button[] rateButton;
    public GameObject ratePanel;
    public Button acceptButton;

    public GameObject feedbackPanel;
    public GameObject nextRatePanel;
    public GameObject finishRate;

    public int remindRating; // open rating window at X game start

    [HideInInspector] public int ratedApp;

    public void Init(int rateCounter)
    {
        // get remind rating app value
        int remind = PlayerPrefs.GetInt("remindRating", remindRating);
        // get is rated app value
        bool isRated = PlayerPrefs.GetInt("isAppRated", 0) == 1 ? true : false;

        //Debug.Log("Game open: " + rateCounter + ", remind rating: " + remind + ", is app rated: " + isRated);

        if (remind <= rateCounter && !isRated)
        {     
            ratedApp = 0;
            RateApplication(0);
            ratePanel.SetActive(true);
            acceptButton.interactable = false;
            feedbackPanel.SetActive(false);
            nextRatePanel.SetActive(false);
            finishRate.SetActive(false);
        }
        else
        {           
            ratePanel.SetActive(false);
            feedbackPanel.SetActive(false);
            nextRatePanel.SetActive(false);
            finishRate.SetActive(false);
        }
    }

    public void RateApplication(int rate)
    {
        ratedApp = rate;

        if (rate > 0)
        {
            acceptButton.GetComponent<Button>().interactable = true;
        }

        for (int i = 0; i < rate; i++)
        {
            foreach (Transform t in rateButton[i].transform)
            {
                t.gameObject.SetActive(true);
            }
        }

        for (int i = rate; i < rateButton.Length; i++)
        {
            foreach (Transform t in rateButton[i].transform)
            {
                t.gameObject.SetActive(false);
            }
        }
    }

    //First rate panel
    public void AcceptRating()
    {
        AnalyticsManager.ReportRateApp(ratedApp);
        if(ratedApp >= 4)
        {
            NextRatePanel();
        } else
        {
            FeedbackPanel();
        }
    }

    //Second rate panel
    public void AcceptRating2()
    {
        AnalyticsManager.ReportRateApp(ratedApp);
        if (ratedApp >= 4)
        {
            FinishRate();
        }
        else
        {
            FeedbackPanel();
        }
    }

    public void NextRatePanel()
    {
        ratePanel.SetActive(false);
        feedbackPanel.SetActive(false);
        nextRatePanel.SetActive(true);
    }

    public void FeedbackPanel()
    {
        ratePanel.SetActive(false);
        feedbackPanel.SetActive(true);
    }

    public void FinishRate()
    {
        ratePanel.SetActive(false);
        feedbackPanel.SetActive(false);
        finishRate.SetActive(true);
    }

    public void RateLater()
    {
        // analytics action type
        AnalyticsManager.ReportRateType("Rate later");
        // set next rating window open after "remindRating"
        PlayerPrefs.SetInt("remindRating", PlayerPrefs.GetInt("remindRating", remindRating) + remindRating);
        // close App Rating window
        gameObject.SetActive(false);
    }
 
    public void CloseWindow(bool isRated)
    {
        if (isRated)
        {
            AnalyticsManager.ReportRateType("Rated and Close");
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("isAppRated", 1);
        }
    }
}
