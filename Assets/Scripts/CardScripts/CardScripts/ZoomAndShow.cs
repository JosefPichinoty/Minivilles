using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomAndShow : MonoBehaviour
{

    [SerializeField]
    private GameObject thisCard;
    [SerializeField]
    private CardData data;
    [SerializeField]
    private GameObject bg;


    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        bg = GameObject.Find("GameCanvas");
        anim = GetComponent<Animator>();
        if(anim == null)
        {
            Debug.Log("There is no animator");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void showCard()
    {
        GameObject cardToZoom = Instantiate(thisCard, thisCard.transform.position, thisCard.transform.rotation);
        cardToZoom.transform.SetParent(bg.transform);
        cardToZoom.transform.SetAsLastSibling();
        Debug.Log("isntante");
        //Play animation
    }

    public void hideCard()
    {
        //Play animation
    }
}
