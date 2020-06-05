using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace prvncher.MixedReality.Toolkit.Audio
{
    /// <summary>
    /// On Scene Start - Adds focus audio to all interactibles
    /// </summary>
    public class SceneAudioEnforcer : MonoBehaviour
    {
        [SerializeField]
        private AudioClip onFocusEnterClip = null;

        [SerializeField]
        private AudioClip onFocusExitClip = null;

        [SerializeField]
        private AudioClip onClickClip = null;

        [SerializeField]
        private AudioMixerGroup audioMixerGroup = null;

        IEnumerator Start()
        {
            // Wait a frame to ensure we run after the last start in the scene
            yield return null;

            // Unity UI
            foreach (var button in FindObjectsOfType<Interactable>())
            {
                var audioHelper = button.EnsureComponent<InteractableAudioHelper>();
                audioHelper.OnFocusEnterClip = onFocusEnterClip;
                audioHelper.OnFocusExitClip = onFocusExitClip;
                audioHelper.OnClickClip = onClickClip;
                audioHelper.AudioMixerGroup = audioMixerGroup;
            }
        }
    }
}
