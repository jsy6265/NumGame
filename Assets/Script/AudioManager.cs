using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NumGame
{
    public class AudioManager : MonoBehaviour
    {
        public AudioSource audio_button;
        public AudioSource audio_box;

        void Start()
        {
            GameManager.instance.audio = this;

        }
    }
}

