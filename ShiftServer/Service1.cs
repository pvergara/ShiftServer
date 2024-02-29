using System.ServiceProcess;
using System.Threading;

namespace ShiftServer
{
    public partial class Service1 : ServiceBase
    {
        private readonly ShiftServer _shiftServer;
        public Thread onStartThread;
        public Service1()
        {
            InitializeComponent();
            _shiftServer = new ShiftServer();
        }

        protected override void OnStart(string[] args)
        {
            //Lanzo esto como hiloç            
            onStartThread = new Thread(InitThreadMethod);
            onStartThread.Start();
        }

        public void InitThreadMethod()
        {
            _shiftServer.Init();
        }

        protected override void OnStop()
        {
            if (onStartThread != null && onStartThread.IsAlive)
            {
                onStartThread.Abort();
            }
        }

    }
}
