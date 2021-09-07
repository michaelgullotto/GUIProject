using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Setingsmenu : MonoBehaviour
{
    // controls and genrates resolotuions for resolutions dropwdown
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;
     int resolutionIndex;
    public  GameObject Keybindspanel;
    public GameObject SettingsPanel;

    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider SoundEfxSlider;
    [SerializeField] Dropdown qualityDropdown;

  
    void Start()
    {
        // sets resolution
        Screen.SetResolution(1920, 1080 ,true, 60);
       // grabs reslotuions options
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionsIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height )
            {
                currentResolutionsIndex = i;
            }

        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionsIndex;
        resolutionDropdown.RefreshShownValue();
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

       
        // was saveing and loading this but i want it to load in at highest
        int qualityIndex = 5;
        SetQuality(qualityIndex);
        qualityDropdown.value = qualityIndex;

    }
    //  sets resolution all functions from here on and saved to player prefs on change

    public void SetResolution()
    {
        // resolutions is buggy so i just set to optimal resolution for game to look nice
        Screen.SetResolution(1920, 1080, true, 60);
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
