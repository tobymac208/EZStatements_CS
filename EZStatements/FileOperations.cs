using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using EZStatements.POCO.Statements;
using EZStatements.POCO.PayPeriod;

namespace EZStatements
{
    static class FileOperations
    {
        // TODO: Set a filename
        private static string FILENAME = "C:\\Users\\ferna\\Source\\Repos\\EZStatements_CS\\EZStatements\\Resources\\data.dat";

        public static void SerializeFile(StatementTracker value)
        {
            // Open the file
            Stream stream = File.Open(FILENAME, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            // Serialize the data to the file
            formatter.Serialize(stream, value);
            // Close the stream
            stream.Close();
        }

        public static StatementTracker DeserializeFile()
        {
            StatementTracker tracker = null;

            // Open the file
            Stream stream = File.Open(FILENAME, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            // Deserialize the data from the file
            tracker = (StatementTracker)formatter.Deserialize(stream);
            // Close the file
            stream.Close();

            // Return the object to the user.
            return tracker;
        }

        /// <summary>
        ///  Write data to a file as text.
        /// </summary>
        public static void WriteRawData(StatementTracker value)
        {
            // TODO: Set a filename
            string TXT_FILENAME = "C:\\Users\\ferna\\Source\\Repos\\EZStatements_CS\\EZStatements\\Resources\\data.txt";

            using (StreamWriter sw = new StreamWriter(TXT_FILENAME))
            {
                sw.WriteLine(value.StatementDataToString());
            }
        }
    }
}
