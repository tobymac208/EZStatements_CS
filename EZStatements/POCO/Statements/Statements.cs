using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EZStatements.POCO.Statements
{
    [Serializable()]
    public class Statements : ISerializable
    {
        private List<Statement> list_of_statements;

        public Statements()
        {
            list_of_statements = new List<Statement>();
        }

        public List<Statement> List_Of_Statements
        {
            get { return list_of_statements; }
            set { list_of_statements = value; }
        }

        /// <summary>
        /// Adds a statement to the list.
        /// Precondition: Pass in a valid Statement. No copied titles.
        /// Postcondition: Successfully add a Statement to the list.
        /// </summary>
        /// <param name="value"></param>
        public Boolean AddStatement(Statement value)
        {
            foreach (Statement current_statement in list_of_statements)
            {
                if (current_statement.Equals(value))
                {
                    Console.WriteLine("Copy attempted. Name: " + current_statement.Date);
                    return false; // leave method
                }
            }

            // Statement successfully added
            list_of_statements.Add(value);
            return true;
        } // end of AddStatement()

        public Boolean RemoveStatement(Statement value)
        {
            for (int i = 0, length = list_of_statements.Count; i < length; i++)
            {
                if (list_of_statements[i].Equals(value))
                {
                    // Remove the item by the index
                    list_of_statements.RemoveAt(i);

                    // Succesfully removed the item.
                    return true;
                }
            }

            // Didn't successfully remove the item
            return false;
        } // end of RemoveStatement()

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("List of Statements", List_Of_Statements);
        }

        public Statements(SerializationInfo info, StreamingContext context)
        {
            List_Of_Statements = (List<Statement>)info.GetValue("List of Statements", typeof(List<Statement>));
        }

    } // end of Statements class
}
