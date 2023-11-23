using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Monument : MonoBehaviour
{

    [SerializeField] private Image image;
    public void BuyMonument(Sprite prefab)
    {
        print(gameObject.name);
        image.sprite = prefab;
        //gameObject.GetComponent<Button>().SetEnabled(false);
        
    }

}
