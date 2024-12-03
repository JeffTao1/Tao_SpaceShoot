using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class CAMERA : MonoBehaviour
{
    [SerializeField] Camera followCamera;
    Vector2 viewportHalfSize;
    float leftBoundaryLimit;
    float rightBoundaryLimit;
    float bottomBoundaryLimit;

    
    [SerializeField] Transform target;
    [SerializeField] Vector2 offset;
    [SerializeField] float smoothingTheCameraMovement = 5f;
    Vector3 shakeOffest = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
      
        CalculateCameraBoundaries();
    }

    void CalculateCameraBoundaries()
    {
        viewportHalfSize = new Vector2(followCamera.orthographicSize * followCamera.aspect, followCamera.orthographicSize);

       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.G))//SHAKEING
        {
            Shake(9f, 5f);
        }
        Vector3 desitedPosition = target.position + new Vector3(offset.x, offset.y, transform.position.z) + shakeOffest;
        Vector3 smoothingPosition = Vector3.Lerp(transform.position, desitedPosition, 1 - Mathf.Exp(-smoothingTheCameraMovement * Time.deltaTime));

        smoothingPosition.x = Mathf.Clamp(smoothingPosition.x, leftBoundaryLimit, rightBoundaryLimit);
        smoothingPosition.y = Mathf.Clamp(smoothingPosition.y, bottomBoundaryLimit, smoothingPosition.y);

        transform.position = smoothingPosition;
    }
    public void Shake(float intensity, float duration)
    {
        StartCoroutine(ShakeCoroutine(intensity, duration));
    }
    private IEnumerator ShakeCoroutine(float intensity, float duration)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            shakeOffest = Random.insideUnitCircle * intensity;
            elapsed += Time.deltaTime;
            yield return null;
        }
        shakeOffest = Vector3.zero;
    }
}
