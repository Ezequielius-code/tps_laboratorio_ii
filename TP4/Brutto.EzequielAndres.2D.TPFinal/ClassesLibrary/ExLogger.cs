using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public static class ExLogger
    {
        static string directory;
        static bool isFirstLog = true;

        static ExLogger()
        {
            directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            directory += @"\ExceptionsReports";
        }

        public static void CatchLog(Exception ex)
        {
            string fullReport;
            
            StringBuilder report = new StringBuilder();

            report.AppendLine($"{DateTime.Now} Log:");

            while (ex.InnerException != null)
            {
                report.AppendLine(ex.Message);
                ex = ex.InnerException;
            }

            report.AppendLine(ex.Message + "\n");

            fullReport = report.ToString();
            PrintLog(fullReport);
        }

        private static void PrintLog(string logInfo)
        {
            string fullPath = directory + @"\ReportsInfo.txt";

            try
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                if (isFirstLog)
                {
                    File.WriteAllText(fullPath, logInfo);
                    isFirstLog = false;
                }
                else
                {
                    File.AppendAllText(fullPath, logInfo);                    
                }
            }
            catch (Exception ex)
            {
                CatchLog(ex);
                throw new Exception($"Error en el archivo: {fullPath}");
            }
        }
    }
}
