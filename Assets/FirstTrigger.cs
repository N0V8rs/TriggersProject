using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

 public class timeLineTrigger : MonoBehaviour
 {
     public PlayableDirector Trigger1Start; // public = seeing in the inspector // PlayableDirector = Timeline in Unity for game object // TimeLineTrigger = the name you give it
     public bool OneTimeTrigger = false; // True if you wanna use the trigger once // Puts it in the inspector

     private void OnTriggerEnter(Collider other) // Adds the trigger to enter 
     {
        Trigger1Start.Play();// Plays the timeline ( public PlayableDirector "name of the timeline"
     }
 }

