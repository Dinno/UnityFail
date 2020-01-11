using Unity.Entities;
using Unity.Jobs;

[assembly: RegisterGenericComponentType(typeof(Generic<SomeStruct>))]

public struct Generic<T> : IBufferElementData
        where T : struct
{
}

public class ChunkGeneratorSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        Entities.ForEach((in DynamicBuffer<Generic<int>> nodes) => {}).Run();
        return inputDependencies;
    }
}
