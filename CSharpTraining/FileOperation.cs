using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    /// <summary>
    /// This class is used for all type of file operation ex create/update/delete files
    /// </summary>
    internal class FileOperation
    {
        /// <summary>
        /// This function is used for creating new files.
        /// </summary>
        public void CreateNewFile()
        {
            string str = "This is Text File for Important Topics";

            // Create/replace with new blank file without content
           // File.Create("C:\\GitLabTraining\\TestFile.txt");

            // Create/replace new file with content
            File.WriteAllText("C:\\GitLabTraining\\TestFile.txt", str);            
        }

        /// <summary>
        /// This function is used for updating/adding new content to existing file
        /// </summary>
        public void UpdateFile()
        {
            File.AppendAllText("C:\\GitLabTraining\\TestFile.txt", "\nThis is new line to important topics");
        }

        /// <summary>
        /// This function used for deleing a existing file
        /// </summary>
        public void DeleteFile()
        {
            string fileLocation = "C:\\GitLabTraining\\TestFile.txt";
            if (File.Exists(fileLocation))
            {
                File.Delete(fileLocation);
            }
            
        }
    }
}
