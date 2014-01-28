using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

using Amazon;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;

namespace SimpleDBAdmin
{
    public class DomainMetaData
    {
        public int AttributeNameCount { get; set; }
        public long AttributeNamesSizeBytes { get; set; }
        public int AttributeValueCount { get; set; }
        public long AttributeValuesSizeBytes { get; set; }
        public int ItemCount { get; set; }
        public long ItemNamesSizeBytes { get; set; }
    }

    public class SimpleDBItem : List<KeyValuePair<string, string>>
    {
        public string Name { get; set; }

        public SimpleDBItem( IEnumerable<KeyValuePair<string, string>> Attributes ) : base( Attributes )
        {
        }

        public IEnumerable<string> this[string key]
        {
            get
            {
                return
                    from m in this
                    where m.Key.Equals( key, StringComparison.OrdinalIgnoreCase )
                    orderby m.Key, m.Value
                    select m.Value;
            }
        }
    }

    public class SimpleDBContext
    {
        private const int MaxRetryCount = 3;

        private IAmazonSimpleDB Client { get; set; }

        /// <summary>
        /// A list of all the domains currently present in the SimpleDB service.
        /// </summary>
        public List<string> Domains { get; private set; }

        /// <summary>
        /// Creates the SimpleDB context on which queries, inserts, updates, and
        /// deletes can be made.
        /// </summary>
        /// <param name="awsAccessKey">Your public AWS key.</param>
        /// <param name="awsSecretAccessKey">Your secret AWS key.</param>
        /// <param name="serviceUrl">http://docs.aws.amazon.com/general/latest/gr/rande.html#sdb_region</param>
        public SimpleDBContext( string awsAccessKey, string awsSecretAccessKey, string serviceUrl )
        {
            // Create the SimpleDB client
            this.Client = AWSClientFactory.CreateAmazonSimpleDBClient
            (
                awsAccessKey, awsSecretAccessKey,
                new Amazon.SimpleDB.AmazonSimpleDBConfig
                {
                    ServiceURL = serviceUrl
                }
            );

            // Get the current domain names
            var r = this.Client.ListDomains();
            this.Domains = r.DomainNames;
            this.Domains.Sort();
        }

        public bool DomainExists( string name )
        {
            return this.Domains.Any( n => n.Equals( name, System.StringComparison.OrdinalIgnoreCase ) );
        }

        public void CreateDomain( string name )
        {
            if( this.DomainExists( name ) ) return;
            this.Client.CreateDomain( new CreateDomainRequest { DomainName = name } );
            this.Domains.Add( name );
            this.Domains.Sort();
        }

        public DomainMetaData GetDomainDetails( string name )
        {
            var r = this.Client.DomainMetadata( new DomainMetadataRequest { DomainName = name } );

            return new DomainMetaData
            {
                AttributeNameCount = r.AttributeNameCount,
                AttributeNamesSizeBytes = r.AttributeNamesSizeBytes,
                AttributeValueCount = r.AttributeValueCount,
                AttributeValuesSizeBytes = r.AttributeValuesSizeBytes,
                ItemCount = r.ItemCount,
                ItemNamesSizeBytes = r.ItemNamesSizeBytes,
            };
        }

        public void DeleteDomain( string name )
        {
            if( !this.DomainExists( name ) ) return;
            this.Client.DeleteDomain( new DeleteDomainRequest { DomainName = name } );
            this.Domains.Remove( name );
        }

        public void Insert( string Domain, List<KeyValuePair<string, string>> Attributes )
        {
            this.Client.PutAttributes
            (
                new PutAttributesRequest
                {
                    DomainName = Domain,
                    ItemName = Guid.NewGuid().ToString(),
                    Attributes =
                    (
                        from a in Attributes
                        select new ReplaceableAttribute
                        {
                            Name = a.Key, Value = a.Value
                        }
                    )
                    .ToList()
                }
            );
        }

        public void Update( string Domain, string Item, List<KeyValuePair<string, string>> Attributes )
        {
            this.Client.PutAttributes
            (
                new PutAttributesRequest
                {
                    DomainName = Domain,
                    ItemName = Item,
                    Attributes =
                    (
                        from a in Attributes
                        select new ReplaceableAttribute
                        {
                            Name = a.Key,
                            Value = a.Value,
                            Replace = true
                        }
                    )
                    .ToList()
                }
            );
        }

        public void Delete( string Domain, string Item )
        {
            this.Client.DeleteAttributes( new DeleteAttributesRequest
            {
                ItemName = Item,
                DomainName = Domain
            } );
        }

        public List<SimpleDBItem> Select( string query )
        {
            string nextToken = null;
            var random = new Random();
            var items = new List<Item>();

            do
            {
                bool retry;
                var retryCount = 0;

                do
                {
                    var r = this.Client.Select( new SelectRequest
                    {
                        SelectExpression = query,
                        NextToken = nextToken
                    } );

                    switch( r.HttpStatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                            items.AddRange( r.Items );
                            nextToken = r.NextToken;
                            retry = false;
                            break;

                        case System.Net.HttpStatusCode.ServiceUnavailable:
                        case System.Net.HttpStatusCode.InternalServerError:
                            retry = true;
                            retryCount++;
                            Thread.Sleep( random.Next( 0, (int)Math.Pow( 4, retryCount ) * 100 ) );
                            break;

                        default:
                            // Process 4xx (Client) error
                            retry = false;
                            break;
                    }
                }
                while( retry && retryCount < MaxRetryCount );
            }
            while( !string.IsNullOrEmpty( nextToken ) );

            // Convert the items to Key/Value pairs.
            // There will be multiple entries with the
            // same key so a dictionary wont work.
            return
            (
                from i in items
                select new SimpleDBItem
                (
                    from a in i.Attributes
                    select new KeyValuePair<string, string>
                    (
                        a.Name, a.Value
                    )
                )
                {
                    Name = i.Name
                }
            )
            .ToList();
        }
    }
}
