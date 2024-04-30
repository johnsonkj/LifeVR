using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoControlManager : MonoBehaviour
{
    public GameObject videoObject;
    public GameObject tvUI;
    public VideoPlayer videoPlayer;
    public RawImage screen;
    public List<VideoClip> videos;
    public Slider videoSlider;

    private bool isDraggingSlider = false;

    void Start()
    {
        videoObject.SetActive(false);
        tvUI.SetActive(false);

    }

    void Update()
    {
        // Update slider value if not dragging
        if (!isDraggingSlider)
        {
            videoSlider.value = (float)videoPlayer.time;
        }
    }

    public void OnPowerButtonClick()
    {
        tvUI.SetActive(!tvUI.activeSelf);
    }

    public void PlaySelectedVideo(int videoNo)
    {
        videoPlayer.clip = videos[videoNo];

        // Set up slider max value to video length
        videoSlider.maxValue = (float)videoPlayer.clip.length;
        videoObject.SetActive(true);
       
    }

    public void Pause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
    }

    public void Play()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }

    public void SkipForward()
    {
        videoPlayer.time += 3f; // Skip forward by 3 seconds
        videoSlider.value = (float)videoPlayer.time;
    }

    public void SkipBackward()
    {
        videoPlayer.time -= 3f; // Skip backward by 3 seconds
        videoSlider.value = (float)videoPlayer.time;
    }

    public void OnSliderValueChanged()
    {
        // Set video time based on slider value
        videoPlayer.time = videoSlider.value;
    }

    public void OnSliderDragStart()
    {
        isDraggingSlider = true;
    }

    public void OnSliderDragEnd()
    {
        isDraggingSlider = false;
    }

}
