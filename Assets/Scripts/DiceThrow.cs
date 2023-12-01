using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceThrow : MonoBehaviour
{
    #region SINGLETON INSTANCE
    static private DiceThrow instance;

    static public DiceThrow GetInstance()
    {
        if (instance == null) instance = new DiceThrow();
        return instance;
    }

    private DiceThrow() : base() { }
    #endregion


    private System.Random random;

    [SerializeField]
    private AnimationClip[] animations = new AnimationClip[6];
    private int nombre;
    [SerializeField]
    private Animator animator;
    private bool finishedThrow = false;
    System.Random randomNombre;
    private int animValue = -1;
    [SerializeField]
    private Button btn;


    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        instance = this;

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


    public void resetDice()
    {
        gameObject.SetActive(false);
        nombre = 0;
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


        nombre = randomNombre.Next(1, 7);
        animator.SetInteger("valeurDe", nombre);
        Debug.Log(nombre);



        //Invoke("resetDice", 6f);





    }



}

