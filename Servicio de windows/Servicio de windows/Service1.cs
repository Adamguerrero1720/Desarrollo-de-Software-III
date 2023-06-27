using System;
using System.IO;
using System.ServiceProcess;
using log4net;

namespace Servicio_de_windows
{
    public partial class Service1 : ServiceBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Service1));


        private string folderPath = "\"C:\\Users\\Adamg\\Desktop\\System\""; // Carpeta a monitorear (parametrizable)
        private int timerInterval = 5000; // Intervalo de tiempo en milisegundos (parametrizable)
        private System.Timers.Timer timer;
        private FileSystemWatcher watcher;

        public Service1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        protected override void OnStart(string[] args)
        {
            // Configurar el temporizador
            timer = new System.Timers.Timer();
            timer.Interval = timerInterval;
            timer.Elapsed += OnTimerElapsed;

            // Comenzar a ejecutar el temporizador
            timer.Start();

            // Configurar el FileSystemWatcher
            watcher = new FileSystemWatcher();
            watcher.Path = folderPath;
            watcher.IncludeSubdirectories = true;

            // Suscribirse a los eventos
            watcher.Created += OnFileCreated;
            watcher.Renamed += OnFileRenamed;
            watcher.Deleted += OnFileDeleted;
            watcher.Error += OnError;

            // Comenzar a monitorear
            watcher.EnableRaisingEvents = true;

            log.Info("File integration service started.");
        }

        protected override void OnStop()
        {
            // Detener el temporizador
            timer.Stop();
            timer.Dispose();

            // Detener el FileSystemWatcher
            watcher.EnableRaisingEvents = false;
            watcher.Dispose();

            log.Info("File integration service stopped.");
        }

        private void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Acción a realizar en cada intervalo de tiempo
            log.Info("Timer elapsed. Performing action...");
        }

        private void OnFileCreated(object sender, FileSystemEventArgs e)
        {
            // Acción a realizar cuando se crea un archivo
            log.Info($"File created: {e.FullPath}");
            log.GetHashCode();
        }

        private void OnFileRenamed(object sender, RenamedEventArgs e)
        {
            // Acción a realizar cuando se cambia el nombre de un archivo
            log.Info($"File renamed: {e.OldFullPath} -> {e.FullPath}");
        }

        private void OnFileDeleted(object sender, FileSystemEventArgs e)
        {
            // Acción a realizar cuando se elimina un archivo
            log.Info($"File deleted: {e.FullPath}");
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            // Acción a realizar cuando ocurre un error en el watcher
            log.Error($"Watcher error: {e.GetException()}");
        }
    }
}
