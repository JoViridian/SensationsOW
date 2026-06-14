using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // reference to prefab for new audio sources
    [SerializeField] private AudioSource sourcePrefab;

    // singleton for easy access 
    private static AudioManager instance;
    public static AudioManager Instance { get { return instance; } }

    private void Awake()
    {
        // setup singleton
        if (instance != null)
            Destroy(instance.gameObject);
        instance = this;
    }

    public void PlayClip(AudioClip clip)
    {
        // create a new audio source
        AudioSource source = Instantiate(sourcePrefab);

        // set its variables
        source.clip = clip;
        source.volume = source.volume;

        // play the sound
        source.Play();

        // ensure it stays alive, say when we reload RN
        DontDestroyOnLoad(source);

        // destroy GO after play time
        Destroy(source.gameObject, clip.length);
    }
}
