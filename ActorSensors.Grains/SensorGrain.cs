using ActorSensors.GrainInterfaces;
using Microsoft.Extensions.Logging;

namespace ActorSensors.Grains
{
    //[GlobalSingleInstance]
    public class SensorGrain : Orleans.Grain, ISensor
    {
        private readonly ILogger logger;

        public SensorGrain(ILogger<SensorGrain> logger)
        {
            this.logger = logger;
        }

        public Task<string> SayHello(string greeting)
        {
            logger.LogInformation($"\n SayHello message received: greeting = '{greeting}'");
            return Task.FromResult($"\n Client said: '{greeting}', so HelloGrain says: Hello!");
        }
    }
}
