using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPosition : MonoBehaviour
{
    public int currentCam = 1;
    public GameObject follower;
    public void camUp()
    {
        if (currentCam == 1 || currentCam == 2 || currentCam == 3)
        {
            currentCam++; 
        }
        else
        {
            currentCam = 1;
        }

    }
    public void camDown()
    {
        if (currentCam == 4 || currentCam == 2 || currentCam == 3)
        {
            currentCam--;
        }
        else
        {
            currentCam = 4;
        }

    }
    void LateUpdate()
    {
        switch (currentCam)
        {
            case 1:
                follower.transform.position = new Vector2(15, 10); break;
            case 2:
                follower.transform.position = new Vector2(35, 10); break;
            case 3:
                follower.transform.position = new Vector2(35, 20); break;
            case 4:
                follower.transform.position = new Vector2(15, 20); break;

        }
        
    }
}
