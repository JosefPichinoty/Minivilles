using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dissolve : MonoBehaviour
{
    public Material material;

    public bool canDissolve = false;
    float fade = 0f;

    void Start()
    {
        //On cr�e une copie du material utilis� pour le shader
        gameObject.GetComponent<UnityEngine.UI.Image>().material = Object.Instantiate(gameObject.GetComponent<UnityEngine.UI.Image>().material);
        material = gameObject.GetComponent<UnityEngine.UI.Image>().material;
    }

    void Update()
    {
        //Si canDissolve, on commence � faire apparaitre la carte avec le shader
        if (canDissolve)
        {
            GameManager.GetInstance().isDissolving = true;
            //On d�sactive la possibilit� d'acheter des items du shop
            foreach (GameObject go in GameManager.GetInstance().allCards)
            {
                go.GetComponent<Button>().interactable = false;
            }

            //On met � jour le shader via fade, et on set sa couleur � blanc
            material.SetColor("_Color", Color.white);
            material.SetFloat("_Fade", fade);
            fade = Mathf.Clamp01(fade + Time.deltaTime);

            //lorsque la carte est totalement apparue
            if (fade >= 1f)
            {
                //On peut recommencer � interagir avec les cartes
                foreach (GameObject go in GameManager.GetInstance().allCards)
                {
                    go.GetComponent<Button>().interactable = true;
                }
                //On remet fade � 0 pour la prochaine carte � 0
                fade = 0f;
                canDissolve = false;
            }
        }
    }


    public void ActiveShader()
    {
        //fonction appel� lorsqu'on appelle la carte
        canDissolve = true;
    }

}
