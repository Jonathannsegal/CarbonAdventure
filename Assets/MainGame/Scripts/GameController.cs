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

    public Button treeButton;
    public Button solarButton;
    public Button windButton;
    public Button hydroButton;
    public Button livestockButton;
    public Button boatButton;
    public Button cityButton;
    public Button coalPlantButton;

    public void plantTrees()
    {
        treeCount += 10;
        moneyCount -= 80;
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
        disableButtons(treeCount, moneyCount);
    }

    public void buildSolarPanels()
    {
        moneyCount += 150;
        treeCount -= 20;
        carbonCount += 4;

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
        if(30 > treesNum)
        {
            windButton.interactable = false;
            boatButton.interactable = false;
        }
        if(40 > treesNum)
        {
            hydroButton.interactable = false;
            cityButton.interactable = false;
        }
        if(50 > treesNum)
        {
            coalPlantButton.interactable = false;
        }

        if(80 > moneys)
        {
            treeButton.interactable = false;
        }
    }

    public void endWorld()
    {

    }
}
