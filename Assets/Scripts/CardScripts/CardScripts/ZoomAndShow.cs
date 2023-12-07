using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class ZoomAndShow : MonoBehaviour
{

    [SerializeField]
    private GameObject thisCard;
    [SerializeField]
    private CardData data;


    private GameObject bg;
    private Animator anim;
    [SerializeField]
    private GameObject nuevoObjeto;
    private AnimationClip infoAnim;


    // Start is called before the first frame update
    void Start()
    {
        nuevoObjeto.SetActive(false);
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
        //Instantiate(nuevoObjeto, thisCard.transform.position, thisCard.transform.rotation);
        nuevoObjeto.SetActive(true);
        nuevoObjeto.transform.localScale = thisCard.transform.localScale;
        nuevoObjeto.transform.position = thisCard.transform.position;
        
        UnityEngine.UI.Image imagen = nuevoObjeto.GetComponent<UnityEngine.UI.Image>();

        imagen.sprite = thisCard.GetComponent<UnityEngine.UI.Image>().sprite;

        //RectTransform rectTransform = nuevoObjeto.GetComponent<RectTransform>();

        //nuevoObjeto.transform.SetParent(bg.transform);
        //nuevoObjeto.transform.SetAsLastSibling();
        //rectTransform.sizeDelta = new Vector2(thisCard.GetComponent<RectTransform>().rect.width, thisCard.GetComponent<RectTransform>().rect.height);
        //rectTransform.localScale = new Vector3(5f, 5f, 5f);
        Debug.Log("isntante");
        //Play animation
    }

    public void hideCard()
    {
        //Play animation
    }
}
