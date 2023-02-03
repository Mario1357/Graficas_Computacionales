using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Light light;


    private bool isPaused = false;
    public float maxDistance = 10.0f;
    public float volumeDecreaseRate = 0.1f;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = Camera.main.transform;
        videoPlayer = GetComponent<VideoPlayer>();
        
    }

    void Update()
    {
        float distance = Vector3.Distance(playerTransform.position, transform.position);
        float volume = Mathf.Clamp(1.0f - (distance / maxDistance) * volumeDecreaseRate, 0.0f, 1.0f);

        videoPlayer.SetDirectAudioVolume(0, volume);
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                
                light.enabled = !light.enabled;
                PlayVideo();
                
            }
            else
            {
                light.enabled = !light.enabled;
                PauseVideo();
                
            }
        }
    }

    public void PauseVideo()
    {

        videoPlayer.Pause();
        isPaused = true;
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
        isPaused = false;
    }
}