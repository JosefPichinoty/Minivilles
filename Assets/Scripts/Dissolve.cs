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
        material = gameObject.GetComponent<UnityEngine.UI.Image>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (canDissolve)
        {
            GameManager.GetInstance().isDissolving = true;
            foreach (GameObject go in GameManager.GetInstance().allCards)
            {
                go.GetComponent<Button>().interactable = false;
            }

            material.SetColor("_Color", Color.white);
            material.SetFloat("_Fade", fade);
            fade = Mathf.Clamp01(fade + Time.deltaTime);

            if (fade >= 1f)
            {
                foreach (GameObject go in GameManager.GetInstance().allCards)
                {
                    go.GetComponent<Button>().interactable = true;
                }
                fade = 0f;
                canDissolve = false;
            }
        }
    }


    public void ActiveShader()
    {
        canDissolve = true;
    }

}
