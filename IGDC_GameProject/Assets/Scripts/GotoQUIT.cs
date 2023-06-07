using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoQUIT : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("QUIT");
    }
}
