using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateTarjet : MonoBehaviour
{
    [SerializeField] private GameObject imageOriginal;
    [SerializeField]private GameObject reference;
    public List<Texture> Cards = new List<Texture>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Cards.Count; i++)
        {
            reference.GetComponent<RawImage>().texture = Cards[i];
            reference.GetComponent<Cards>().imageOriginal = imageOriginal;
            Instantiate(reference,gameObject.transform);
        }
    }

}
