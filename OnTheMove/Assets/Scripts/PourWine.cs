using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourWine : MonoBehaviour
{

    public GameObject wineStream;
    public Transform wineBottle;
    public Transform bottleTop;

    private bool isPouring = false;
    private bool pourCheck;
    public float bottleTopHeight;
    public float bottleMidHeight;


    // Update is called once per frame
    private void Update()
    {
        bottleMidHeight = wineBottle.position.y;
        bottleTopHeight = bottleTop.position.y;

        pourCheck = (bottleTopHeight-bottleMidHeight) > 0)

            if(isPouring != pourCheck)
        {
            isPouring = pourCheck;
            wineStream.SetActive(isPouring);
        }
    }
}
