using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScanningButton : MonoBehaviour
{
    public void OnPress()
    {
        SceneManager.LoadScene("Scanning");
    }
}
