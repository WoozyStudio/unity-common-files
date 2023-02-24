using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResolutionController : MonoBehaviour
{
    public Toggle toggle;
    public TMP_Dropdown dropdownResolution;
    Resolution[] resolutions;


    void Start()
    {
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }

        // LookOfResolution Function //
        ResolutionFunction();

    }


    public void ActivateFullScreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }

    public void ResolutionFunction()
    {
        resolutions = Screen.resolutions;
        dropdownResolution.ClearOptions();
        List<string> options = new List<string>();
        int jelenlegiResolution = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);


            if (Screen.fullScreen && resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                jelenlegiResolution = i;
            }
        }

        dropdownResolution.AddOptions(options);
        dropdownResolution.value = jelenlegiResolution;
        dropdownResolution.RefreshShownValue();

        dropdownResolution.value = PlayerPrefs.GetInt("resolutionNumber", 0);

    }

    public void ChangeResolution(int resolutionIndex)
    {

        PlayerPrefs.SetInt("resolutionNumber", dropdownResolution.value);

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
