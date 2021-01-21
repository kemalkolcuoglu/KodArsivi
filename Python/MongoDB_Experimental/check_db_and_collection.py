import pymongo
from datetime import datetime


client = pymongo.MongoClient("localhost", 27017)
# Check DB Exist
database_list = client.list_database_names()
if 'test_db' in database_list:
    print('Database Exists')

# In else option you can just use insert data method and db and collection will create automaticly

# client.test -> test is database name. 
# If we want to use another database, we must write database name
db = client.test


# Check Collection Exist and If not exist, create collection
collection_data = db.test_data_test.find()
if collection_data.count == 0:
    db.create_collection('test_data_test')
else:
    for data in collection_data:
        print(data)

# Another option, add data to collection and if collection not exist, db will create collection automaticly
new_data = {
    'text': 'Temp Data for create collection',
    '@timestamp': datetime.utcnow().isoformat()
}
result = db.test_data_test.insert_one(new_data)
print('Data Inserted to MongoDB!')
print(result.inserted_id)
