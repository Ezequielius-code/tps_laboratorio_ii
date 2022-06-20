using System;
using System.IO;
using ClassesLibrary.Exceptions;
using SpreadsheetLight;

namespace ClassesLibrary
{
    public static class UsersManager
    { 
        static string directory;
        
        static UsersManager()
        {
            directory = $"{Environment.CurrentDirectory}";
        }
        
        public static bool CheckUser(string username, string password)
        {
            bool userChecked = false;

            if (CheckUserFromData(username, password, GetFilePath(".xlsx")))
            {
                userChecked = true;
            }
            else
            {
                throw new InvalidUserException("Invalid user.\nDo you wanna retry?");
            }

            return userChecked;
        }

        private static string GetFilePath(string fileChars)
        {
            string filePath = string.Empty;

            if (Directory.Exists(directory))
            {
                string[] filesInDirectory = Directory.GetFiles(directory);

                foreach (string fileName in filesInDirectory)
                {
                    if (fileName.Contains(fileChars))
                    {
                        filePath = fileName;
                        break;
                    }
                }
            }

            return filePath;
        }

        private static bool CheckUserFromData(string username, string password, string filePath)
        {
            try
            {
                SLDocument sl = new SLDocument(filePath);

                int rowIndex = 2;

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(rowIndex, 1)))
                {
                    if (username.ToLower().Trim() == sl.GetCellValueAsString(rowIndex, 3).ToLower().Trim() &&
                        password.ToLower().Trim() == sl.GetCellValueAsString(rowIndex, 4).ToLower().Trim())
                    {
                        return true;
                    }
                    rowIndex++;
                }
                
                return false;
            }
            catch (Exception ex)
            {
                ExLogger.CatchLog(ex);
                throw new Exception(ex.Message);
            }
        }
    }
}
