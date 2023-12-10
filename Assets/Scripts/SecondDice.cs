using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SecondDice : MonoBehaviour
{
    private System.Random random;
    [SerializeField]
    private DiceThrow dice1;

    public int nombre2;
    [SerializeField]
    private Animator animator;
    System.Random randomNombre;
    [SerializeField]
    private Button btn;


    // Start is called before the first frame update
    void Start()
    {


        randomNombre = new System.Random();

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



    public void LancerDe()
    {
        gameObject.SetActive(true);
        StartCoroutine(PlayFirstAnimationAndWait());
    }

    IEnumerator PlayFirstAnimationAndWait()
    {
        // Reproduce la primera animación
        //animator.Play("still");
        btn.interactable = false;


        // Espera a que la primera animación termine
        yield return new WaitForSeconds(animator.GetCurrentAnimatorClipInfo(0).Length * 3f);
        animator.SetTrigger("finished");


        nombre2 = randomNombre.Next(1, 7);
        animator.SetInteger("valeurDe", nombre2);
        Debug.Log(nombre2);


        //Invoke("resetDice", 6f);





    }
}
