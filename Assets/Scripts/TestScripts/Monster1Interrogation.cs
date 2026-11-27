using System;
using UnityEngine;
using UnityEngine.Serialization;
using Yarn.Unity;

public class Monster1Interrogation : MonoBehaviour
{
    [SerializeField] private DialogueRunner dialogueRunner;
    public async YarnTask Start()
    {
        await dialogueRunner.RunDialogue("Monster_1");
        Debug.Log("Dialogue Monster_1 finished!");
    }
}
