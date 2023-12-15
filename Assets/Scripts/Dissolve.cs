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
        //On crée une copie du material utilisé pour le shader
        gameObject.GetComponent<UnityEngine.UI.Image>().material = Object.Instantiate(gameObject.GetComponent<UnityEngine.UI.Image>().material);
        material = gameObject.GetComponent<UnityEngine.UI.Image>().material;
    }

    void Update()
    {
        //Si canDissolve, on commence à faire apparaitre la carte avec le shader
        if (canDissolve)
        {
            GameManager.GetInstance().isDissolving = true;
            //On désactive la possibilité d'acheter des items du shop
            foreach (GameObject go in GameManager.GetInstance().allCards)
            {
                go.GetComponent<Button>().interactable = false;
            }

            //On met à jour le shader via fade, et on set sa couleur à blanc
            material.SetColor("_Color", Color.white);
            material.SetFloat("_Fade", fade);
            fade = Mathf.Clamp01(fade + Time.deltaTime);

            //lorsque la carte est totalement apparue
            if (fade >= 1f)
            {
                //On peut recommencer à interagir avec les cartes
                foreach (GameObject go in GameManager.GetInstance().allCards)
                {
                    go.GetComponent<Button>().interactable = true;
                }
                //On remet fade à 0 pour la prochaine carte à 0
                fade = 0f;
                canDissolve = false;
            }
        }
    }


    public void ActiveShader()
    {
        //fonction appelé lorsqu'on appelle la carte
        canDissolve = true;
    }

}
