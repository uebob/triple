using UnityEngine;
using UnityEngine.UI;
public class SonidoManager : MonoBehaviour
{
    
    [SerializeField] Slider volumeSlider;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
}
