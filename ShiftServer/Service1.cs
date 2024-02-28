using System.ServiceProcess;

namespace ShiftServer
{
    public partial class Service1 : ServiceBase
    {
        private readonly ShiftServer _shiftServer;
        public Service1()
        {
            InitializeComponent();
            _shiftServer = new ShiftServer();
        }

        protected override void OnStart(string[] args)
        {
            _shiftServer.Init();
        }

        protected override void OnStop()
        {
        }

    }
}
