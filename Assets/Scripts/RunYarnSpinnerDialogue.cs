using UnityEngine;
using UnityEngine.Events;
using Yarn.Unity;
using Yarn.Unity.Attributes;

public class RunYarnSpinnerDialogue : MonoBehaviour
{
    public YarnProject project;
    [SerializeField] private DialogueRunner dialogueRunner;
    public UnityEvent onDialogueStart, onDialogueStop;

    [YarnNode(nameof(project))] public string node;

    public void StartDialogue()
    {
        onDialogueStart?.Invoke();
        dialogueRunner.StartDialogue(node);
    }

    public void StopDialogue()
    {
        dialogueRunner.Stop();
    }
}
