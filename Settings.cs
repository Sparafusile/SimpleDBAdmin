using System.Xml.Serialization;
using System.Collections.Generic;

namespace SimpleDBAdmin
{
    public class Settings
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public bool SavePublicKeys { get; set; }
        public bool SavePrivateKeys { get; set; }
        public bool SaveDomainSchemas { get; set; }

        public List<AwsCredentials> AwsCredentials { get; set; }
    }

    public class AwsCredentials
    {
        public string Name { get; set; }

        public string Key { get; set; }

        [XmlIgnore]
        public string Secret { get; set; }

        public string EncryptedSecret { get; set; }

        public string ServiceUrl { get; set; }
    }

    public class DomainSchema : SerializableDictionary<string, string[]>
    {
    }

    [XmlRoot( "dictionary" )]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
    {
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml( System.Xml.XmlReader reader )
        {
            var keySerializer = new XmlSerializer( typeof( TKey ) );
            var valueSerializer = new XmlSerializer( typeof( TValue ) );

            var wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if( wasEmpty )
                return;

            while( reader.NodeType != System.Xml.XmlNodeType.EndElement )
            {
                reader.ReadStartElement( "item" );

                reader.ReadStartElement( "key" );
                var key = (TKey)keySerializer.Deserialize( reader );
                reader.ReadEndElement();

                reader.ReadStartElement( "value" );
                var value = (TValue)valueSerializer.Deserialize( reader );
                reader.ReadEndElement();

                this.Add( key, value );

                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }

        public void WriteXml( System.Xml.XmlWriter writer )
        {
            var keySerializer = new XmlSerializer( typeof( TKey ) );
            var valueSerializer = new XmlSerializer( typeof( TValue ) );

            foreach( var key in this.Keys )
            {
                writer.WriteStartElement( "item" );

                writer.WriteStartElement( "key" );
                keySerializer.Serialize( writer, key );
                writer.WriteEndElement();

                writer.WriteStartElement( "value" );
                var value = this[key];
                valueSerializer.Serialize( writer, value );
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
        }
    }
}
