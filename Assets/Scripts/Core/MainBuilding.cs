using UnityEngine;

public class MainBuilding : MonoBehaviour, ISelectable, IAttackable
{

    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public Vector3 RallyPoint { get; set; }


    //��������� ������� � ������� �����
    public Transform ObjectTransform => _objectTransform;
    [SerializeField] private Transform _objectTransform;
    //�����
   
    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
      
    private float _health = 1000;


}


