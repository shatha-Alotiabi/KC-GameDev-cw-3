using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    // Start is called before the first frame update

    string heroName = "shatha";
    int heroPower = 100;
    string villainName = "sakura";
    int villairPower = 70;
    float playerSpeed = 4.6f;

    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villairPower)
        {
            print(heroName + " is stronger");
        }
        else if (heroPower < villairPower)

        {
            print(villainName + " is stronger ");
        }
        else
        {
            print(heroName + "eqauls" + villainName);
        }

        SetSpeed(5.3f);
    }


    // Update is called once per frame
    void Update()
    {

    }

    void SetSpeed(float newSpeed)
    {
        print("old speed is " + playerSpeed);
        playerSpeed = newSpeed;
        print("new speed is " + playerSpeed);
        CompareSpeed(playerSpeed, newSpeed);
    }
     
    void CompareSpeed(float strongSpeed, float weakSpeed)
    {
        if (strongSpeed > weakSpeed)
        {
            print("this is bigger");
        }
        else if (strongSpeed < weakSpeed)
        {
            print("it is smaller");
        }
        else
        {
            print("they are equal");
        }
    }

}
