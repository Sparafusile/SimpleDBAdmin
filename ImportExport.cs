using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace SimpleDBAdmin
{
    public static class ImportExportHelpers
    {
        private const string UnitSeparator = @"\x1F";
        private const string RecordSeparator = @"\x1E";
        private static readonly System.Text.Encoding FileEncoding = System.Text.Encoding.UTF8;

        public static void WriteDWord( this FileStream File, int d )
        {
            File.WriteByte( (byte)( ( d & 0x000000FF ) >>  0 ) );
            File.WriteByte( (byte)( ( d & 0x0000FF00 ) >>  8 ) );
            File.WriteByte( (byte)( ( d & 0x00FF0000 ) >> 16 ) );
            File.WriteByte( (byte)( ( d & 0x7F000000 ) >> 24 ) );
        }

        public static int ReadDWord( this FileStream File )
        {
            var bytes = new byte[4];
            File.Read( bytes, 0, 4 );
            return
                bytes[0] << 0 |
                bytes[1] << 8 |
                bytes[2] << 16 |
                bytes[3] << 24;
        }

        public static void WriteSimpleDBItem( this FileStream File, SimpleDBItem Item )
        {
            // Write the length of the name to the file
            File.WriteDWord( Item.Name.Length );

            // Write the name of the Item to the file
            File.Write( FileEncoding.GetBytes( Item.Name ), 0, Item.Name.Length );

            var str = string.Join( RecordSeparator, from kvp in Item select kvp.Key + UnitSeparator + kvp.Value );

            // Write the length of the character string to the file
            File.WriteDWord( str.Length );

            // Write the string representation of the Item to the file
            File.Write( FileEncoding.GetBytes( str ), 0, str.Length );
        }

        public static IEnumerable<SimpleDBItem> ReadSimpleDBItems( this FileStream File )
        {
            while( File.CanRead && File.Position < File.Length )
            {
                var Item = new SimpleDBItem();

                // Read the name from the file
                var nameLength = File.ReadDWord();
                var name = new byte[nameLength];
                File.Read( name, 0, nameLength );
                Item.Name = FileEncoding.GetString( name );

                // Read the Key/Value pairs from the file
                var dataLength = File.ReadDWord();
                var data = new byte[dataLength];
                File.Read( data, 0, dataLength );
                var str = FileEncoding.GetString( data );

                // Convert the file data into Key/Value pairs
                Item.AddRange
                (
                    from kvp in str.Split( new[] { RecordSeparator }, StringSplitOptions.None )
                    let parts = kvp.Split( new[] { UnitSeparator }, StringSplitOptions.None )
                    where parts.Length == 2
                    select new KeyValuePair<string, string>
                    {
                        Key = parts[0], Value = parts[1]
                    }
                );

                // Return the result
                yield return Item;
            }
        }

        /// <summary>
        /// Combines a list of column data into a single line using the given delimiter.
        /// </summary>
        /// <param name="File">The StreamWriter to write the line to.</param>
        /// <param name="columns">The data to join into the single line.</param>
        /// <param name="delimiter">The string used to seperate the columns.</param>
        /// <param name="textQualifier">The text qualifier to surround the column data with.</param>
        /// <param name="escapeCharacter">The string used to escape a text qualifier within the column data.</param>
        /// <returns>A string representation of the joined column data.</returns>
        public static void WriteDeliminatedString( this StreamWriter File, IEnumerable<string> columns, string delimiter = ",", string textQualifier = "\"", string escapeCharacter = "\\" )
        {
            if( columns == null ) return;

            File.WriteLine( string.Join
            (
                delimiter,
                from c in columns
                let s = c ?? string.Empty
                select textQualifier +
                    ( !string.IsNullOrEmpty( escapeCharacter ) && !string.IsNullOrEmpty( textQualifier )
                    ? s.Replace( textQualifier, escapeCharacter + textQualifier )
                    : s ) + textQualifier
            ) );
        }
    }
}
