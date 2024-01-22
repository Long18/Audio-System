using Long18.System.Audio.Data;
using UnityEngine;

namespace Long18.System.Audio
{
    public class PlayMusicOnSceneAwake : MonoBehaviour
    {
        [Header("Raise on")] [SerializeField] private AudioCueEventChannelSO _musicEventChannel;

        [Header("Configs")] public AudioCueSO MusicTrack;

        private void Awake()
        {
            PlayBackgroundMusic();
        }

        public void PlayBackgroundMusic()
        {
            _musicEventChannel.PlayAudio(MusicTrack);
        }

        public void StopBackgroundMusic()
        {
            _musicEventChannel.PlayAudio(MusicTrack, false);
        }
    }
}