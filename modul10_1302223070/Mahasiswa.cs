namespace modul10_1302223070
{
    public class Mahasiswa
    {
        public string name { get; set; }
        public string NIM { get; set; }
        public List<string> course { get; set; }
        public int year { get; set; }
        public Mahasiswa(string name, string NIM, List<string> course,int year)
        {
            this.name = name;
            this.NIM = NIM;
            this.course = course;
            this.year = year;

        }
    }
}
