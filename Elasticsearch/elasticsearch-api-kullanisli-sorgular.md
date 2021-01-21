
Cluster Health Check
curl -u 'username:password' -XGET "http://[ip]:9200/_cluster/health?pretty"

ELK Cluster Node Bilgisi
curl -u 'username:password' -XGET "http://[ip]:9200/_nodes?pretty"

Elasticsearch Sürümü
/usr/share/elastic/bin/elastic --version

Kibana Sürümü
/usr/share/kibana/bin/kibana --version

Logstash Sürümünü
/usr/share/logstash/bin/logstash --version