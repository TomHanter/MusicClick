using System;
using UnityEngine;

namespace DefaultNamespace.UI
{
    public class Sounds : MonoBehaviour
    {
        [SerializeField]
        private AudioSource musicSource;
        [SerializeField] private float muffledMultiplier = 0.3f;
        [Header("Debug")]
        [SerializeField] private float realSound = 1;
        [SerializeField] private bool muffled;


        private void Awake()
        {
            if (musicSource == null)
            {
                throw new NullReferenceException();
            }
        }

        public void MasterVolume(float volume)
        {
            realSound = volume;
            if (muffled)
            {
                Muffle();
            }
            else
            {
                DeMuffle();
            }
        }

        public void ToggleMusic()
        {
            musicSource.mute = !musicSource.mute;
        }
        
        public void Toggle(bool value)
        {
            musicSource.mute = value;
        }

        public void Muffle()
        {
            musicSource.volume = realSound * muffledMultiplier;
            muffled = true;
        }

        public void DeMuffle()
        {
            musicSource.volume = realSound;
            muffled = true;
        }
    }
}