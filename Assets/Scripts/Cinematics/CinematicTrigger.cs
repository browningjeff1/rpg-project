using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics
{
    public class CinematicTrigger : MonoBehaviour
    {
        private bool onPlayerEntered = false;

        private void OnTriggerEnter(Collider other) {
            if (onPlayerEntered == false && other.gameObject.tag == "Player") {
                GetComponent<PlayableDirector>().Play();
                onPlayerEntered = true;
            }
        }
    }
}
