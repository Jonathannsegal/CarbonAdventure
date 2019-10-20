using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour
{
    public Text carbon = null;
    public Text money = null;
    public Text tree = null;

    public int carbonCount = 50;
    public int moneyCount = 1000;
    public int treeCount = 0;

    public void plantTrees()
    {
        treeCount += 10;
        moneyCount -= 100;
        if((carbonCount - 10) >= 0)
        {
            carbonCount -= 10;
        } 
        else if(carbonCount != 0)
        {
            carbonCount = 0;
        }
        
        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
    }

    public void buildSolarPanels()
    {
        moneyCount += 150;
        treeCount -= 20;
        carbonCount -= 2;

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
    }

    public void buildWindTurbines()
    {
        moneyCount += 200;
        treeCount -= 30;
        carbonCount -= 3;

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
    }

    public void buildHyrdoelectricPlant()
    {
        moneyCount += 300;
        treeCount -= 40;
        carbonCount -= 4;

        tree.text = "Trees: " + treeCount.ToString();
        money.text = "Money: $" + moneyCount.ToString();
        carbon.text = "Carbon: " + carbonCount.ToString() + "%";
    }
}
