using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceThrow : MonoBehaviour
{



    private System.Random random;

    [SerializeField]
    private AudioManager audio;

    [SerializeField]
    private AnimationClip[] animations = new AnimationClip[6];
    public int nombre1;
    public int nombre2;
    public int total = 0;
    [SerializeField]
    private Animator animator;
    System.Random randomNombre;
    System.Random randomNombre2;

    [SerializeField]
    private Button btn1Dice;
    [SerializeField]
    private Button btn2Dice;

    [SerializeField]
    GameObject dice2;

    public bool gare = false;


    // Start is called before the first frame update
    void Start()
    {

        randomNombre = new System.Random();
        randomNombre2 = new System.Random();

        if (animator == null)
        {
            Debug.LogError("Animator not found.");
        }
        random = new System.Random();

        
        //num = random.Next(1, 7);
        //animator.SetInteger("valeurDe", num);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.GetInstance().activePlayer.bothDice)
        {
            Debug.Log(GameManager.GetInstance().activePlayer.bothDice);
            dice2.SetActive(false);
            btn2Dice.interactable = false;

        }
        else
        {
            btn2Dice.gameObject.SetActive(true);

            btn2Dice.interactable = true;
        }
        

    }



    public void resetDice()
    {
        gameObject.SetActive(false);
        dice2.SetActive(false);
        nombre1 = 0;
        dice2.GetComponent<SecondDice>().nombre2 = 0;
        btn1Dice.interactable = true;

    }


    public void LancerDe()
    {
        if (GameManager.GetInstance().activePlayer.canThrow == true)
        {
            audio.playDice();
            GameManager.GetInstance().activePlayer.canThrow = false;
            gameObject.SetActive(true);
            StartCoroutine(PlayFirstAnimationAndWait());
        }
        
        //finishedThrow = true;
        //StartCoroutine(BlockButton());

        /*
        if (finishedThrow)
        {
            
        }
        */


        //animator.SetInteger("valeurDe", num);

    }

    IEnumerator PlayFirstAnimationAndWait()
    {
        // Reproduce la primera animación
        //animator.Play("still");
        btn1Dice.interactable = false;
        

        // Espera a que la primera animación termine
        yield return new WaitForSeconds(animator.GetCurrentAnimatorClipInfo(0).Length * 3f);
        animator.SetTrigger("finished");



        dice2.GetComponent<SecondDice>().nombre2 = randomNombre2.Next(5, 6);

        nombre1 = randomNombre.Next(5, 6);
        animator.SetInteger("valeurDe", nombre1);
        if (!dice2.activeSelf)
        {
            total = nombre1;
        }
        else
        {
            total = nombre1 + dice2.GetComponent<SecondDice>().nombre2;
        }
        Debug.Log(nombre1);


        PlayerManager.GetInstance().CheckCardEffect(total);


        //Invoke("resetDice", 6f);





    }

 
}

