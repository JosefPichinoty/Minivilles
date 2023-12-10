using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDices : MonoBehaviour
{
    [SerializeField]
    private GameObject dice1;
    [SerializeField]
    private GameObject dice2;


    public void enableDice()
    {
        dice1.SetActive(true);
        dice2.SetActive(true);
        dice1.GetComponent<DiceThrow>().LancerDe();
        dice2.GetComponent<SecondDice>().LancerDe();

    }
}
