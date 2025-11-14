using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMusicPlayer : MonoBehaviour
{
    public AudioClip menuMusic;
    public AudioClip jungleMusic;
    public AudioClip templeMusic;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        string scene = SceneManager.GetActiveScene().name;

        if (scene == "main")
        {
            Play(menuMusic);
        }
        else if (scene == "JungleScene")
        {
            Play(jungleMusic);
        }
        else if (scene == "TempleScene")
        {
            Play(templeMusic);
        }
    }

    void Play(AudioClip clip)
    {
        if (clip == null) return;

        audioSource.clip = clip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
