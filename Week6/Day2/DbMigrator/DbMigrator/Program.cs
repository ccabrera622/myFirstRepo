using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DbMigrator
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }

    //File Logger
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }
        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }
        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }

    //Logger Interface
    public interface ILogger
    {
        void LogError(string message);  // method
        void LogInfo(string message);  // method
    }

    //Migrator
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migrating started at {DateTime.Now}");
            _logger.LogError("Error occured process terminating.");
            _logger.LogInfo($"Migrating ended at {DateTime.Now}");
        }
    }

    //Main
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("../../log.txt"));
            dbMigrator.Migrate();
        }
    }
}
