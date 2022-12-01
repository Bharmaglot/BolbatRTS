using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlinePresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectedValue;
    [SerializeField] private GameObject _Sphere;


    private void Start()
    {
        _selectedValue.OnSelected += onSelected;
        onSelected(_selectedValue.CurrentValue);
        _Sphere.SetActive(false);
    }

    private void onSelected(ISelectable selected)
    {
        _Sphere.SetActive(false);
        if (selected != null)
        {
            _Sphere.SetActive(true);
            _Sphere.transform.position = selected.ObjectTransform.position;
        }
    }
}