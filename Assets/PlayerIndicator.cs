using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIndicator : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator _anim;


    public void Start()
    {
        _anim = gameObject.GetComponent<Animator>();
    }

    public void setCondition()
    {
        gameObject.SetActive(false);
    }


    public void endAnim()
    {
        _anim.SetTrigger("endAnim");
    }
}
