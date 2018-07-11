using Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IDailyNotesDAL
    {
        IList<DailyNote> GetAllDailyNotes();

        bool AddDailyNote();

        DailyNote GetDailyNoteById(int Id);

        bool UpdateDailyNote(DailyNote dn);

    }
}