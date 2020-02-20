using System.Data;
using System.Timers;
using Microsoft.Data.Sqlite;

namespace ResourceStringsTranslate
{
    public class TableForTranslations
    {
        private const string TableName = "Translation";
        public const string ColumnKeyName = "KEY";

        private readonly SqliteConnection _sqLite;

        private Timer _resetDataTablesTimer;

        private DataTable _translations;

        public TableForTranslations()
        {
            _sqLite = new SqliteConnection("Data Source=:memory:");
            _sqLite.Open();
            Clear();
        }

        public DataTable Translations
        {
            get
            {
                if (_translations != null) return _translations;

                _translations = new DataTable();

                using var command = _sqLite.CreateCommand();
                command.CommandText = @$"
SELECT * FROM `{TableName}`;
";

                using var reader = command.ExecuteReader();
                object[] values = null;
                while (reader.Read())
                {
                    if (values == null)
                    {
                        for (var i = 0; i < reader.FieldCount; i++) _translations.Columns.Add(reader.GetName(i));
                        values = new object[reader.FieldCount];
                    }

                    reader.GetValues(values);
                    _translations.Rows.Add(values);
                }

                return _translations;
            }
        }

        private void ResetDataTables()
        {
            if (_resetDataTablesTimer == null)
            {
                _resetDataTablesTimer = new Timer {Interval = 500};
                _resetDataTablesTimer.Elapsed += (sender, args) =>
                {
                    _resetDataTablesTimer.Enabled = false;
                    _translations = null;
                };
            }

            _resetDataTablesTimer.Enabled = false;
            _resetDataTablesTimer.Enabled = true;
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

            ResetDataTables();
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

            ResetDataTables();
        }

        public void InsertTranslate(string language, string key, string text)
        {
            using (var command = _sqLite.CreateCommand())
            {
                command.Parameters.Add(new SqliteParameter("key", key));
                command.Parameters.Add(new SqliteParameter("text", text));

                command.CommandText = @$"
SELECT COUNT(*) 
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

            ResetDataTables();
        }
    }
}