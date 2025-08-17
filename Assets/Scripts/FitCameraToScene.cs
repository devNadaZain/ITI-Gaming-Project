using UnityEngine;

public class FitCameraToScene : MonoBehaviour
{
    public Camera cam;                         
    public SpriteRenderer[] objectsToFit;      

    void Start()
    {
        if (cam.orthographic && objectsToFit.Length > 0)
        {
            Bounds bounds = new Bounds(objectsToFit[0].transform.position, Vector3.zero);
            foreach (var obj in objectsToFit)
            {
                bounds.Encapsulate(obj.bounds);
            }

            cam.transform.position = new Vector3(bounds.center.x, bounds.center.y, cam.transform.position.z);

            cam.orthographicSize = bounds.extents.y;

            float screenRatio = (float)Screen.width / (float)Screen.height;
            float targetRatio = bounds.size.x / bounds.size.y;

            if (screenRatio >= targetRatio)
            {
                cam.orthographicSize = bounds.extents.y;
            }
            else
            {
                cam.orthographicSize = bounds.extents.x / screenRatio;
            }
        }
    }
}

