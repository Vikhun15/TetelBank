namespace TetelBank.Model
{
    public class TemaKor
    {
        public string name { get; set; }
        public List<Tetel> tetelek = new List<Tetel>();

        public TemaKor(string name) 
        {
            this.name = name;
        }

        public void AddTetel(string name)
        {
            tetelek.Add(new Tetel(name));
        }

        public string GetPath(int id)
        {
            return $"wwwroot/Tetelek/{name}/{tetelek[id].fName}";
        }
        public string GetShortPath(int id)
        {
            return $"Tetelek/{name}/{tetelek[id].fName}";
        }
    }
}
