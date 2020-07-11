import pymongo
from pprint import pprint
from datetime import datetime


client = pymongo.MongoClient("localhost", 27017)
# client.test -> test is database name. 
# If we want to use another database, we must write database name
db = client.test

print('----DB Name----')
print(db.name)
print('----DB Collections----')
print(db.sample_datas)

datas = [
    {
        'author': 'kemalkolcuoglu',
        'text': 'Very first data for experimental works on MongoDB',
        '@timestamp': datetime.utcnow().isoformat()
    },
    {
        'author': 'kemalkolcuoglu',
        'text': 'Second data for experimental works on MongoDB',
        '@timestamp': datetime.utcnow().isoformat()
    },
]

collection = db.sample_datas
result = collection.insert_many(datas)
print('Data Inserted to MongoDB!')
print(result.inserted_ids)

print('----Saved Objects----')
for data in db.sample_datas.find():
    pprint(data)
