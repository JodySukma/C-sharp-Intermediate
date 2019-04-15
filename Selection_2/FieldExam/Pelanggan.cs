using System.Collections.Generic;

namespace Selection_2.FieldExam
{
    public class Pelanggan
    {
        public int Id;
        public string Nama;
        public readonly List<Mesan> Orders = new List<Mesan>();

        public Pelanggan(int id)
        {
            this.Id = id;
        }

        public Pelanggan(int id, string nama)
            : this(id)
        {
            this.Nama = nama;
        }

        public void Promote()
        {
        }
    }
}
