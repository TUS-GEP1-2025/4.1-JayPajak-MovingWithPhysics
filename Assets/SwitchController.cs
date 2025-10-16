using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public bool switchActive;
    public SpriteRenderer theSR;
    public radioController theRadio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (switchActive == true && Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            theSR.color = Color.green;
            theRadio.PlayNextSong();
        }

        if (switchActive == true && Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            theSR.color = Color.red;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switchActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switchActive = false;
        }
    }

}
