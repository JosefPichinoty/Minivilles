using UnityEngine;

public class CamPosition : MonoBehaviour
{
    private int _currentCam = 1;
    private int _tempPlayer;
    public int currentPlayer;
    public Camera newcamera;
    public float cameraSpeed = 10;

    public void TurnUp()
    {
        if (_currentCam == 1 || _currentCam == 2 || _currentCam == 3)
        {
            _currentCam++;
            currentPlayer = _currentCam;
        }
        else
        {
            _currentCam = 1;
            currentPlayer = _currentCam;
        }
    }

    public void TurnDown()
    {
        if (_currentCam == 4 || _currentCam == 2 || _currentCam == 3)
        {
            currentPlayer = _currentCam;
            _currentCam--;
        }
        else
        {
            currentPlayer = _currentCam;
            _currentCam = 4;
        }
    }

    public void CamAll()
    {
        if (_currentCam != 5)
        {
            _tempPlayer = _currentCam;
            _currentCam = 5;
        }
        else if (_currentCam == 5)
        {
            _currentCam = _tempPlayer;
        }
    }

    private void Update()
    {
        switch (_currentCam)
        {
            case 1:
                newcamera.transform.position = Vector2.Lerp(newcamera.transform.position, new Vector2(15, 10),
                    Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.orthographicSize =
                    Mathf.Lerp(newcamera.orthographicSize, 8, Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.transform.rotation =
                    Quaternion.Lerp(newcamera.transform.rotation, Quaternion.Euler(0, 0, -0),
                        Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                currentPlayer = 1;  
                break;
            case 2:
                newcamera.transform.position = Vector2.Lerp(newcamera.transform.position, new Vector2(45, 10),
                    Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.orthographicSize =
                    Mathf.Lerp(newcamera.orthographicSize, 8, Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.transform.rotation =
                    Quaternion.Lerp(newcamera.transform.rotation, Quaternion.Euler(0, 0, 0),
                        Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                currentPlayer = 2;
                break;
            case 3:
                newcamera.transform.position = Vector2.Lerp(newcamera.transform.position, new Vector2(45, 25),
                    Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.orthographicSize =
                    Mathf.Lerp(newcamera.orthographicSize, 8, Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.transform.rotation =
                    Quaternion.Lerp(newcamera.transform.rotation, Quaternion.Euler(0, 0, -180),
                        Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                currentPlayer = 3;
                break;
            case 4:
                newcamera.transform.position = Vector2.Lerp(newcamera.transform.position, new Vector2(15, 25),
                    Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.orthographicSize =
                    Mathf.Lerp(newcamera.orthographicSize, 8, Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.transform.rotation =
                    Quaternion.Lerp(newcamera.transform.rotation, Quaternion.Euler(0, 0, 180),
                        Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                currentPlayer = 4;
                break;
            case 5:
                newcamera.transform.position = Vector2.Lerp(newcamera.transform.position, new Vector2(30, 17),
                    Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.orthographicSize =
                    Mathf.Lerp(newcamera.orthographicSize, 15, Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                newcamera.transform.rotation =
                    Quaternion.Lerp(newcamera.transform.rotation, Quaternion.Euler(0, 0, 0),
                        Mathf.Clamp(cameraSpeed * Time.deltaTime, 0, 1));
                break;
        }
    }
}