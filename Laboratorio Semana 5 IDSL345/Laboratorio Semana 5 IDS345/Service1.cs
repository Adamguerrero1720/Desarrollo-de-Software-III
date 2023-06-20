using System;
using System.IO;
using System.ServiceProcess;
using System.Timers;
using log4net;

namespace Laboratorio_Semana_5_IDS345
{
    public partial class Service1 : ServiceBase
    {
        private FileSystemWatcher fileWatcher;
        private Timer recurringTimer;
        private readonly ILog logger;

        private string folderPath; // Parámetro: Ruta de la carpeta a escuchar
        private int recurringInterval; // Parámetro: Intervalo de tiempo para el evento recurrente (en milisegundos)

        public Service1()
        {
            InitializeComponent();
            logger = LogManager.GetLogger(typeof(Service1));
            log4net.Config.XmlConfigurator.Configure(new FileInfo("log4net.config"));

        }

        protected override void OnStart(string[] args)
        {
            folderPath = GetConfigurationValue("\"C:\\Users\\Adamg\\Desktop\\Servicio\""); // Obtener el valor de configuración para la ruta de la carpeta
            recurringInterval = int.Parse(GetConfigurationValue("RecurringInterval")); // Obtener el valor de configuración para el intervalo recurrente

            StartFileWatcher();
            StartRecurringEvent();

            logger.Info("File Integration Service started successfully.");
        }

        protected override void OnStop()
        {
            StopFileWatcher();
            StopRecurringEvent();

            logger.Info("File Integration Service stopped.");
        }

        private void StartFileWatcher()
        {
            fileWatcher = new FileSystemWatcher();
            fileWatcher.Path = folderPath;
            fileWatcher.IncludeSubdirectories = false;
            fileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
            fileWatcher.Filter = "*.*";

            fileWatcher.Created += FileCreatedHandler;
            fileWatcher.Changed += FileChangedHandler;
            fileWatcher.Deleted += FileDeletedHandler;

            fileWatcher.EnableRaisingEvents = true;
        }

        private void StopFileWatcher()
        {
            fileWatcher.EnableRaisingEvents = false;
            fileWatcher.Created -= FileCreatedHandler;
            fileWatcher.Changed -= FileChangedHandler;
            fileWatcher.Deleted -= FileDeletedHandler;
            fileWatcher.Dispose();
        }

        private void StartRecurringEvent()
        {
            recurringTimer = new Timer(recurringInterval);
            recurringTimer.Elapsed += RecurringEventHandler;
            recurringTimer.AutoReset = true;
            recurringTimer.Start();
        }

        private void StopRecurringEvent()
        {
            recurringTimer.Stop();
            recurringTimer.Elapsed -= RecurringEventHandler;
            recurringTimer.Dispose();
        }

        private void FileCreatedHandler(object sender, FileSystemEventArgs e)
        {
            logger.Info($"File created: {e.Name}");
            // Realizar acciones necesarias con el archivo creado
            // Por ejemplo, integrar el archivo en algún sistema o procesar su contenido
        }

        private void FileChangedHandler(object sender, FileSystemEventArgs e)
        {
            logger.Info($"File changed: {e.Name}");
            // Realizar acciones necesarias con el archivo modificado
            // Por ejemplo, actualizar la integración del archivo en algún sistema
        }

        private void FileDeletedHandler(object sender, FileSystemEventArgs e)
        {
            logger.Info($"File deleted: {e.Name}");
            // Realizar acciones necesarias con el archivo eliminado
            // Por ejemplo, eliminar la integración del archivo en algún sistema
        }

        private void RecurringEventHandler(object sender, ElapsedEventArgs e)
        {
            logger.Info("Recurring event triggered.");
            // Realizar acciones necesarias para el evento recurrente
            // Por ejemplo, realizar una tarea programada o integrar archivos en un horario determinado
        }

        private string GetConfigurationValue(string key)
        {
            // Obtener el valor de configuración para la clave proporcionada
            // Puedes implementar la lógica para leer el valor desde un archivo de configuración, registro, base de datos, etc.
            return "TODO: Implement configuration value retrieval logic";
        }
    }
}
