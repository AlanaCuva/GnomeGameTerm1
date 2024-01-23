using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource _Audio;
    public DialogueManager.CharacterDialogueIDs _DialogueID;
    // Start is called before the first frame update
    void Start()
    {
        //_Audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TriggerSound()
    {
        if (!_Audio.isPlaying)
        {
            _Audio.Play();
            Debug.Log("trigger");
            FindObjectOfType<DialogueManager>().ShowDialogue(_DialogueID);//.SetText("gnome gnome gnome..");
        }
    }
   
}
