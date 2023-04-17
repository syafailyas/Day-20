using System;
using System.IO;

class Program {
    static void Main() {
        string path = @"..\data.bin";

        // Write some binary data to the file
        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create))) {
            int x = 100;
            int y = 200;
            bool b = true;
            double d = 3.14;

            writer.Write(x);
            writer.Write(y);
            writer.Write(b);
            writer.Write(d);
        }

        // Read the binary data from the file
        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open))) {
            int x = reader.ReadInt32();
            int y = reader.ReadInt32();
            bool b = reader.ReadBoolean();
            double d = reader.ReadDouble();

            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("d = {0}", d);
        }
    }
}
