namespace sess12_advanced_csharp_concepts
{
    /// <summary>
    /// Program to demonstrate various disk, directory/folder & file operations
    /// </summary>
    public class FileOperations
    {
        static void Main(string[] args)
        {
            string appFolder = Directory.GetCurrentDirectory();
            string fileFolder = appFolder.Replace("\\bin\\Debug\\net8.0", "\\");
            string fileName = "ADSE2501.txt";
            string filePath = fileFolder + fileName;

            // Display the executing application's current location/path
            Console.WriteLine($"The application was launched from:\n{appFolder}");
            Console.WriteLine($"Where we shall be creating our file:\n{filePath}");

            // Check & display whether the file exists or not
            Console.WriteLine((File.Exists(filePath)? $"The file {fileName} exists.": $"The file {fileName} does not exist"));

            // Check if the text file exist & create it if not
            if (File.Exists(filePath) )
            {
                Console.WriteLine($"The file{fileName} already exists & will not be created!");
            }
            else 
            {
                Console.WriteLine(@"Please wait...\nCreating the file.");
                File.Create(filePath);
            }

            // Display the properties of the created file
            DisplayFileProperties(filePath);

            // Prompt the user for a string to be appended to the text file
            Console.WriteLine($"Please enter the text to be written to the file {fileName}");
            string content2Write = Environment.NewLine + Console.ReadLine();

            // Write the string from the user to the file
            bool success = WriteToFile(filePath, content2Write);

            // Display the contents of the textfile
            DisplayFileContents(filePath);

            // Display the information about disks connected to your computer
            DisplayDriveInfo();
        }

        private static void DisplayFileProperties(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException();
                else
                {
                    long sizeInBytes = new FileInfo(filePath).Length;
                    string dateCreated = File.GetCreationTime(filePath).ToString();
                    string lastAccessed = File.GetLastAccessTime(filePath).ToString();
                    string lastWrite = File.GetLastWriteTime(filePath).ToString();
                    // Display the file properties and contents
                    Console.WriteLine("Properties of the file." +
                        "\n" + new string('-', 55) +
                        $"\nSize: {sizeInBytes} bytes." +
                        $"\nDate Created: {dateCreated}" +
                        $"\nLast Access Date: {lastAccessed}" +
                        $"\nLast Modification Date: {lastWrite}" +
                        "\n" + new string('-', 55));
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file {filePath}\n does not exist." +
                    $"\nPlease create it and then try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The error:\n{ex.Message} occurred!";
            }
            
        }
        private static bool WriteToFile(string filePath, string content2Write)
        {
            bool operationStatus = false;
            try 
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException();
                else
                {
                    File.AppendAllText(filePath, content2Write);
                    operationStatus = true;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file {filePath}\n does not exist." +
                    $"\nPlease create it and then try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The error:\n{ex.Message} occurred!";
            }
            return operationStatus;
        }
        private static void DisplayFileContents(string filePath)
        {
            try
            {
                if(File.Exists(filePath))
                {
                    string fileContents = Environment.NewLine + File.ReadAllText(filePath);
                    Console.WriteLine(fileContents);
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file {filePath}\n does not exist." +
                    $"\nPlease create it and then try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The error:\n{ex.Message} occurred!";
            }
        }
        private static void DisplayDriveInfo()
        {
            // Get info about each fixed diskdrive
            Console.WriteLine("Drive information: ");
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                if (d.DriveType == DriveType.Fixed)
                {
                    Console.WriteLine(new string('-', 55));
                    Console.WriteLine($"Drive Name: {d.Name}" +
                        $"\nDrive Size: {(d.TotalSize / (uint) Math.Pow(1024, 3))} GB." +
                        $"\nFree Space: {(d.TotalFreeSpace / 1024)} KB." +
                        $"\nDrive Type: {d.DriveType}");
                    Console.WriteLine(new string('-', 55));
                }
            }
        }

    }
}
