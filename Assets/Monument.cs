using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Monument : MonoBehaviour
{
    public void BuyMonument(Sprite prefab)
    {
        print(gameObject.name);
        gameObject.GetComponent<Image>().sprite = prefab;
        gameObject.GetComponent<Button>().SetEnabled(false);
        
    }

}
