using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class TextAnnoucement : MonoBehaviour
{
    #region SINGLETON INSTANCE
    static private TextAnnoucement instance;

    static public TextAnnoucement GetInstance()
    {
        if (instance == null) instance = new TextAnnoucement();
        return instance;
    }

    private TextAnnoucement() : base() { }
    #endregion

    [SerializeField] TMP_Text tmp;
    public float timerDuration = 2f;
    private float currentTime = 0f;
    private bool timerIsRunning = false;

    void Start()
    {
        #region SINGLETON_START
        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        instance = this;
        #endregion

        StartTimer();
        tmp = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= timerDuration)
            {
                Debug.Log("Le timer a atteint sa durée!");

                StopTimer();
            }
        }
    }

    IEnumerator StartTimer()
    {
        currentTime = 0f;
        timerIsRunning = true;
        yield return new WaitForSeconds(timerDuration);
        ContinueAfterText();
    }

    void StopTimer()
    {
        timerIsRunning = false;
        tmp.gameObject.SetActive(false);
    }

    public virtual void ChangeText(string pText)
    {
        tmp.text = pText;
        tmp.gameObject.SetActive(true);
        StartTimer();
    }

    public virtual void ContinueAfterText()
    {

    }
}
