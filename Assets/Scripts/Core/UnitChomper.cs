using UnityEngine;

public class UnitChomper : MonoBehaviour, ISelectable, IAttackable, IUnit
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    public Transform ObjectTransform => _objectTransform;
    [SerializeField] private Transform _objectTransform;



    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;

    private float _health = 100;


}
