using UnityEngine;
using UnityEngine.UI;

public class CamPosition : MonoBehaviour
{
    private int _currentCam = 1;
    private int _tempPlayer;
    public Camera camera;
    public float CameraSpeed = 10;

    public void CamUp()
    {
        if (_currentCam == 1 || _currentCam == 2 || _currentCam == 3)
            _currentCam++;
        else
            _currentCam = 1;
    }

    public void CamDown()
    {
        if (_currentCam == 4 || _currentCam == 2 || _currentCam == 3)
            _currentCam--;
        else
            _currentCam = 4;
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
                camera.transform.position = Vector2.Lerp(camera.transform.position, new Vector2(15, 10),
                    Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.orthographicSize =
                    Mathf.Lerp(camera.orthographicSize, 8, Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.transform.rotation =
                    Quaternion.Lerp(camera.transform.rotation, Quaternion.Euler(0, 0, -0),
                        Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                break;
            case 2:
                camera.transform.position = Vector2.Lerp(camera.transform.position, new Vector2(45, 10),
                    Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.orthographicSize =
                    Mathf.Lerp(camera.orthographicSize, 8, Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.transform.rotation =
                    Quaternion.Lerp(camera.transform.rotation, Quaternion.Euler(0, 0, 0),
                        Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                break;
            case 3:
                camera.transform.position = Vector2.Lerp(camera.transform.position, new Vector2(45, 25),
                    Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.orthographicSize =
                    Mathf.Lerp(camera.orthographicSize, 8, Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.transform.rotation =
                    Quaternion.Lerp(camera.transform.rotation, Quaternion.Euler(0, 0, -180),
                        Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                break;
            case 4:
                camera.transform.position = Vector2.Lerp(camera.transform.position, new Vector2(15, 25),
                    Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.orthographicSize =
                    Mathf.Lerp(camera.orthographicSize, 8, Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.transform.rotation =
                    Quaternion.Lerp(camera.transform.rotation, Quaternion.Euler(0, 0, 180),
                        Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                break;
            case 5:
                camera.transform.position = Vector2.Lerp(camera.transform.position, new Vector2(30, 17),
                    Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.orthographicSize =
                    Mathf.Lerp(camera.orthographicSize, 15, Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                camera.transform.rotation =
                    Quaternion.Lerp(camera.transform.rotation, Quaternion.Euler(0, 0, 0),
                        Mathf.Clamp(CameraSpeed * Time.deltaTime, 0, 1));
                break;
        }
    }
}