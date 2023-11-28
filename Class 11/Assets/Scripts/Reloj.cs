using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Reloj : MonoBehaviour
{
    private string textTiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textTiempo=Time.time.ToString();
        GameObject.Find("textReloj").GetComponent<TextMeshPro>().text=textTiempo;
    }
}
