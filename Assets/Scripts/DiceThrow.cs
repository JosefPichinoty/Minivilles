using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceThrow : MonoBehaviour
{



    private System.Random random;

    [SerializeField]
    private AnimationClip[] animations = new AnimationClip[6];
    public int nombre1;
    public int nombre2;
    public int total = 0;
    [SerializeField]
    private Animator animator;
    System.Random randomNombre;
    [SerializeField]
    private Button btn;

    [SerializeField]
    GameObject dice2;

    public bool gare = false;


    // Start is called before the first frame update
    void Start()
    {
        dice2.SetActive(false);

        randomNombre = new System.Random();

        if (animator == null)
        {
            Debug.LogError("Animator not found.");
        }
        random = new System.Random();

        if (!dice2.activeSelf)
        {
            dice2.GetComponent<SecondDice>().nombre2 = 0;
        }
        //num = random.Next(1, 7);
        //animator.SetInteger("valeurDe", num);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gare)
        {
            dice2.SetActive(false);
        }

    }



    public void resetDice()
    {
        gameObject.SetActive(false);
        dice2.SetActive(false);
        nombre1 = 0;
        dice2.GetComponent<SecondDice>().nombre2 = 0;
        btn.interactable = true;

    }


    public void LancerDe()
    {
        if (GameManager.GetInstance().activePlayer.canThrow == true)
        {
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
        btn.interactable = false;
        

        // Espera a que la primera animación termine
        yield return new WaitForSeconds(animator.GetCurrentAnimatorClipInfo(0).Length * 3f);
        animator.SetTrigger("finished");


        nombre1 = randomNombre.Next(4, 5);
        animator.SetInteger("valeurDe", nombre1);
        Debug.Log(nombre1);

        total = nombre1 + dice2.GetComponent<SecondDice>().nombre2;
        PlayerManager.GetInstance().CheckCardEffect(nombre1);


        //Invoke("resetDice", 6f);





    }

 
}

