using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGargoyleStuff : MonoBehaviour
{
    // DOT PRODUCT: check if the player gets within a certain distance of the gargoyle
    // if it is, then change the color of the screen using linear interpolation

    private GameObject playerObj = null;
    private GameObject bonusGargoyle = null;

    float interpolationRatio = 0.3f;
    
    Vector3 distanceVectorUnsquared;
    float distanceVectorSquared;
    Vector3 howMuchFloat;
    Vector3 newGargoylePosition;


    // Start is called before the first frame update
    void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.Find("JohnLemon");
        }
        if (bonusGargoyle == null)
        {
            bonusGargoyle = GameObject.Find("BonusGargoyle");
        }
        
        newGargoylePosition = bonusGargoyle.transform.position;
        //bonusGargoyle.SetActive(true);
             
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // access example:  playerObj.transform.position.x

        distanceVectorUnsquared = bonusGargoyle.transform.position - playerObj.transform.position;
        distanceVectorSquared = Vector3.Dot(distanceVectorUnsquared, distanceVectorUnsquared);
        if (distanceVectorSquared < 40 ){
            // use linear interpolation to make Gargoyle float vertically half of the distance
            // between the player and the gargoyle
            howMuchFloat = Vector3.Lerp(bonusGargoyle.transform.position, playerObj.transform.position, interpolationRatio);
            newGargoylePosition.y = (newGargoylePosition.y + Mathf.Abs(howMuchFloat.y * 0.1f)) % 3f;
            //bonusGargoyle.SetActive(true);
            bonusGargoyle.transform.localPosition = newGargoylePosition;
            //bonusGargoyle.SetActive(false);
        }
    }
}
