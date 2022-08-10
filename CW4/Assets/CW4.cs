using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CW4 : MonoBehaviour
{
    public int score = 0;
    int Increase = 1;

    public Text text0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void scoreIncreasing()
    {
        score += Increase;
        text0.text= score.ToString();
    }
        
        
        

}
