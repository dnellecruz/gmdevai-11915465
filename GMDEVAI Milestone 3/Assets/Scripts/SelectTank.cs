using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectTank : MonoBehaviour
{
    public Button[] buttons;

    public GameObject greenTank;
    public GameObject redTank;
    public GameObject blueTank;

    void Start()
    {
        SelectGreenTank();
    }

    public void SelectGreenTank()
    {
        ChangeTank(greenTank);
    }

    public void SelectRedTank()
    {
        ChangeTank(redTank);
    }

    public void SelectBlueTank()
    {
        ChangeTank(blueTank);
    }

    private void ChangeTank(GameObject tank)
    {
        foreach (Button button in buttons)
        {
            button.onClick.RemoveAllListeners();
        }

        buttons[0].onClick.AddListener(tank.GetComponent<FollowPath>().GoToHelipad);
        buttons[1].onClick.AddListener(tank.GetComponent<FollowPath>().GoToRuins);
        buttons[2].onClick.AddListener(tank.GetComponent<FollowPath>().GoToFactory);
        buttons[3].onClick.AddListener(tank.GetComponent<FollowPath>().GoToTwinMountains);
        buttons[4].onClick.AddListener(tank.GetComponent<FollowPath>().GoToBarracks);
        buttons[5].onClick.AddListener(tank.GetComponent<FollowPath>().GoToCommandCenter);
        buttons[6].onClick.AddListener(tank.GetComponent<FollowPath>().GoToOilRefineryPumps);
        buttons[7].onClick.AddListener(tank.GetComponent<FollowPath>().GoToTankers);
        buttons[8].onClick.AddListener(tank.GetComponent<FollowPath>().GoToRadar);
        buttons[9].onClick.AddListener(tank.GetComponent<FollowPath>().GoToCommandPost);
        buttons[10].onClick.AddListener(tank.GetComponent<FollowPath>().GoToMiddle);
    }
}
