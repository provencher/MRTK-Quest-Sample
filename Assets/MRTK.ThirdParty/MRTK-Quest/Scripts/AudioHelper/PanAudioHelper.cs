using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

namespace prvncher.MixedReality.Toolkit.Audio
{
    [RequireComponent(typeof(HandInteractionPanZoom))]
    public class PanAudioHelper : MonoBehaviour
    {
        [SerializeField]
        private AudioClip onPanningClip = null;

        private AudioSource panAudioSource = null;

        private void OnEnable()
        {
            var panZoomHandler = GetComponent<HandInteractionPanZoom>();
            panZoomHandler.PanStarted.AddListener(OnPanUpdated);

            panAudioSource = panZoomHandler.EnsureComponent<AudioSource>();
        }

        private void OnDisable()
        {
            var panZoomHandler = GetComponent<HandInteractionPanZoom>();
            panZoomHandler.PanStarted.RemoveListener(OnPanUpdated);
        }

        private void OnPanStarted()
        {
            panAudioSource.clip = onPanningClip;
            panAudioSource.loop = true;
            panCoolDown = onPanningClip.length;
            panAudioSource.Play();
        }

        private float panCoolDown = 1f;
        private float lastPanTime = 0f;
        private void OnPanUpdated(HandPanEventData panData)
        {
            if (!panAudioSource.isPlaying)
            {
                OnPanStarted();
            }
            lastPanTime = Time.time;
        }

        private void OnPanEnded()
        {
            panAudioSource.Stop();
        }

        private void Update()
        {
            if(!panAudioSource.isPlaying) return;
            float timeSincePan = Time.time - lastPanTime;
            if(timeSincePan > panCoolDown)
            {
                OnPanEnded();
            }
            else
            {
                float volumeRatio = 1f - Mathf.Clamp01(timeSincePan / panCoolDown);
                panAudioSource.volume = volumeRatio;
            }
        }
    }
}