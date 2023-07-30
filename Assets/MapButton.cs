using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButton : MonoBehaviour
{
    [SerializeField]
    private int _id;

    public void MarkMapButton(int id)
    {
        if (_id == id)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
