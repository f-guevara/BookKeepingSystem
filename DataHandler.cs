using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                   // For StreamReader, StreamWriter, File.Exists
using System.Xml.Serialization;

namespace BookKeepingSystem
 {
        public class DataHandler
        {
            private const string FilePath = "books.xml";

            public List<Book> LoadBooks()
            {
                if (File.Exists(FilePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        return (List<Book>)serializer.Deserialize(reader);
                    }
                }
                return new List<Book>();
            }

            public void SaveBooks(List<Book> books)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    serializer.Serialize(writer, books);
                }
            }
        }
 }



