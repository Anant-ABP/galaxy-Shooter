using UnityEngine;
using UnityEngine.InputSystem;

public class attack : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;
    [SerializeField] Transform targetpointer;
    [SerializeField] float worldspace = 100f;

    bool isFiring = false;


    void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        firing();
        crosshairmove();
        targetpoint();
        aimlaser();
    }
    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }
    void firing()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionenable = laser.GetComponent<ParticleSystem>().emission;
            emissionenable.enabled = isFiring;
        }
    }
    void crosshairmove()
    {
        crosshair.position = Input.mousePosition;
    }
    void targetpoint()
    {
        Vector3 targetposition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, worldspace);
        targetpointer.position = Camera.main.ScreenToWorldPoint(targetposition);
    }
    void aimlaser()
    {
        foreach (GameObject laser in lasers)
        {
            Vector3 firedirection = targetpointer.transform.position - this.transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(firedirection);
            laser.transform.rotation = rotationToTarget;
        }

    }
}
