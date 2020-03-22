using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text HPText = GetComponent<Text>();
        HPText.text = "100";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
