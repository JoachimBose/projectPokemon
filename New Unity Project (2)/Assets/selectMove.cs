﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectMove : MonoBehaviour
{
    public move Move;
    public Text txtName;
    public Text txtStats;
    public Image img;

    public Sprite special;
    public Sprite physical;
    
    public GameObject lowestRenderer;

    /*
     * this script sits on the draggable objects in the moveselector scene. This makes sure that this can represent a move
    */

    //this is responsible that the visual elements show the right info
    public void setUp()
    {
        txtName.text = Move.name;
        txtStats.text = "power: " + Move.power.ToString() + "accuracy: " + Move.accuracy.ToString() + "pp: " + Move.power.ToString();
        if (Move.isSpecial)
        {
            img.sprite = special;
        }
        else
        {
            img.sprite = physical;
        }
    }

    //this is called when the creator of this object assigns a new move
    void setMove(move newMove)
    {
        Move = newMove;
        setUp();
    }
}
