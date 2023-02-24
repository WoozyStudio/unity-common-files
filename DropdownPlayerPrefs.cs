using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownPlayerPrefs : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Dropdown controlsDropdown;

    void Start()
    {
        LoadValues();
    }

    private void LoadValues()
    {
        controlsDropdown.value = PlayerPrefs.GetInt("ControlsType");
    }

    public void SaveDropdownValues()
    {
        PlayerPrefs.SetInt("ControlsType", controlsDropdown.value);
    }
}
