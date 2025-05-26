using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVolume : MonoBehaviour
{
    public GameObject panneauVolume;

    public void TogglePanneau()
    {
        if (panneauVolume != null)
            panneauVolume.SetActive(!panneauVolume.activeSelf);
    }
}
