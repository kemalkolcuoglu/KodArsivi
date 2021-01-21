### Run Ubuntu on Docker

- `docker run -ti --name ubuntu:latest bash`

### Docker Elasticsearch Up as Daemon

- `docker run -d --name elasticsearch --net ktdevopstraining -p 9200:9200 -p 9300:9300 -e "discovery.type=single-node" elasticsearch:7.7.0`

### Docker Grafana Up as Daemon

- `docker run -d --name=grafana --net ktdevopstraining -p 3000:3000 grafana/grafana:master-ubuntu`

### Docker Kill Container

- `docker kill <hash>`

### Docker Remove Dead Container

- `docker rm <hash>`

### Docker List of Running Containers

- `docker ps`

### Elasticsearch Health Check

- `curl -X GET "localhost:9200/_cluster/health?pretty"`

### Docker Elasticsearch Config Json

``` json
{
    "StreamConfig": {},
    "State": {
        "Running": true,
        "Paused": false,
        "Restarting": false,
        "OOMKilled": false,
        "RemovalInProgress": false,
        "Dead": false,
        "Pid": 23212,
        "ExitCode": 0,
        "Error": "",
        "StartedAt": "2020-12-19T19:43:55.618232679Z",
        "FinishedAt": "0001-01-01T00:00:00Z",
        "Health": null
    },
    "ID": "b8d933e6de5b7a5076a911a2ca2334a9fc69f0325679a5a50416d1d753dfd129",
    "Created": "2020-12-19T19:43:55.171838079Z",
    "Managed": false,
    "Path": "/tini",
    "Args": [
        "--",
        "/usr/local/bin/docker-entrypoint.sh",
        "eswrapper"
    ],
    "Config": {
        "Hostname": "b8d933e6de5b",
        "Domainname": "",
        "User": "",
        "AttachStdin": false,
        "AttachStdout": false,
        "AttachStderr": false,
        "ExposedPorts": {
            "9200/tcp": {},
            "9300/tcp": {}
        },
        "Tty": false,
        "OpenStdin": false,
        "StdinOnce": false,
        "Env": [
            "discovery.type=single-node",
            "PATH=/usr/share/elasticsearch/bin:/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin",
            "ELASTIC_CONTAINER=true"
        ],
        "Cmd": [
            "eswrapper"
        ],
        "Image": "elasticsearch:7.7.0",
        "Volumes": null,
        "WorkingDir": "/usr/share/elasticsearch",
        "Entrypoint": [
            "/tini",
            "--",
            "/usr/local/bin/docker-entrypoint.sh"
        ],
        "OnBuild": null,
        "Labels": {
            "org.label-schema.build-date": "2020-05-12T02:01:37.602180Z",
            "org.label-schema.license": "Elastic-License",
            "org.label-schema.name": "Elasticsearch",
            "org.label-schema.schema-version": "1.0",
            "org.label-schema.url": "https://www.elastic.co/products/elasticsearch",
            "org.label-schema.usage": "https://www.elastic.co/guide/en/elasticsearch/reference/index.html",
            "org.label-schema.vcs-ref": "81a1e9eda8e6183f5237786246f6dced26a10eaf",
            "org.label-schema.vcs-url": "https://github.com/elastic/elasticsearch",
            "org.label-schema.vendor": "Elastic",
            "org.label-schema.version": "7.7.0",
            "org.opencontainers.image.created": "2020-05-12T02:01:37.602180Z",
            "org.opencontainers.image.documentation": "https://www.elastic.co/guide/en/elasticsearch/reference/index.html",
            "org.opencontainers.image.licenses": "Elastic-License",
            "org.opencontainers.image.revision": "81a1e9eda8e6183f5237786246f6dced26a10eaf",
            "org.opencontainers.image.source": "https://github.com/elastic/elasticsearch",
            "org.opencontainers.image.title": "Elasticsearch",
            "org.opencontainers.image.url": "https://www.elastic.co/products/elasticsearch",
            "org.opencontainers.image.vendor": "Elastic",
            "org.opencontainers.image.version": "7.7.0"
        }
    },
    "Image": "sha256:7ec4f35ab452cc25d01d9db6b89cbbd5a7ca37eb1f35017b50377874cd08a83e",
    "NetworkSettings": {
        "Bridge": "",
        "SandboxID": "b7f9d97c457fb33c38e27f7e6477198df1d87ee577721aff25cdd3e1214a0bba",
        "HairpinMode": false,
        "LinkLocalIPv6Address": "",
        "LinkLocalIPv6PrefixLen": 0,
        "Networks": {
            "ktdevopstraining": {
                "IPAMConfig": null,
                "Links": null,
                "Aliases": [
                    "b8d933e6de5b"
                ],
                "NetworkID": "711daf3f11ba9225475e2beef02982916e5b0720236181c8b54d371d1f4cb546",
                "EndpointID": "7f3c996aa82044c6c77c92b83d598436db606a23db85f9fd0ff205dca2f2340d",
                "Gateway": "172.18.0.1",
                "IPAddress": "172.18.0.2",
                "IPPrefixLen": 16,
                "IPv6Gateway": "",
                "GlobalIPv6Address": "",
                "GlobalIPv6PrefixLen": 0,
                "MacAddress": "02:42:ac:12:00:02",
                "DriverOpts": null,
                "IPAMOperational": false
            }
        },
        "Service": null,
        "Ports": {
            "9200/tcp": [
                {
                    "HostIp": "0.0.0.0",
                    "HostPort": "9200"
                }
            ],
            "9300/tcp": [
                {
                    "HostIp": "0.0.0.0",
                    "HostPort": "9300"
                }
            ]
        },
        "SandboxKey": "/var/run/docker/netns/b7f9d97c457f",
        "SecondaryIPAddresses": null,
        "SecondaryIPv6Addresses": null,
        "IsAnonymousEndpoint": false,
        "HasSwarmEndpoint": false
    },
    "LogPath": "/var/lib/docker/containers/b8d933e6de5b7a5076a911a2ca2334a9fc69f0325679a5a50416d1d753dfd129/b8d933e6de5b7a5076a911a2ca2334a9fc69f0325679a5a50416d1d753dfd129-json.log",
    "Name": "/elasticsearch",
    "Driver": "overlay2",
    "OS": "linux",
    "MountLabel": "",
    "ProcessLabel": "",
    "RestartCount": 0,
    "HasBeenStartedBefore": true,
    "HasBeenManuallyStopped": false,
    "MountPoints": {},
    "SecretReferences": null,
    "ConfigReferences": null,
    "AppArmorProfile": "docker-default",
    "HostnamePath": "/var/lib/docker/containers/b8d933e6de5b7a5076a911a2ca2334a9fc69f0325679a5a50416d1d753dfd129/hostname",
    "HostsPath": "/var/lib/docker/containers/b8d933e6de5b7a5076a911a2ca2334a9fc69f0325679a5a50416d1d753dfd129/hosts",
    "ShmPath": "",
    "ResolvConfPath": "/var/lib/docker/containers/b8d933e6de5b7a5076a911a2ca2334a9fc69f0325679a5a50416d1d753dfd129/resolv.conf",
    "SeccompProfile": "",
    "NoNewPrivileges": false,
    "LocalLogCacheMeta": {
        "HaveNotifyEnabled": false
    }
}
```
