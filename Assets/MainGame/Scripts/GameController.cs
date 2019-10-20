using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour
{

    public float timeLeft = 180.0f;
    public Text text;
    bool clock;
    private float mins;
    private float secs;

    //public GameObject Forrest1;
    public GameObject Tree1;
    public GameObject Tree2;
    public GameObject Tree3;
    public GameObject Tree4;
    public GameObject Tree5;
    public GameObject Tree6;
    public GameObject Tree7;
    public GameObject Tree8;
    public GameObject Tree9;
    public GameObject Tree10;
    public GameObject Tree11;
    public GameObject Tree12;
    public GameObject Tree13;
    public GameObject Tree14;
    public GameObject Tree15;
    public GameObject Tree16;
    public GameObject Tree17;
    public GameObject Tree18;
    public GameObject Tree19;
    public GameObject Tree20;
    public GameObject Tree21;
    public GameObject Tree22;
    public GameObject Tree23;
    public GameObject Tree24;
    public GameObject Tree25;
    public GameObject Tree26;
    public GameObject Tree27;
    public GameObject Windmills1;
    public GameObject Windmills2;
    public GameObject CoalPlant1;
    public GameObject CoalPlant2;
    public GameObject Solar1;
    public GameObject WaterWheel1;
    public GameObject WaterWheel2;
    public GameObject City1;
    public GameObject TugBoat1;
    public GameObject TugBoat2;
    public GameObject TugBoat3;
    public GameObject TugBoat4;
    public GameObject LiveStock;
    public GameObject WorldFire;
    public GameObject MoonFire;
    public GameObject GuiElements;
    public GameObject Clock;
    public GameObject GoodEnding;
    public GameObject BadEnding;


    public Text carbon = null;
    public Text money = null;
    public Text tree = null;

    public int carbonCount = 50;
    public int moneyCount = 1000;
    public int treeCount = 0;

    public Button treeButton;
    public Button solarButton;
    public Button windButton;
    public Button hydroButton;
    public Button livestockButton;
    public Button boatButton;
    public Button cityButton;
    public Button coalPlantButton;

    void Start()
    {
        GoodEnding.SetActive(false);
        BadEnding.SetActive(false);
        Tree1.SetActive(false);
        Tree2.SetActive(false);
        Tree3.SetActive(false);
        Tree4.SetActive(false);
        Tree5.SetActive(false);
        Tree6.SetActive(false);
        Tree7.SetActive(false);
        Tree8.SetActive(false);
        Tree9.SetActive(false);
        Tree10.SetActive(false);
        Tree11.SetActive(false);
        Tree12.SetActive(false);
        Tree13.SetActive(false);
        Tree14.SetActive(false);
        Tree15.SetActive(false);
        Tree16.SetActive(false);
        Tree17.SetActive(false);
        Tree18.SetActive(false);
        Tree19.SetActive(false);
        Tree20.SetActive(false);
        Tree21.SetActive(false);
        Tree22.SetActive(false);
        Tree23.SetActive(false);
        Tree24.SetActive(false);
        Tree25.SetActive(false);
        Tree26.SetActive(false);
        Tree27.SetActive(false);
        Windmills1.SetActive(false);
        Windmills2.SetActive(false);
        CoalPlant1.SetActive(false);
        CoalPlant2.SetActive(false);
        Solar1.SetActive(false);
        WaterWheel1.SetActive(false);
        WaterWheel2.SetActive(false);
        City1.SetActive(false);
        TugBoat1.SetActive(false);
        TugBoat2.SetActive(false);
        TugBoat3.SetActive(false);
        TugBoat4.SetActive(false);
        LiveStock.SetActive(false);
        WorldFire.SetActive(false);
        MoonFire.SetActive(false);
    }

    IEnumerator Wait()
    {
        timeLeft -= 1;
        UpdateTimer();
        yield return new WaitForSeconds(1);
        clock = false;
    }

    void UpdateTimer()
    {
        int min = Mathf.FloorToInt(timeLeft / 60);
        int sec = Mathf.FloorToInt(timeLeft % 60);
        text.GetComponent<UnityEngine.UI.Text>().text = min.ToString("00") + ":" + sec.ToString("00");
    }

    void Update()
    {
        if (timeLeft == 0)
        {
            endWorldGood();
        }
        if (timeLeft > 0 && clock == false)
        {
            clock = true;
            StartCoroutine(Wait());
        }
        if (carbonCount > 99)
        {
            endWorld();
        }
        if(treeCount < 1)
        {
            Tree1.SetActive(false);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(false);
            Tree5.SetActive(false);
            Tree6.SetActive(false);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(false);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(false);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(false);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(false);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(false);
        } 
        else if (treeCount > 1 && treeCount <= 11)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(false);
            Tree5.SetActive(false);
            Tree6.SetActive(false);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(false);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(false);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(false);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(false);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(false);
        }
        else if (treeCount > 11 && treeCount <= 21)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(false);
            Tree5.SetActive(false);
            Tree6.SetActive(false);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(false);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(false);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(false);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(false);
        }
        else if (treeCount > 21 && treeCount <= 31)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(false);
            Tree5.SetActive(false);
            Tree6.SetActive(false);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(false);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(false);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(false);
        }
        else if (treeCount > 31 && treeCount <= 41)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(false);
            Tree5.SetActive(false);
            Tree6.SetActive(false);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(false);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(false);
        }
        else if (treeCount > 41 && treeCount <= 51)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(false);
            Tree5.SetActive(false);
            Tree6.SetActive(false);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(false);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 51 && treeCount <= 61)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(false);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(false);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 61 && treeCount <= 71)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(false);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 71 && treeCount <= 81)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(false);
            Tree3.SetActive(false);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 81 && treeCount <= 91)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(false);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(false);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 91 && treeCount <= 101)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(false);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(false);
            Tree23.SetActive(false);
            Tree24.SetActive(true);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 101 && treeCount <= 111)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(false);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(false);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(false);
            Tree24.SetActive(true);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 111 && treeCount <= 121)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(false);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(false);
            Tree24.SetActive(true);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 121 && treeCount <= 131)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(false);
            Tree24.SetActive(true);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 131 && treeCount <= 141)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(false);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 141 && treeCount <= 151)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(false);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 151 && treeCount <= 161)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(false);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 161 && treeCount <= 171)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(false);
            Tree27.SetActive(true);
        }
        else if (treeCount > 171 && treeCount <= 181)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(false);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 181 && treeCount <= 191)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(false);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 191 && treeCount <= 201)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(false);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(true);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 201 && treeCount <= 211)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(true);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(false);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(true);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 211 && treeCount <= 221)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(true);
            Tree9.SetActive(false);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(true);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(true);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 221 && treeCount <= 231)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(true);
            Tree9.SetActive(true);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(false);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(true);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(true);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 231 && treeCount <= 241)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(true);
            Tree9.SetActive(true);
            Tree10.SetActive(true);
            Tree11.SetActive(false);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(true);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(true);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(true);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 241 && treeCount <= 251)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(true);
            Tree9.SetActive(true);
            Tree10.SetActive(true);
            Tree11.SetActive(true);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(true);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(true);
            Tree18.SetActive(true);
            Tree19.SetActive(false);
            Tree20.SetActive(true);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 251 && treeCount <= 261)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(true);
            Tree9.SetActive(true);
            Tree10.SetActive(true);
            Tree11.SetActive(true);
            Tree12.SetActive(false);
            Tree13.SetActive(true);
            Tree14.SetActive(true);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(true);
            Tree18.SetActive(true);
            Tree19.SetActive(true);
            Tree20.SetActive(true);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }
        else if (treeCount > 261 && treeCount <= 271)
        {
            Tree1.SetActive(true);
            Tree2.SetActive(true);
            Tree3.SetActive(true);
            Tree4.SetActive(true);
            Tree5.SetActive(true);
            Tree6.SetActive(true);
            Tree7.SetActive(true);
            Tree8.SetActive(true);
            Tree9.SetActive(true);
            Tree10.SetActive(true);
            Tree11.SetActive(true);
            Tree12.SetActive(true);
            Tree13.SetActive(true);
            Tree14.SetActive(true);
            Tree15.SetActive(true);
            Tree16.SetActive(true);
            Tree17.SetActive(true);
            Tree18.SetActive(true);
            Tree19.SetActive(true);
            Tree20.SetActive(true);
            Tree21.SetActive(true);
            Tree22.SetActive(true);
            Tree23.SetActive(true);
            Tree24.SetActive(true);
            Tree25.SetActive(true);
            Tree26.SetActive(true);
            Tree27.SetActive(true);
        }

    }

        public void plantTrees()
    {
        treeCount += 10;
        moneyCount -= 80;
        if ((carbonCount - 10) >= 0)
        {
            carbonCount -= 10;
        }
        else if (carbonCount != 0)
        {
            carbonCount = 0;
        }

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
        disableButtons(treeCount, moneyCount);
    }

    public void buildSolarPanels()
    {
        moneyCount += 150;
        treeCount -= 20;
        carbonCount += 4;

        Solar1.SetActive(true);

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
        disableButtons(treeCount, moneyCount);
    }

    public void buildWindTurbines()
    {
        moneyCount += 200;
        treeCount -= 30;
        carbonCount += 6;

        if (!Windmills1.active)
        {
            Windmills1.SetActive(true);
        }
        else if (!Windmills2.active)
        {
            Windmills2.SetActive(true);
        }

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
        disableButtons(treeCount, moneyCount);
    }

    public void buildHyrdoelectricPlant()
    {
        moneyCount += 300;
        treeCount -= 40;
        carbonCount += 8;

        if (!WaterWheel1.active)
        {
            WaterWheel1.SetActive(true);
        }
        else if (!WaterWheel2.active)
        {
            WaterWheel2.SetActive(true);
        }

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
        disableButtons(treeCount, moneyCount);
    }

    public void livestock()
    {
        moneyCount += 50;
        treeCount -= 20;
        carbonCount += 20;

        LiveStock.SetActive(true);

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
        disableButtons(treeCount, moneyCount);
    }

    public void boats()
    {
        moneyCount += 200;
        treeCount -= 30;
        carbonCount += 40;

        if (!TugBoat1.active)
        {
            TugBoat1.SetActive(true);
        }
        else if (!TugBoat2.active)
        {
            TugBoat2.SetActive(true);
        }
        else if (!TugBoat3.active)
        {
            TugBoat3.SetActive(true);
        }
        else if (!TugBoat4.active){
            TugBoat4.SetActive(true);

        }

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
        disableButtons(treeCount, moneyCount);
    }

    public void city()
    {
        moneyCount += 500;
        treeCount -= 40;
        carbonCount += 60;

        City1.SetActive(true);

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
        disableButtons(treeCount, moneyCount);
    }

    public void coalPlant()
    {
        moneyCount += 550;
        treeCount -= 50;
        carbonCount += 80;

        if (!CoalPlant1.active)
        {
            CoalPlant1.SetActive(true);
        }
        else if (!CoalPlant2.active)
        {
            CoalPlant2.SetActive(true);
        }

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
        disableButtons(treeCount, moneyCount);
    }

    public void disableButtons(int treesNum, int moneys)
    {
        treeButton.interactable = true;
        solarButton.interactable = true;
        livestockButton.interactable = true;
        windButton.interactable = true;
        hydroButton.interactable = true;
        boatButton.interactable = true;
        cityButton.interactable = true;
        coalPlantButton.interactable = true;

        if (20 > treesNum)
        {
            solarButton.interactable = false;
            livestockButton.interactable = false;
        }
        if (30 > treesNum)
        {
            windButton.interactable = false;
            boatButton.interactable = false;
        }
        if (40 > treesNum)
        {
            hydroButton.interactable = false;
            cityButton.interactable = false;
        }
        if (50 > treesNum)
        {
            coalPlantButton.interactable = false;
        }

        if (80 > moneys)
        {
            treeButton.interactable = false;
        }
    }

    public void endWorld()
    {
        BadEnding.SetActive(true);
        WorldFire.SetActive(true);
        MoonFire.SetActive(true);
        GuiElements.SetActive(false);
        Clock.SetActive(false);
    }

    public void endWorldGood()
    {
        GoodEnding.SetActive(true);
        GuiElements.SetActive(false);
        Clock.SetActive(false);
    }
}