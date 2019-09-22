﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using EZStatements.POCO.Statements;

namespace EZStatements
{
    static class FileOperations
    {
        // TODO: Set a filename
        private static String FILENAME = "C:\\Users\\Nik\\Source\\Repos\\EZStatements\\EZStatements\\Resources\\data.dat";

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

    }
}
