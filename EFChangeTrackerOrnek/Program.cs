using EFChangeTrackerOrnek.Data;

namespace EFChangeTrackerOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChangeTrackerContext _db = new ChangeTrackerContext();


            Ogrenci o1 = new Ogrenci();
            o1.FirstName = "Ali";
            o1.Surname = "1";
            o1.BirthDate = DateTime.Now;
            _db.Ogrenciler.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.FirstName = "Veli";
            o2.Surname = "2";
            o2.BirthDate = DateTime.Now;
            _db.Ogrenciler.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.FirstName = "Ayşe";
            o3.Surname = "3";
            o3.BirthDate = DateTime.Now;
            _db.Ogrenciler.Add(o3);

            Ogrenci o4 = new Ogrenci();
            o4.FirstName = "Fatma";
            o4.Surname = "4";
            o4.BirthDate = DateTime.Now;
            _db.Ogrenciler.Add(o4);

            Ogrenci o5 = new Ogrenci();
            o5.FirstName = "Can";
            o5.Surname = "5";
            o5.BirthDate = DateTime.Now;
            _db.Ogrenciler.Add(o5);

            _db.SaveChanges();

            Ogrenci o6 = new Ogrenci();
            o6.FirstName = "Orhan";
            o6.Surname = "6";
            o6.BirthDate = DateTime.Now;
            _db.Ogrenciler.Add(o6);

            Console.WriteLine(o6.FirstName + " " + o6.Surname + " " + _db.Entry(o6).State);
            _db.SaveChanges();


            _db.Ogrenciler.Remove(o6);

            

            foreach (var item in _db.ChangeTracker.Entries())
            {
                Ogrenci girdiOgrenci = (Ogrenci)item.Entity;
                Console.WriteLine($"{girdiOgrenci.FirstName} {girdiOgrenci.Surname} {item.State}");
            }

            


            Console.ReadKey();
        }
    }
}