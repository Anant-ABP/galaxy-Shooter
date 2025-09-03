using UnityEngine;

public class musiccontrol : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int noofmusicplayers = FindObjectsByType<musiccontrol>(FindObjectsSortMode.None).Length;
        if (noofmusicplayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

}
