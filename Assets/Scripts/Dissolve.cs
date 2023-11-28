using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dissolve : MonoBehaviour
{
    public Material material;

    public bool disolve = false;
    public bool canDissolve = false;
    public bool isDissolving = false;
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
            if (disolve)
            {
                //isDissolving = true;
                fade = Mathf.Clamp01(fade - Time.deltaTime);
                material.SetFloat("_Fade", fade);
                material.SetColor("_Color", Color.red);

                if (fade <= 0f)
                {
                    //isDissolving = false;
                    canDissolve = false;
                }
            }
            else
            {
                //isDissolving = true;
                material.SetColor("_Color", Color.blue);
                material.SetFloat("_Fade", fade);
                fade = Mathf.Clamp01(fade + Time.deltaTime);

                if (fade >= 1f)
                {
                    fade = 0f;
                    //isDissolving = false;
                    canDissolve = false;
                }
            }
        }
    }


    public void ActiveShader()
    {
        canDissolve = true;
        GetComponent<UnityEngine.UI.Image>().material.SetFloat("_Fade", 0);
        disolve = false;
    }

   /* IEnumerator WaitForDisolve()
    {

    }*/

}
