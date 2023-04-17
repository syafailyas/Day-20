using System.IO;

class Program {
    static void Main() {
        string path = "bootcamplargefile.txt";

        using (FileStream fs = new FileStream(path, FileMode.Open))
        using (BufferedStream bufferedStream = new BufferedStream(fs)) {
            byte[] buffer = new byte[1024];
            int bytesRead;
            while ((bytesRead = bufferedStream.Read(buffer, 0, buffer.Length)) > 0) {
                // process the buffer
            }
        }
    }
}
