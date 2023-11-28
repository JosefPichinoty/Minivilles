using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dissolve : MonoBehaviour
{
    Material material;
    public bool isDissolving;
    float fade;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Image>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDissolving = true;
        }
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            isDissolving = false;
        }

        if (isDissolving)
        {
            fade = Mathf.Clamp01(fade - Time.deltaTime);
            material.SetFloat("_Fade", fade);
            material.SetColor("_Color", Color.red);
        }
        else
        {
            fade = Mathf.Clamp01(fade + Time.deltaTime);
            material.SetFloat("_Fade", fade);
            material.SetColor("_Color", Color.blue);
        }
    }
}
