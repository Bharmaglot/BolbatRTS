using UnityEngine;

public interface ISelectable : IHealthHolder, IIconHolder
{
    Transform ObjectTransform { get; }
}
