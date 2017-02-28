using SQLite;

namespace AlphabetStepByStep.Model.Storage
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}