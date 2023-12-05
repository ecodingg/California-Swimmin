using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : MonoBehaviour
{
    private int air;
    private int airLeft = 100;
    public GameObject player;
    public GameObject waterLine;

    // Start is called before the first frame update
    void Start()
    {
        //Air
        air = airLeft;
        Debug.Log("Game and repeat has started");
        InvokeRepeating("airLogic", 0f, 3f);
    }

    //Air that goes away every few seconds
    private int airLoss()
    {
        airLeft -= 1;
        return airLeft;
    }

    //Gaining full air
    private int resetAir()
    {
        airLeft = 100;

        return airLeft;
    }

    private void airLogic()
    {
        Vector2 playerPosition = player.transform.position;
        Vector2 waterPosition = waterLine.transform.position;
        
        if(playerPosition.y < waterPosition.y){
            Debug.Log("Below the Water Line");
            air = airLoss();
        }
        else{
            Debug.Log("Above the Water Line");
            air = resetAir();
        }
    }

    public int returnAir()
    {
        return air;
    }
    
}
