using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Setingsmenu : MonoBehaviour
{
    // controls and genrates resolotuions for resolutions dropwdown
    
    Resolution[] reso;
     int resolutionIndex;
    public  GameObject Keybindspanel;
    public GameObject SettingsPanel;
    public int resosaved = 0;
    public int qulitysaved = 0;
    public int currentResoIndex;
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider SoundEfxSlider;
    [SerializeField] Dropdown qualityDropdown;
    public Dropdown resoDropdown;
  
    void Start()
    {

        resosaved = PlayerPrefs.GetInt("ResoHasSave");
        qulitysaved = PlayerPrefs.GetInt("QualityHasSave");
        // grabs reslotuions options
         reso = Screen.resolutions;

        resoDropdown.ClearOptions();

        List<string> options = new List<string>();
        
        for (int i = 0; i < reso.Length; i++)
        {
            string option = reso[i].width + " x " + reso[i].height;
            options.Add(option);

            if (reso[i].width == Screen.currentResolution.width && reso[i].height == Screen.currentResolution.height )
            {
                currentResoIndex = i;
            }

        }
        resoDropdown.AddOptions(options);


        if (resosaved == 0)
        {
            resoDropdown.value = currentResoIndex;
            SetResolution(currentResoIndex);

        }
        else
        {
            currentResoIndex = PlayerPrefs.GetInt("ResoSave");
            resoDropdown.value = currentResoIndex;
            SetResolution(currentResoIndex);

        }
        resoDropdown.RefreshShownValue();
        // loads from player prefs


        float volume = PlayerPrefs.GetFloat("volumesave");
        SetVolmue(volume);
        volumeSlider.value = volume;

        float soundeffects = PlayerPrefs.GetFloat("Soundeffectsave" );
        SetSoundEfects(soundeffects);
        SoundEfxSlider.value = soundeffects;

        float music = PlayerPrefs.GetFloat("Musicsave");
        SetMusic(music);
        MusicSlider.value = music;


        // was saveing and loading this
        if (qulitysaved != 0)
        {
            int qualityIndex = PlayerPrefs.GetInt("Qualitysave");
            SetQuality(qualityIndex);
            qualityDropdown.value = qualityIndex;
        }

    }
    //  sets resolution all functions from here on and saved to player prefs on change

    public void SetResolution(int resolutionindex)
    {
        currentResoIndex = resolutionIndex;
        Resolution resolution = reso[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.width, Screen.fullScreen);
        PlayerPrefs.SetInt("ResoSave", resolutionIndex);
        resosaved = 1;
        PlayerPrefs.SetInt("ResoHasSave", resosaved);
    }

    // contols volume from main mixer
    public AudioMixer audioMixer;

    // 3* volumes controlers
    public void SetVolmue(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("volumesave", volume);
    }

    
    public void SetMusic(float music)
    {
        
        audioMixer.SetFloat("Music", music);
        PlayerPrefs.SetFloat("Musicsave", music);
    }
    
    public void SetSoundEfects(float soundeffects)
    {
        
        audioMixer.SetFloat("Soundeffects", soundeffects);
        PlayerPrefs.SetFloat("Soundeffectsave", soundeffects);

    }

    // controls quality of game from qulity drop down
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("Qualitysave", qualityIndex);
        qulitysaved = 1;
        PlayerPrefs.SetInt("QualityHasSave", qulitysaved);
    }
    //controls full screen from toggle
    public void SetFullsceen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void KeybindsToogleOn()
    {
        Keybindspanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
    public void KeybindsToogleOff()
    {
        Keybindspanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }


}
