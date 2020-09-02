using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text WaveTextbox;
    public string WaveTextPrefix;

    public Text ResourceTextbox;
    public string ResourceTextPrefix;

    public int currency;
    public int wave;

    // Start is called before the first frame update
    void Start()
    {
        currency = 5;
        wave = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateResource();
        UpdateWave();
    }

    void UpdateResource()
    {
        ResourceTextbox.text = ResourceTextPrefix + currency;
    }

    void UpdateWave()
    {
        WaveTextbox.text = wave + WaveTextPrefix;
    }
}
