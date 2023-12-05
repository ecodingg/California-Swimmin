using UnityEngine;
using TMPro;

public class infoText : MonoBehaviour
{
    public TextMeshProUGUI fishText, airText;
    public fishCollection fishy;
    public Air playerAir;
    private int fishLeft, airLeft;

    void Update()
    {
        //Get the amount left
        fishLeft = fishy.returnFish();
        airLeft = playerAir.returnAir();

        //Convert to string
        string fishString = fishLeft.ToString();
        string airString = airLeft.ToString();

        //Display
        fishText.text = "Fish Left:\n" + fishString + "/7";
        airText.text = "Air Left:\n" + airString + "/100";
    }
}