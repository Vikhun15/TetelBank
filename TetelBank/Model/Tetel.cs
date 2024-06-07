namespace TetelBank.Model
{
    public class Tetel
    {
        public string name { get; set; }
        public string fName { get; set; }

        public Tetel(string name)
        {
            this.name = name;
            this.fName = name + ".docx";
        }
    }
}
