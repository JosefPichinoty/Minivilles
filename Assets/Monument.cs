using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Monument : MonoBehaviour
{

    [SerializeField] private Image image;
    private void Start()
    {
        image = GetComponent<Image>();
    }
    public void BuyMonument(Sprite prefab)
    {
        print(gameObject.name);
        image.sprite = prefab;
        gameObject.GetComponent<Button>().SetEnabled(false);
        
    }

}
