using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{
    public GameObject imageOriginal;
    public void PressButton()
    {
        imageOriginal.GetComponent<RawImage>().texture = this.GetComponent<RawImage>().texture;
        if (!imageOriginal.activeSelf)
        imageOriginal.SetActive(true);
    }
}
