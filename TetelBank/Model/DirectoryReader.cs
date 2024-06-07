
namespace TetelBank.Model
{
    public class DirectoryReader
    {
        public List<TemaKor> ReadDirs()
        {
            string[] temakorok = Directory.GetDirectories(System.IO.Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "Tetelek"
                ));

            List<TemaKor> temakor = new List<TemaKor>();

            foreach (string item in temakorok)
            {
                string[] tetelek = Directory.GetFiles(item);
                string dirName = System.IO.Path.GetFileName(item);
                TemaKor tk = new TemaKor(dirName);


                foreach (string tetel in tetelek)
                {
                    string name = System.IO.Path.GetFileNameWithoutExtension(tetel);
                    tk.AddTetel(name);
                }

                temakor.Add(tk);
            }

            return temakor;
        }
    }
}
