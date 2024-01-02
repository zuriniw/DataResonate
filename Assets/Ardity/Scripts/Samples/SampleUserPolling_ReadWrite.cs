/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using UnityEngine;
using System.Collections;
using TMPro;

/**
 * Sample for reading using polling by yourself, and writing too.
 */


public class SampleUserPolling_ReadWrite : MonoBehaviour
{
    public SerialController serialController;


    //public GameObject heatmap;
    public GameObject panel;
    public GameObject buildings;
    public GameObject data;
    public GameObject point;
    public GameObject pinpoint;

    public GameObject mode1;
    public GameObject mode2;
    public GameObject mode3;

    public GameObject SimulationPanel;
    public GameObject MappinningPanel;

    private int currentMode = 1;
    //public GameObject state2;
    //public GameObject state3;
    //三个生长状态



    // Initialization
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
        Debug.Log("Press A or Z to execute some actions");

        point.SetActive(true);

        //heatmap.SetActive(true);
        panel.SetActive(true);


        //heatmapmhq.SetActive(false);
        //heatmapmhq2.SetActive(false);
        //heatmapmhq3.SetActive(false);

        buildings.SetActive(true);
        data.SetActive(true);

        mode1.SetActive(true);
        mode2.SetActive(false);
        mode3.SetActive(false);

        SimulationPanel.SetActive(false);
        MappinningPanel.SetActive(false);
    }

    // Executed each frame
    void Update()
    {
        //---------------------------------------------------------------------
        // Send data
        //---------------------------------------------------------------------

        // If you press one of these keys send it to the serial device. A
        // sample serial device that accepts this input is given in the README.
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Sending X");
            serialController.SendSerialMessage("X");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Sending Z");
            serialController.SendSerialMessage("Z");
        }
    }


    //---------------------------------------------------------------------
    //PUBLISH VOID
    //---------------------------------------------------------------------
    public void SendC()
    {
        serialController.SendSerialMessage("C");
        Debug.Log("Sending C");
    }
    public void SendV()
    {
        serialController.SendSerialMessage("V");
        Debug.Log("Sending V");
    }
    public void SendB()
    {
        serialController.SendSerialMessage("B");
        Debug.Log("Sending B");
    }


    //public void mhq()
    //{
    //    heatmapmhq.SetActive(true);
    //    heatmapmhq2.SetActive(false);
    //    heatmapmhq3.SetActive(false);
    //    heatmap.SetActive(false);
    //}
    //public void mhq2()
    //{
    //    heatmapmhq.SetActive(false);
    //    heatmapmhq2.SetActive(true);
    //    heatmapmhq3.SetActive(false);
    //    heatmap.SetActive(false);
    //}
    //public void mhq3()
    //{
    //    heatmapmhq.SetActive(false);
    //    heatmapmhq3.SetActive(true);
    //    heatmapmhq2.SetActive(false);
    //    heatmap.SetActive(false);
    //}

    //public void returnheatmapstate()
    //{
    //    heatmapmhq.SetActive(false);
    //    heatmapmhq3.SetActive(false);
    //    heatmapmhq2.SetActive(false);
    //    heatmap.SetActive(true);
    //}
    public void ShowOrHideBuildings()
    {
        if (buildings != null)
        {
            buildings.SetActive(!buildings.activeSelf);
        }
    }
    public void ShowOrHideData()
    {
        if (data != null)
        {
            data.SetActive(!data.activeSelf);
        }
    }

    public void ShowOrHidePoint()
    {
        if (point != null)
        {
            point.SetActive(!point.activeSelf);
        }
    }
    public void ShowOrHidePinPoint()
    {
        if (pinpoint != null)
        {
            pinpoint.SetActive(!pinpoint.activeSelf);
        }
    }

    public void Simulation()
    {
        if (SimulationPanel != null)
        {
            SimulationPanel.SetActive(!SimulationPanel.activeSelf);
        }
    }
    public void Mappinning()
    {
        if (MappinningPanel != null)
        {
            MappinningPanel.SetActive(!MappinningPanel.activeSelf);
        }
    }

    public void SwitchMode()
    {
        // 每次调用这个方法时都会切换模式
        currentMode = currentMode % 3 + 1;

        // 根据currentMode的值激活相应的模式
        mode1.SetActive(currentMode == 1);
        mode2.SetActive(currentMode == 2);
        mode3.SetActive(currentMode == 3);
    }

}




