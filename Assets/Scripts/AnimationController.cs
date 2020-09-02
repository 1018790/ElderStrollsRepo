using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationController : MonoBehaviour
{
    public GameObject Pawn1;
    public GameObject Pawn2;
    public GameObject Pawn3;
    public GameObject Queen;
    public GameObject audioManager;
    int step = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && step == 0)
        {
            Pawn1.GetComponent<Animation>().Play();
            Pawn1.GetComponent<AudioSource>().Play();
            step++;
        }

        else if (Input.GetKeyDown(KeyCode.F) && step == 1)
        {
            Pawn2.GetComponent<Animation>().Play();
            Pawn2.GetComponent<AudioSource>().Play();
            step++;
        }

        else if (Input.GetKeyDown(KeyCode.F) && step == 2)
        {
            Pawn3.GetComponent<Animation>().Play();
            Pawn3.GetComponent<AudioSource>().Play();
            step++;
        }

        else if (Input.GetKeyDown(KeyCode.F) && step == 3)
        {
            Queen.GetComponent<Animation>().Play();
            step++;
        }

        else if (Input.GetKeyDown(KeyCode.F) && step == 4)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
