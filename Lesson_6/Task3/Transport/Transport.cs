namespace Lesson_6
{
    internal class Transport
    {
        public EngineTypeOfTransport EngineType { get; set; }

        public Transport(EngineTypeOfTransport engineType) 
        {
            this.EngineType = engineType;
        }

        public virtual EngineTypeOfTransport GetEngineType()
        {
            return EngineTypeOfTransport.Unknown;
        }

    }
}
