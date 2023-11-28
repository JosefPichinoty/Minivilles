using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dissolve : MonoBehaviour
{
    Material material;

    bool isDissolving = false;
    float fade = 1f;

    void Start()
    {
        material = GetComponent<Image>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDissolving)
        {
            fade = Mathf.Clamp01(fade - Time.deltaTime);
            material.SetFloat("_Fade", fade);
            material.SetColor("_Color", Color.red);
        }
        else
        {
            material.SetColor("_Color", Color.blue);
            material.SetFloat("_Fade", fade);
            fade = Mathf.Clamp01(fade + Time.deltaTime);
        }
    }


    public void ActiveShader()
    {
        material.SetFloat("_Fade", 0);
        isDissolving = false;
    }

}
