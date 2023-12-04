using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ZoomAndShow : MonoBehaviour
{
    private GameObject thisCard;

    private GameObject BuyUI;

    private GameObject bg;
    private Animator anim;
    [SerializeField]
    private GameObject nuevoObjeto;
    private AnimationClip infoAnim;


    // Start is called before the first frame update
    void Start()
    {
        thisCard = gameObject;

        BuyUI = GameObject.Find("PanelBuy");
        //nuevoObjeto = BuyUI.transform.Find("Carte").gameObject;
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
        nuevoObjeto.transform.localScale = thisCard.transform.localScale;
        nuevoObjeto.transform.position = thisCard.GetComponent<RectTransform>().position;
        nuevoObjeto.transform.rotation = thisCard.transform.rotation;
        nuevoObjeto.SetActive(true);
        
        
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
