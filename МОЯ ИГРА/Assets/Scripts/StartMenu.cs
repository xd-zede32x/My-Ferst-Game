using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void Go()
    {
        SceneManager.LoadScene(Progress.Instance.PlayerInfo.Level + 1);
    }
}
