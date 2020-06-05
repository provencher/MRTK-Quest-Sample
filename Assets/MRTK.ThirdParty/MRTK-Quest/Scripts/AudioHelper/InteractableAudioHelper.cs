using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using UnityEngine.Audio;

namespace prvncher.MixedReality.Toolkit.Audio
{
    [RequireComponent(typeof(Interactable))]
    public class InteractableAudioHelper : MonoBehaviour
    {
        private Interactable interactable = null;

        public AudioClip OnFocusEnterClip = null;
        public AudioClip OnFocusExitClip = null;
        public AudioClip OnClickClip = null;

        public AudioMixerGroup AudioMixerGroup = null;

        private AudioSource audioSource = null;

        private void Awake()
        {
            interactable = GetComponent<Interactable>();
            audioSource = GetComponentInChildren<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }

            audioSource.spatialBlend = 1f;
            audioSource.spatialize = true;
            interactable.OnClick.AddListener(OnClick);

            audioSource.outputAudioMixerGroup = AudioMixerGroup;
        }

        void Update()
        {
            OnFocusChanged(interactable.HasFocus);
        }

        private bool hasFocus = false;
        private float onFocusTimeout = 0.5f;
        private float lastOnFocusTime = 0f;
        private void OnFocusChanged(bool hasFocus)
        {
            if (hasFocus == this.hasFocus) return;

            this.hasFocus = hasFocus;
            if (hasFocus)
            {
                if (OnFocusEnterClip == null || (Time.time - lastOnFocusTime) < onFocusTimeout) return;
                audioSource.PlayOneShot(OnFocusEnterClip);
                lastOnFocusTime = Time.time;
            }
            else
            {
                if (OnFocusExitClip == null) return;
                audioSource.PlayOneShot(OnFocusExitClip);
            }
        }

        private void OnClick()
        {
            if (OnClickClip == null) return;
            audioSource.PlayOneShot(OnClickClip);
        }
    }
}
