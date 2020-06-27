using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunMekanigi : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] int tahmin;
    [SerializeField] Text txt = null;

    public void OyununBaslangici()
    {
        max += 1;
        sonrakiTahmin();
    }

    public void Arttir()
    {
        min = tahmin;
        sonrakiTahmin();
    }
    public void Azalt()
    {
        max = tahmin;
        sonrakiTahmin();
    }
    public void sonrakiTahmin()
    {
        tahmin = Random.Range(min, max);
        txt.text = tahmin.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        OyununBaslangici();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
