using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagment : MonoBehaviour
{
    public void ReloadLevel()
    {
        StartCoroutine(reloadlevelroutine());
    }

    IEnumerator reloadlevelroutine()
    {
        yield return new WaitForSeconds(0.5f);
        int currentlevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentlevel);
    }
}
