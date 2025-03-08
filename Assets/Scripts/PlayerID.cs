using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerID : MonoBehaviour
{
    public GameObject buttonMaster;
    public GameObject inputField;
    [SerializeField] private TMP_InputField placeHolderText;
    public string password = "1243";
    public GameObject listCards;

    public void Enter()
    {
        if ((placeHolderText.text == password))
        {
            placeHolderText.text = "";
            ExitInputField();
            listCards.SetActive(true);
            buttonMaster.SetActive(true);
        }
        else
        {
            placeHolderText.text = "";
        }
    }
    public void ExitInputField()
    {
        inputField.SetActive(false);
        placeHolderText.text = "";
    }
}
