namespace Lesson_6
{
    internal abstract class Transport
    {
        protected EngineType EngineType { get; set; }
        protected ModesOfTransport ModesOfTransport { get; set; }

        public EngineType GetEngineType()
        {
            return EngineType;
        }
        public ModesOfTransport GetMode()
        {
            return ModesOfTransport;
        }

        public virtual string GetTransportType()
        {
            return $"{ModesOfTransport} transport with {EngineType} engine.";
        }
    }
}
