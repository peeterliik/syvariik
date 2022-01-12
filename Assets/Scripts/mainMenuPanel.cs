using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuPanel : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject aboutPanel;
    public GameObject winningPanel;

  public void GoToAbout()
    {
        menuPanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    public void GoBack()
    {
        menuPanel.SetActive(true);
        aboutPanel.SetActive(false);
    }

    public void GoWinningCondition()
    {
        winningPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

}
