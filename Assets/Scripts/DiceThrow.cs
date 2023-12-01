using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceThrow : MonoBehaviour
{

    private System.Random random;
    [SerializeField]
    private AnimationClip initialAnim;
    [SerializeField]
    private AnimationClip[] animations = new AnimationClip[6];
    private int nombre;
    [SerializeField]
    private Animator animator;
    private bool finishedThrow = false;
    private int animValue = -1;


    // Start is called before the first frame update
    void Start()
    {
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

    }


    private void resetDice()
    {
        gameObject.SetActive(false);
        nombre = 0;
        finishedThrow = false;
    }


    public void LancerDe()
    {
        gameObject.SetActive(true);
        System.Random randomNombre = new System.Random();
        nombre = randomNombre.Next(1, 7);
        Debug.Log(nombre);
        animator.SetInteger("valeurDe", nombre);

        StartCoroutine(PlayFirstAnimationAndWait());
        finishedThrow = true;

        if(finishedThrow)
        {
            Invoke("resetDice", 5f);
        }

        //animator.SetInteger("valeurDe", num);

    }

    IEnumerator PlayFirstAnimationAndWait()
    {
        // Reproduce la primera animación
        //animator.Play("still");

        // Espera a que la primera animación termine
        yield return new WaitForSeconds(animator.GetCurrentAnimatorClipInfo(0).Length);
        animator.SetTrigger("finished");

        /*
        if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5 || num ==6)
        {
            // Inicia la segunda animación
            animator.Play("4");
        }
        */
    }


}

