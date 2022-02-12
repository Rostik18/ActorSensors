using Orleans;

namespace ActorSensors.GrainInterfaces
{
    public interface ISensor : IGrainWithGuidKey
    {

        Task<string> SayHello(string greeting);
    }
}
