using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanel : MonoBehaviour
{

    public GameObject objectToTrack;

    public void ChangePanelState()
    {
        objectToTrack.SetActive(objectToTrack.activeSelf ? false : true);

        if (objectToTrack.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

}
