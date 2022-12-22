using UnityEngine;
using Zenject;

public class UiModelInstaller : MonoInstaller
{
    [SerializeField] private AssetsContext _legacyContext;
    [SerializeField] Vector3Value _vector3Value;
    [SerializeField] AttackableValue _attackableValue;
    [SerializeField] SelectableValue _selectedObject;
    [SerializeField] private Sprite _chomperSprite; 

    public override void InstallBindings()
    {
        Container.Bind<AssetsContext>().FromInstance(_legacyContext);
        Container.Bind<Vector3Value>().FromInstance(_vector3Value);
        Container.Bind<AttackableValue>().FromInstance(_attackableValue);
        Container.Bind<SelectableValue>().FromInstance(_selectedObject);

        Container.Bind<CommandCreatorBase<IProduceUnitCommand>>().To<ProduceUnitCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IAttackCommand>>().To<AttackCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IMoveCommand>>().To<MoveCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IPatrolCommand>>().To<PatrolCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IStopCommand>>().To<StopCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<ISetRallyPointCommand>>().To<SetRallyPointCommandCreator>().AsTransient();



        Container.Bind<float>().WithId("Chomper").FromInstance(5f);
        Container.Bind<string>().WithId("Chomper").FromInstance("Chomper");
        Container.Bind<Sprite>().WithId("Chomper").FromInstance(_chomperSprite);


        Container.Bind<CommandButtonsModel>().AsSingle();
    }
}
