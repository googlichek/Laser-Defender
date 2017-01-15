using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer _instance;

    public AudioClip StartClip;
    public AudioClip GameClip;
    public AudioClip EndClip;

    private AudioSource _music;


    // Prevents from creating extra music players.
    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            _music = GetComponent<AudioSource>();
            _music.clip = StartClip;
            _music.loop = true;
            _music.Play();
        }
    }

    void OnLevelWasLoaded(int level)
    {
        _music.Stop();

        switch (level)
        {
            case 0:
                _music.clip = StartClip;
                break;
            case 1:
                _music.clip = GameClip;
                break;
            case 2:
                _music.clip = EndClip;
                break;
        }

        _music.loop = true;
        _music.Play();
    }
}
