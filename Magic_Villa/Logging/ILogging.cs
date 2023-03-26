using Microsoft.Extensions.Primitives;

namespace Magic_Villa.Logging
{
    public interface ILogging
    {
        public void Log(string message, string type);
    }
}