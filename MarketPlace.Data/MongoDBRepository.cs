using MarketPlace.Core;
using MarketPlace.Core.Data;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace.Data
{
    public partial class MongoDBRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region Fields

        /// <summary>
        /// Gets the collection
        /// </summary>
        protected IMongoCollection<T> _collection;
        public IMongoCollection<T> Collection
        {
            get
            {
                return _collection;
            }
        }

        /// <summary>
        /// Mongo Database
        /// </summary>
        protected IMongoDatabase _database;
        public IMongoDatabase Database
        {
            get
            {
                return _database;
            }
        }

        MongoClient _client;
        const string _connectionString = "mongodb://localhost:27017";
        const string _databaseName = "ServiceMarketPlaceDB";

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public MongoDBRepository()
        {
            _client = new MongoClient(_connectionString);
            _database = _client.GetDatabase(_databaseName);
            _collection = _database.GetCollection<T>(typeof(T).Name);
            //string connectionString = DataSettingsHelper.ConnectionString();

            //if (!string.IsNullOrEmpty(connectionString))
            //{
            //    var client = new MongoClient(connectionString);
            //    var databaseName = new MongoUrl(connectionString).DatabaseName;
            //    _database = client.GetDatabase(databaseName);
            //    _collection = _database.GetCollection<T>(typeof(T).Name);
            //}
        }
        public MongoDBRepository(string connectionString)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(_databaseName);
            _collection = _database.GetCollection<T>(typeof(T).Name);
            //var client = new MongoClient(connectionString);
            //var databaseName = new MongoUrl(connectionString).DatabaseName;
            //_database = client.GetDatabase(databaseName);
            //_collection = _database.GetCollection<T>(typeof(T).Name);
        }

        public MongoDBRepository(IMongoClient client)
        {
            _database = client.GetDatabase(_databaseName);
            _collection = _database.GetCollection<T>(typeof(T).Name);
            //string connectionString = DataSettingsHelper.ConnectionString();
            //var databaseName = new MongoUrl(connectionString).DatabaseName;
            //_database = client.GetDatabase(databaseName);
            //_collection = _database.GetCollection<T>(typeof(T).Name);
        }

        public MongoDBRepository(IMongoClient client, IMongoDatabase mongodatabase)
        {
            //_database = mongodatabase;
            //_collection = _database.GetCollection<T>(typeof(T).Name);
            _database = mongodatabase;
            _collection = _database.GetCollection<T>(typeof(T).Name);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        public virtual T GetById(string id)
        {
            return this._collection.Find(e => e.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual T Insert(T entity)
        {
            this._collection.InsertOne(entity);
            return entity;
        }

        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Insert(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                Insert(entity);
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual T Update(T entity)
        {
            this._collection.ReplaceOne(x => x.Id == entity.Id, entity, new UpdateOptions() { IsUpsert = false });
            return entity;

        }

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Update(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                Update(entity);
            }
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual void Delete(T entity)
        {
            this._collection.FindOneAndDeleteAsync(e => e.Id == entity.Id);
        }

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Delete(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                this._collection.FindOneAndDeleteAsync(e => e.Id == entity.Id);
            }
        }


        #endregion

        #region Properties

        /// <summary>
        /// Gets a table
        /// </summary>
        public virtual IMongoQueryable<T> Table
        {
            get { return this._collection.AsQueryable(); }
        }

        /// <summary>
        /// Get collection by filter definitions
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public virtual IList<T> FindByFilterDefinition(FilterDefinition<T> query)
        {
            return this._collection.Find(query).ToList();
        }

        #endregion
    }
}
