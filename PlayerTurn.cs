using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerTurn : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject[] buttons;

    public CardChoosing obj;
    public TextMeshProUGUI turntxt;

    public GameObject Pcardused;
    
    public bool enemyturn = false;
   // public bool PCused = false;


    public void buton1()
    {
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button1.SetActive(true);
    }
    public void buton2()
    {
        button1.SetActive(false);
        button2.SetActive(true);
        button3.SetActive(false);
        button4.SetActive(false);
    }
    public void buton3()
    {
        button2.SetActive(false);
        button1.SetActive(false);
        button3.SetActive(true);
        button4.SetActive(false);
    }
    public void buton4()
    {
        button2.SetActive(false);
        button3.SetActive(false);
        button1.SetActive(false);
        button4.SetActive(true);
    }

 
    public void Dest(int a)
    {
        Pcardused = obj.PlayerCards[a];
        obj.PlayerCards[a].SetActive(false);
        buttons[a].SetActive(false);
    }

    public void Playerchangeturn()
    {
        turntxt.text = "NPC";
        

        enemyturn = true;
        //PCused = true;

        obj.Playersec.SetActive(false);
        obj.NPCsec.SetActive(true);
        obj.Predicsec.SetActive(true);
    }

    public void skip()
    {
        Pcardused = null;
        enemyturn = true;

        turntxt.text = "NPC";
        

        //PCused = false;
        obj.Playersec.SetActive(false);
        obj.NPCsec.SetActive(true);
        obj.Predicsec.SetActive(true);
    }
}   