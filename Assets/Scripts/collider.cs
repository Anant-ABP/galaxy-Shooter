using UnityEngine;

public class collider : MonoBehaviour
{
    [SerializeField] GameObject DestroyedVFX;


    scenemanagment sceneManagment;
    void Start()
    {
        sceneManagment = FindFirstObjectByType<scenemanagment>();
    }
    public void OnTriggerEnter(Collider other)
    {
        sceneManagment.ReloadLevel();
        Instantiate(DestroyedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
