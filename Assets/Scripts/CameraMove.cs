using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    private IEnumerator coroutine;
    public Camera cam;

    public Vector3 camVelocity = new Vector3(0,1,0);
    public Vector3 playerVelocity = new Vector3(2,0,0);
    
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            coroutine = MoveCameraTop(0.5f);
            StartCoroutine(coroutine);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            coroutine = MoveCameraSide(0.5f);
            StartCoroutine(coroutine);
        }
    }

    private IEnumerator MoveCameraSide(float waitTime)
    {
        float timer = 0;
        while (timer < waitTime)
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(-7.5f, 0, 2), ref playerVelocity, 0.5f);
            cam.transform.position = Vector3.SmoothDamp(cam.transform.position, new Vector3(0, 0, 0), ref camVelocity, 1f);
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * 2f);
            timer += Time.deltaTime;
            yield return null;
        }
    }
    
    private IEnumerator MoveCameraTop(float waitTime)
    {
        float timer = 0;
        while (timer < waitTime)
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(-3.5f, 0, 0), ref playerVelocity, 0.5f);
            cam.transform.position = Vector3.SmoothDamp(cam.transform.position, new Vector3(0, 5, 0), ref camVelocity, 1f);
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, Quaternion.Euler(90, 90, 0), Time.deltaTime * 2f);
            timer += Time.deltaTime;
            yield return null;
        }
    }
}
