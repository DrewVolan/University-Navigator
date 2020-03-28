using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public Dropdown housingCombobox;
    public Text warning;
    string housing = "БС";
    public void CheckSelected()
    {
        housing = housingCombobox.captionText.text;
        switch (housing)
        {
            case "БС":
                warning.text = "";
                break;
            case "ПК":
                warning.text = "В разработке!";
                break;
            case "АВ":
                warning.text = "В разработке!";
                break;
            case "ПР":
                warning.text = "В разработке!";
                break;
            case "СС":
                warning.text = "В разработке!";
                break;
            case "М":
                warning.text = "В разработке!";
                break;
        }
    }
    public void LoadHousing()
    {
        switch (housing)
        {
            case "БС":
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
                break;
            case "ПК":
                break;
            case "АВ":
                break;
            case "ПР":
                break;
            case "СС":
                break;
            case "М":
                break;
        }
    }
}