using Microsoft.Data.Sqlite;

namespace ResourceStringsTranslate
{
    public class TableForTranslations
    {
        private const string TableName = "Translation";
        private const string ColumnKeyName = "Key";

        private readonly SqliteConnection _sqLite;

        public TableForTranslations()
        {
            _sqLite = new SqliteConnection("Data Source=:memory:");
            _sqLite.Open();
            Clear();
        }

        public void Clear()
        {
            using (var command = _sqLite.CreateCommand())
            {
                command.CommandText = @$"
DROP TABLE IF EXISTS `{TableName}`;

CREATE TABLE `{TableName}` (
    `{ColumnKeyName}` TEXT PRIMARY KEY    
); 
";
                command.ExecuteNonQuery();
            }
        }

        public void AddLanguage(string language)
        {
            using (var command = _sqLite.CreateCommand())
            {
                command.CommandText = @$"
ALTER TABLE `{TableName}` 
ADD COLUMN `{language}` TEXT;
";
                command.ExecuteNonQuery();
            }
        }

        public void InsertTranslate(string language, string key, string text)
        {
            using (var command = _sqLite.CreateCommand())
            {
                command.Parameters.Add(new SqliteParameter("key", key));
                command.Parameters.Add(new SqliteParameter("text", text));

                command.CommandText = @$"
SELECT COUNT(Key) 
  FROM `{TableName}` 
 WHERE `{ColumnKeyName}` = @key;
";
                var exists = (long) command.ExecuteScalar() > 0;

                if (!exists)
                    command.CommandText = @$"
INSERT INTO `{TableName}` (
  `{ColumnKeyName}`,
  `{language}`
) VALUES (
  @key,
  @text
);";
                else
                    command.CommandText = @$"
UPDATE `{TableName}` 
   SET `{language}` = @text
 WHERE `{ColumnKeyName}` = @key;";

                command.ExecuteNonQuery();
            }
        }
    }
}