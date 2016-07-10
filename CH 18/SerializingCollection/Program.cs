using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializingCollection
{
    [Serializable]
    class NameCard
    {
        public NameCard(string Name, string Phone, int Age)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
        }

        public string Name;
        public string Phone;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            List<NameCard> list = new List<NameCard>();
            list.Add(new NameCard("윤아", "010-111-2222", 25));
            list.Add(new NameCard("서현", "010-333-4444", 24));
            list.Add(new NameCard("태연", "010-555-6666", 26));

            serializer.Serialize(ws, list);
            ws.Close();

            Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<NameCard> list2;
            list2 = (List < NameCard >) deserializer.Deserialize(rs);
            rs.Close();

            foreach (NameCard nc in list2)
            {
                Console.WriteLine("Name: {0}, Phone: {1}, Age: {2}", nc.Name, nc.Phone, nc.Age);
            }
        }
    }
}
