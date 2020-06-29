using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    [SerializeField] private string scene;

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
