using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GotoGameStart : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("GameStart");
    }
}
