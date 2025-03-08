using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Team : MonoBehaviour
{
    public GameObject fondo;
    public GameObject tagTeam;
    public Texture texture;

    public void TeamChoose()
    {
        tagTeam.GetComponent<RawImage>().texture = texture;
        fondo.SetActive(true);   
    }
}
