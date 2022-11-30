using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlinePresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectedValue;
    


    private void Start()
    {
        _selectedValue.OnSelected += onSelected;
        onSelected(_selectedValue.CurrentValue);
    }

    private void onSelected(ISelectable selected)
    {

        if (selected != null)
        {

            selected.OutlineObject.enabled = false;
        }
    }
}