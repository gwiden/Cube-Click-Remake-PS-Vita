using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    public Color col;
    GameObject MainCam;

    private void Awake()
    {
        MainCam = GameObject.Find("Main Camera");
    }

    private void Update()
    {

        float n = 5 * 0.02f;

        GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, col, Time.deltaTime*0.35f);
        transform.position -= new Vector3(0.03f + n, 0, 0);
            
        if (transform.position.x < -17.65f)
        {
            MainCam.GetComponent<Game>().Lose();
            Destroy(gameObject);
            Application.LoadLevel("lose");
        }
    }
}