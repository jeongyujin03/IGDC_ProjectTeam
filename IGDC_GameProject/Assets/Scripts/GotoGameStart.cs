using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GotoPLAY : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("PLAY");
    }
}
