using System.Collections;
using UnityEngine;

/*public class ShootRaycast : MonoBehaviour
{
    [SerializeField] private Transform shootPosition;
    private float laserRange = 100f, laserDuration = 0.06f;

    private Camera cam;
    private LineRenderer lineRenderer;

    void Start()
    {
        
        cam = GetComponent<Camera>();
        lineRenderer = GetComponent<LineRenderer>();
        
    }

    void Update()
    {
        
         
        if (Input.GetButtonDown("Fire1"))
        {
           
            RaycastHit hit;
           
            Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            Ray ray = new Ray(rayOrigin, cam.transform.forward);

            
            lineRenderer.SetPosition(0, shootPosition.position);
            

            if (Physics.Raycast(ray, out hit, laserRange))
            {
               

                lineRenderer.SetPosition(1, hit.point);
                Destroy(hit.transform.gameObject);
            }
            else
            {
                
                lineRenderer.SetPosition(1, shootPosition.position + cam.transform.forward * laserRange);
            }

            StartCoroutine(RenderLine());
        }
    }

    IEnumerator RenderLine()
    {
        lineRenderer.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        lineRenderer.enabled = false;
    }
}*/
using System.Collections;
using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    [SerializeField] private Transform shootPosition;
    private float laserRange = 100f, laserDuration = 0.06f;

    private LineRenderer lineRenderer;
    public AudioClip sound;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Vector3 rayOrigin = shootPosition.position;
            Ray ray = new Ray(rayOrigin, transform.forward);

            lineRenderer.SetPosition(0, shootPosition.position);
            AudioSource.PlayClipAtPoint(sound,transform.position);

            if (Physics.Raycast(ray, out hit, laserRange))
            {
                lineRenderer.SetPosition(1, hit.point);
                 if (hit.transform.CompareTag("Enemigo"))
                {
                    Destroy(hit.transform.gameObject);
                }
            }
            else
            {
                lineRenderer.SetPosition(1, shootPosition.position + transform.forward * laserRange);
            }

            StartCoroutine(RenderLine());
        }
    }

    IEnumerator RenderLine()
    {
        lineRenderer.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        lineRenderer.enabled = false;
    }
}