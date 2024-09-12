using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mash : MonoBehaviour
{
    public GameObject character;
    private Vector3 velocity;
    public float speed;
    private Animator manimator;
    private float time;
    private bool winner = true;
    // Start is called before the first frame update
    void Start()
    {
        manimator = character.GetComponent<Animator>();
        velocity = new Vector3(speed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            manimator.SetTrigger("run");
            //Debug.Log("fghj");
            character.transform.position += velocity;
        }
        if (time > 10)
        {
            winner = false;
        }
        if (character.transform.position.x > 40 && winner)
        {
            manimator.ResetTrigger("run");

            Debug.Log("won");
            manimator.SetTrigger("won");
        }
        else if (!winner)
        {
            manimator.ResetTrigger("run");

            Debug.Log("won");
            manimator.SetTrigger("lose");
        }
    }
}
