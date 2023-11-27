using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamPosition : MonoBehaviour
{
    public int currentCam = 1;
    public GameObject follower;
    public CinemachineVirtualCamera virtualCamera;
    public bool isUnzoomed = false;
    public void CamUp()
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
    public void CamDown()
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
    public void CamAll()
    {
        currentCam = 5;
        
        
    }
    void LateUpdate()
    {
        switch (currentCam)
        {
            case 1:
                follower.transform.position = new Vector2(15, 10); virtualCamera.m_Lens.OrthographicSize = 8; break;
            case 2:
                follower.transform.position = new Vector2(45, 10); virtualCamera.m_Lens.OrthographicSize = 8; break;
            case 3:
                follower.transform.position = new Vector2(45, 25); virtualCamera.m_Lens.OrthographicSize = 8; break;
            case 4:
                follower.transform.position = new Vector2(15, 25); virtualCamera.m_Lens.OrthographicSize = 8; break;
            case 5:
                follower.transform.position = new Vector2(30, 17); virtualCamera.m_Lens.OrthographicSize = 15; break;

        }
        
    }
}
