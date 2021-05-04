namespace UsingInterFaceTestApp
{
    class ExtendedMonitor // ver1.0
    {
        private ILogger logger;

        public ExtendedMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void PrintLog(string message)
        {
            this.logger.WriteLog(message);
        }
    }
}
