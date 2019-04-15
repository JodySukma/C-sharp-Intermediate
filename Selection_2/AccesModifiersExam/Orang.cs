using System;

namespace Selection_2.AccesModifiersExam
{
    public class Orang
    {
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthday)
        {
            _birthdate = birthday;
        }

        public DateTime GetBirthDate() => _birthdate;
    }
}
