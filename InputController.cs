using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputController : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField nameInput;

    void Start()
    {
        LoadSettings();
    }

    private void LoadSettings()
    {
        nameInput.text = PlayerPrefs.GetString("NameInput");
    }

    public void SetNamePref()
    {
        PlayerPrefs.SetString("NameInput", nameInput.text);
    }
}
