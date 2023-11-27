using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{

    public int diceThrow;
    public System.Random rand;


    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
