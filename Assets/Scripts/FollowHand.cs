using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHand : MonoBehaviour
{
    [SerializeField] private Transform handTransform;
    private void Update()
    {
        gameObject.transform.position = handTransform.position;
    }
}
