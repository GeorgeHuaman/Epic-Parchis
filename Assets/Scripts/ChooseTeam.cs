using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseTeam : MonoBehaviour
{
    public GameObject imageTeam;
    public GameObject teamCanvas;
    [HideInInspector]public RawImage teamChoose;

    public void TagTeam(RawImage image)
    {
        teamCanvas.SetActive(false);
        imageTeam.SetActive(true);
        imageTeam.transform.GetChild(0).GetComponent<RawImage>().texture = image.texture;
    }
}
