using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class camera : MonoBehaviour
{
    /*
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;

    private Vector3 offset = new Vector3(0f, 2f, -10f);
    private Vector3 velocity = Vector3.zero;
    

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        zoomcam();
    }
    */

    private void Update()
    {
        zoomcam();
        //drag();
    }


    private float zoom;
    public float zoomMultiplier = 4f;
    public float minZoom;
    public float maxZoom;
    public float velocityzoom = 0f;
    public float smoothTimezoom = 0.25f;

    [SerializeField] private CinemachineVirtualCamera cam;

    private void Start()
    {
        zoom = cam.m_Lens.OrthographicSize;
    }

    private void zoomcam()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoom -= scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        cam.m_Lens.OrthographicSize = Mathf.SmoothDamp(cam.m_Lens.OrthographicSize, zoom, ref velocityzoom, smoothTimezoom);
    }

    /*
    [SerializeField] private Camera cam;
    [SerializeField] private CinemachineVirtualCamera virtualcam;

    float vertivcal;
    float moveSpeed;

    private void drag()
    {
        vertivcal = Input.GetAxisRaw("Vertical");

        if (vertivcal != 0)
        {
            virtualcam.enabled = false;
        }
        else
        {
            virtualcam.enabled = true;
        }

        // Move camera up when pressing up arrow or 'W' key
        if (vertivcal > 0f)
        {
            cam.transform.position += new Vector3(0, moveSpeed * Time.deltaTime , 0);
        }

        // Move camera down when pressing down arrow or 'S' key
        if (vertivcal < 0f)
        {
            cam.transform.position -= new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }

    }
    */
}

