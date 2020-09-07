using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow1 = new WorkFlow();
            workFlow1.AddActivity(new VideoEncodeActivity());
            workFlow1.AddActivity(new VideoUploadActivity());

            WorkFlowEngine.Run(workFlow1);
        }
    }
}
