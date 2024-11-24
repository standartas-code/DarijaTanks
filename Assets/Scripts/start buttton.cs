using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startbuttton : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
