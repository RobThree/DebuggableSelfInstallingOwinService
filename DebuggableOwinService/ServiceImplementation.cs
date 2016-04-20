using $safeprojectname$.Framework;
using Microsoft.Owin.Hosting;
using System;
using System.Configuration;
using System.ServiceProcess;


namespace $safeprojectname$
{
    /// <summary>
    /// The actual implementation of the windows service goes here...
    /// </summary>
    [WindowsService("$safeprojectname$",                                    //TODO: Enter service details here...
        DisplayName = "$safeprojectname$",                                  //TODO: Enter service details here...
        Description = "The description of the $safeprojectname$ service.",  //TODO: Enter service details here...
        EventLogSource = "$safeprojectname$",                               //TODO: Enter service details here...
        StartMode = ServiceStartMode.Automatic)]                            //TODO: Enter service details here...
    public class ServiceImplementation : IWindowsService
    {
        private IDisposable _server;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
        }

        /// <summary>
        /// This method is called when the service gets a request to start.
        /// </summary>
        /// <param name="args">Any command line arguments</param>
        public void OnStart(string[] args)
        {
            //TODO: Make sure you have a "endpoint" appsetting (or use a different means of supplying this value to WebApp.Start()
            //TODO: Also make sure the url is registered (netsh http add urlacl url=http://+:8080/ user=DOMAIN\USER) or you run this as administrator/local system account
            _server = WebApp.Start<WebAppStartup>(ConfigurationManager.AppSettings["endpoint"]);
        }

        /// <summary>
        /// This method is called when the service gets a request to stop.
        /// </summary>
        public void OnStop()
        {
            if (_server != null)
                _server.Dispose();
        }

        /// <summary>
        /// This method is called when a service gets a request to pause,
        /// but not stop completely.
        /// </summary>
        public void OnPause()
        {
        }

        /// <summary>
        /// This method is called when a service gets a request to resume 
        /// after a pause is issued.
        /// </summary>
        public void OnContinue()
        {
        }

        /// <summary>
        /// This method is called when the machine the service is running on
        /// is being shutdown.
        /// </summary>
        public void OnShutdown()
        {
        }

        /// <summary>
        /// This method is called when a custom command is issued to the service.
        /// </summary>
        /// <param name="command">The command identifier to execute.</param >
        public void OnCustomCommand(int command)
        {
        }
    }
}
