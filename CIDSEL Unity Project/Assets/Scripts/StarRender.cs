using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRender : MonoBehaviour
{
    // The specific choice number this star represents.
    public SpriteRenderer sprRenderer;
    public byte starNumber;
    public Sprite starOn;
    public Sprite starOff;
    // Start is called before the first frame update
    void Start()
    {
        sprRenderer = GetComponent<SpriteRenderer>();
        RenderStars();
    }

    public void RenderStars()
    {
        bool turnOnStar;
        switch (starNumber)
        {
            case 1:
                turnOnStar = PersistantData.scn1Choice;
                break;
            case 2:
                turnOnStar = PersistantData.scn2Choice;
                break;
            case 3:
                turnOnStar = PersistantData.scn3Choice;
                break;
            case 4:
                turnOnStar = PersistantData.scn4Choice;
                break;
            case 5:
                turnOnStar = PersistantData.scn5Choice;
                break;
            default:
                turnOnStar = false;
                break;
        }
        if (turnOnStar)
        {
            sprRenderer.sprite = starOn;
        }
        else
        {
            sprRenderer.sprite = starOff;
        }
    }
    
}
