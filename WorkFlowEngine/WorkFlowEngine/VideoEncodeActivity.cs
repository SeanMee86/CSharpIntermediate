using System;

namespace WorkFlowEngine
{
    public class VideoEncodeActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing Video Encode");
        }
    }
}
