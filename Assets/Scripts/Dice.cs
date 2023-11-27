using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{

    public int diceThrow;
    public System.Random rand;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if(animator == null)
        {
            Debug.LogError("Animator not found");
        }
        rand = new System.Random();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LancerDe()
    {
        diceThrow = rand.Next(1, 7);
        StartCoroutine(DiceAnimation());


    }

    IEnumerator DiceAnimation()
    {


        // Espera a que la primera animación termine
        yield return new WaitForSeconds(animator.GetCurrentAnimatorClipInfo(0).Length);
        animator.SetTrigger("finished");
        animator.SetInteger("valeurDe", diceThrow);
    }
}
