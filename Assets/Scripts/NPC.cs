using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC : MonoBehaviour
{
	public Transform ChatBackground;
	public Transform NPCCharacter;

	private DialogueSystem dialogueSystem;
    private bool isTalking = false;

	public string Name;

	[TextArea(5, 10)]
	public string[] sentences;

    // Start is called before the first frame update
    void Start()
    {
		dialogueSystem = FindObjectOfType<DialogueSystem>();
    }

    // Update is called once per frame
    void Update()
    {

		Vector3 Pos = Camera.main.WorldToScreenPoint(NPCCharacter.position);
		Pos.y += 175;
		ChatBackground.position = Pos;
    }

	public void OnTriggerStay(Collider other)
	{
		this.gameObject.GetComponent<NPC>().enabled = true;
        dialogueSystem.EnterRangeOfNPC();

		if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.F))
		{

            this.gameObject.GetComponent<NPC>().enabled = true;
            dialogueSystem.Names = Name;
            dialogueSystem.dialogueLines = sentences;
            dialogueSystem.NPCName();

        }
	}

	public void OnTriggerExit(Collider other)
	{
		FindObjectOfType<DialogueSystem>().OutOfRange();
		this.gameObject.GetComponent<NPC>().enabled = false;
        isTalking = false;
	}

}
