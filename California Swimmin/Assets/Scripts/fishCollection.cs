using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fishCollection : MonoBehaviour
{
    private int totalFish = 0;

    public void collectFish(int i)
    {
        totalFish += i;
        Debug.Log(totalFish);
        if (totalFish == 7){
            SceneManager.LoadScene("end");
        }
    }

    public int returnFish()
    {
        return totalFish;
    }
}
