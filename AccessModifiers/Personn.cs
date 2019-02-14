using System;

namespace AccessModifiers
{
    public class Personn
    {
          //---------------------
        public int Id { get; set;}
          //---------------------
        private string Name;

        public string NAME
        {
            get {
                return Name;
                 }
            set {
                if (value!=null)
                    Name = value;
                }
        }
        //---------------------
        private DateTime BirthDate;
         public DateTime  GetbirthDate()
        {
                return BirthDate;
        }
        public void SetbirthDate(DateTime birthDate)
        {
               this.BirthDate = birthDate;
        }

        //---------------------
    }

}
