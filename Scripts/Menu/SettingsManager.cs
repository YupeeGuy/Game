using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Dropdown ResDD;
    public Dropdown QualDD;
    Resolution[] resolutions;
    void Start()
    {
        ResDD.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        int currentResindex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " " + resolutions[i].refreshRate + "Hz";
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResindex = i;
            }
        }
        ResDD.AddOptions(options);
        ResDD.RefreshShownValue();
        LoadSettings(currentResindex);
    }
    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QualitySettingPreference", QualDD.value);
        PlayerPrefs.SetInt("ResolutionPreference", ResDD.value);
        PlayerPrefs.SetInt("FullScreenPreference", System.Convert.ToInt32(Screen.fullScreen));
    }
    public void LoadSettings(int currentResolutinIndex)
    {
        if (PlayerPrefs.HasKey("QualitySettingPreference"))
        {
            QualDD.value = PlayerPrefs.GetInt("QualitySettingPreference");
        }
        else
        {
            QualDD.value = 3;
        }
        if (PlayerPrefs.HasKey("ResolutionPreference"))
        {
            ResDD.value = PlayerPrefs.GetInt("ResolutionPreference");
        }
        else
        {
            ResDD.value = currentResolutinIndex;
        }
        if (PlayerPrefs.HasKey("FullScreenPreference"))
        {
            Screen.fullScreen = System.Convert.ToBoolean(PlayerPrefs.GetInt("FullScreenPreference"));
        }
        else
        {
            Screen.fullScreen = true;
        }
    }
}
