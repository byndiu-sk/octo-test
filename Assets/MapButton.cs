using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapButton : MonoBehaviour
{
    [SerializeField]
    private int _id;
    [SerializeField]
    private Image _image;
    [SerializeField]
    private Animator _animator;

    public void MarkMapButton(int id)
    {
        if (_id == id)
        {
            _animator.gameObject.SetActive(true);
        }
        else
        {
            _animator.gameObject.SetActive(false);
        }
    }

    

}
