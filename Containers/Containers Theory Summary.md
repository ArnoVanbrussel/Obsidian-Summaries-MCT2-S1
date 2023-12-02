# 1 Container Technology
## What & Why
### Docker
- Solomon Hykes
- Written in Go
### Namespaces + Cgroups = LXC
- Namespaces:
	- A feature of the Linux kernel that allows for the isolation of resources at the process level
	- They provide separate and isolated environments for various system resources
	- They allow different containers to have their own isolated view of the system, as if they were running on separate physical machines
- Cgroups:
	- Control Groups
	- A feature of the Linux kernel that allows you to manage and limit system resource usage for a group of processes
	- They enable you to control and allocate resources like CPU, memory, I/O, and more to individual or groups of processes
- LXC:
	- Linux Containers
	- A user-space interface for managing Linux containers that utilizes namespaces and Cgroups to create isolated environments
	- Allows you to create and manage lightweight, isolated and portable containers that run their own Linux user spaces
		- These containers can have their own file systems, networking and process trees while sharing the host's kernel
	- LXC provides a CLI and APIs for creating and managing containers
### Why Docker?
- "Docker wants to make it possible to install and run software on any system"
- "If it runs on my computer, it will run on your computer"
- More reasons:
	- Modern software dev techniques (e.g.: microservices)
	- DevOps
	- Resource Usage
### What is Docker?
- Docker =/= Container
- Docker = Ecosystem for creating & running containers
	- Docker CLI
	- Docker Engine
	- Docker Image
	- Docker Container
	- Docker Hub
	- Docker Compose
	- Docker Swarm
	- ...
## Some Background
### Microservices
- Software development technique
- Variant of the Service-Oriented Architecture (SOA)
- Microservices structure an application as a collection of loosely coupled services
- Services in a microservices architecture are fine-grained
- The protocols used in microservices are lightweight
- Improves modularity
	- Makes the application easier to understand, develop and test
- Enhances resilience to architecture erosion
- Development is parallelized
	- this enables small autonomous teams to work independently on services
- Each services can be developed, deployed and scaled independently
- Allows evolution through continuous refactoring
- Enable continuous delivery and deployment
![[Pasted image 20231031123801.png]]
-  Microservices does not automatically mean containerization (although it is a logical step)
- Containerization does not necessarily mean microservices (although it is a logical step)
### Moore's law
- "Moore's law is the observation that the number of transistors in an integrated circuit doubles about every 2 years)"
- "A transistor in a CPU acts like a tiny on/off switch that controls the flow of electrical signals, allowing the CPU to process and perform calculations"
- Basically: hardware is getting more powerful over time
### Hardware
#### Datacenter
- 1 powerful processor vs. 2 less powerful processors
	- Usually less power usage
- Data center is divided in racks and units (U's)
- Cost (strongly simplified):
	- Number of Units
	- Power Usage
- Data center:
	- Building suited for IT equipment
	- Power sources, back-up power (emergency generator)
	- Connected to several ISP's
	- HVAC systems
	- Security measurements (physical)
	- Disaster protection
#### Virtualization
- "Hardware virtualization is a technology that enables multiple virtual machines to run simultaneously on a single physical computer, providing better resource utilization, improved security and flexibility for running different operating systems and applications"

Classic server installation:                                Virtualized server installation:
![[Pasted image 20231031124624.png]]![[Pasted image 20231031124630.png]]
##### Virtualization vs. Containerization
![[Pasted image 20231031124816.png]]![[Pasted image 20231031124823.png]]
## Shared kernel? Image? Container?
### Shared Kernel?
- Kernel:
	- piece of software that offers a basic functionality to the OS
	- Serves as a bridge between software and hardware
	- System calls = can "ask" the OS to perform tasks or provide access to resources
	- Bridge between user-level apps and underlying kernel features
		- E.g.: 
			- Open, close, read, write files
			- Allocate memory
		- Typical kernel has a few hundred system calls
- Docker shares the host OS kernel
	- Host OS = Windows/MacOS/Linux
	- Shared Linux Kernel (in case of linux based containers)
	- Each host OS has it's own kernel
	- What's the size of a typical kernel
		- few megabytes (1-30)
	- Modern game
		- 50+ GB
- Ubuntu container requires Linux kernel
	- Install Hyper-V / WSL / ...
	- Run Linux Virtual Machine
- Windows Server 2016
	- new feature: Windows Server Container
- Windows 10 / Windows Server 2019
	- new feature: Windows Subsystem for Linux (WSL)
### WSL
- Compatibility layer that enables to run Linux distributions natively
- Allows to run Linux without a VM
- = Linux compatible kernel = translation layer to Windows kernel
### Linux kernel namespaces
- 7 types:
	- Mount
	- UTS
	- IPC
	- Network
	- PID
	- Cgroup
	- User
- For the process it looks like there is a completely isolated set of resources
### Container?
- What is a container
	- One or multiple running processes
	- Resources specifically assigned to it
### Image?
- What is an image?
	- Filesystem snapshot
	- Startup command
	- Layered structure (unique docker feature)
- Instance of image = container
### What is Docker really?
- Current Docker version is using runC (previously LXC)
	- runC :
		- tooling that makes it possible to create and run containers
		- CLI to 'easily' access kernel features such as cgroups and namespacing
		- successor of libcontainer
			- Open-sourced => better community
			- runC implements "Open Container Initiative RUntime Specification"
- Docker is 'nothing more' than an ecosystem about creating & running containers
## Linux
### Operating Systems
- "Manages hardware, software and provides services"
- Core of OS = Kernel
### Unix, Linux & Ubuntu
#### Unix
- Family of OS's
- 1969
#### Linux
- Open-source Unix-like OS's
- Based on ... the Linux kernel
- OS with Linux kernel => distribution (distro)
#### Ubuntu
- Ubuntu = distro based on ... another distro called Debian
- Ubuntu Desktop / Ubuntu Server
- Ubuntu 22.04.2 LTS (Jammy Jellyfish)
	- 22.04 => April 2022
	- .2 => Point release
	- LTS => Long Term Support => 5 year
		- every 2 years
# 2 Docker Usage
## Quick recap: container & image
### Docker registries
- "The registry is a stateless, highly scalable server-side application that stores and lets you distribute Docker images"
	- Docker Hub
	- GCP Container Registry
	- AWS Elastic Container Registry
	- ...
- Private registries needs login credentials to access images
	- docker login OPTIONS SERVER
		- echo $CR_PAT | docker login ghcr.io -u USERNAME --password-stdin
	- Use a "helper tool"
		- gcloud auth configure-docker
	- default to Docker Hub
		- docker push OPTIONS NAME[:TAG]
		- docker pull OPTIONS NAME[:TAG|@DIGEST]
### Docker Hub download rate limit
- Downloads = Pulls
- inidvidual IP address
- annoymous users:
	- 100 pulls/6h
- authenticated users
	- 200 pulls/6h 
### Docker images
- Docker Official Image
	- Quality images maintained by Docker
- Verified Publisher
	- Quality images maintained by third-party
- Sponsored OSS
	- Quality images maintained by sponsored open-source project
- Community
	- Quality?
#### Getting images
- docker pull image_name
- docker pull elasticsearch
	- official image
- docker pull eslih/some_custom_image
	- maintained by user eslih -> repo eslih, image -> some_custom_image
- docker pull python:3.11-alpine
	- image tagging
		- specific version, default: latest
	- important for versioning
#### Running containers
- docker run image_name alternative_command
	- wraps 2 commands in one:
		- docker create
		- docker start
- docker stop (graceful) / docker kill (immediate)
- docker ps (--all)
#### Interacting & logs
- No GUI
	- docker exec -it container_id command
	- docker logs container_id
- Remove unused data
	- docker system prune OPTIONS
		- --all / -a
		- --filter
		- --force / -f
		- --volumes
#### Dockerfile
- Instructions to build an image (in YAML)
##### Creating Dockerfile
- Specify base image
- Copy some files
- Install programs
- Specify startup command
##### Instructions
SOME | DOCKERFILE | INSTRUCTIONS
-- | -- | --
FROM | RUN | COPY
ADD | WORKDIR | ENV
VOLUME | EXPOSE | PORTS
HEALTHCHECK | CMD | ENTRYPOINT 
LABEL | ARG | USER 
ONBUILD | SHELL | ...

##### Layers
- Remember
	- Some instructions = new image layer
	- Focus on RUN, COPY & ADD
	- Layers can be shared
- When building images
	- Cache is used

#### Building Containers
- Dockerfile -> Image = Building containers
- docker build . [--tag name/project:tag]
- Build process
	- Using cache whenever possible
	- Using intermediate containers
	- Order of instructions does matter
- docker commit -c startup_command
	- make an image from existing container
![[Pasted image 20231101170712.png]]
- What is dockerfile called?
	- Dockerfile.dev -> docker build -f Dockerfile.dev
![[Pasted image 20231101170804.png]]

# 3 Docker Common Mistakes
## Optimizing Dockerfile
"To obtain info about the layers comprising an image, you can execute the command 'docker history <image | container id>'. This command reveals the layers involved in the image's construction, with the container ID being the final entry during the build process. Execute this command to determine the total number of layers. Instead of manually counting them, recall the knowledge from earlier labs. Reflect on whether it is feasible to minimize the number of layers. Once you have made your assessment, take the necessary steps to reduce them."

E.g.:
FROM python:3.11.4-alpine3.18
WORKDIR '/app'
RUN apk add --no-cache linux-headers g++
RUN pip install Flask
RUN pip install uwsgi
COPY ./ ./
RUN addgroup -S uwsgi && adduser -S uwsgi -G uwsgi
USER uwsgi
CMD ["uwsgi", "--ini", "app.ini"]

rebuild? = no cache
FROM python:3.11.4-alpine3.18
WORKDIR '/app'
RUN apk add --no-cache linux-headers g++
RUN addgroup -S uwsgi && adduser -S uwsgi -G uwsgi
COPY ./requirements.txt ./
RUN pip install -r requirements.txt
COPY ./ ./
USER uwsgi
CMD ["uwsgi", "--ini", "app.ini"]

## Multi-stage builds
FROM python:3.11.4-alpine3.18 as build-image
WORKDIR '/app'
RUN apk add--no-cache linux-headers g++
COPY ./requirements.txt ./
RUN pip wheel--wheel-dir=/root/wheels-r requirements.txt

FROM python:3.11.4-alpine3.18 as production-image
WORKDIR '/app'
COPY --from=build-image /root/wheels /root/wheels
COPY --from=build-image /app/requirements.txt ./
RUN pip install --no-index --find-links=/root/wheels -r requirements.txt
COPY ./ ./
RUN addgroup-S uwsgi&& adduser-S uwsgi-G uwsgi
USER uwsgi
CMD ["uwsgi", "--ini", "app.ini"]

- Usually, a single Dockerfile
	- 2 or more images will be built
	- Copy only what is needed from eachother
	- The "last image" = production image
	- Separation is possible, but potentially less convenient and clear
		- docker build -t build-image -f Dockefile.build .
		- docker build -t production-image -f Dockerfile.prod .

- Smaller image size
- Improved security
	- Because it's smaller, no unnecessary clutter in prod. image
- Faster builds
- Helps with complicated containerized apps
### Multi-stage builds -but why ...?
- Example: Building an Alarm Clock App --> publish arlarm-clock-app.exe
	- Development Version: includes coding tools and debugging utilities for developers
	- Production Version: contains only the essential alarm clock functionality for end-users
	- Benefit: reduces size and complexity of the production app, making it more efficient and user-friendly
- build image: 311MB
- prod. image: 78MB
## Alembic
- Models & Migrations
	- The user model, located in the "models" directory, has been developed using the SQLAlchemy library
	- This means we have access to an object-relational mapper (ORM) functionality, which simplifies working with databases
	- In essence, it provides a more straightforward approach to interact with the database

	- In addition, you will also come across <u>Alembic</u>, another library within the project
	- Alembic allows for seamless database migrations by offering a simple process
	- E.g.:
		- Let's say you create a user model and want to include a "date of birth" column for each user
		- With Alembic, instead of manually adjusting the table structure, it automatically detects this change and handles the necessary updates
		- If, at a later point, you decide to remove this column, Alembic will handle the required steps to revert the changes accordingly
![[Pasted image 20231103142812.png]]
## Image tagging
docker build . --tag timmy/frontend
docker build . -t timmy/frontend
docker build . -t timmy/frontend:latest
=> same result

docker build . -t timmy/frontend:1.0.3

### Image tagging:tag = rename
- docker build .
	--> writing image sha256:4fb074cb4cf1550489b40ee30697328ee85e02d2fd9ccdb66f4d98b02083d558
- docker tag 4fb07 timmy/frontend

- docker tag timmy/frontend timmy/frond-end
- docker tag timmy/frontend timmy/frontend:v2

## Registry, namespace, images, artifacts & tags
fully qualified artifact reference:
org.example.com/namespace/sub-namespace/repo:tag
- repo:tag = artifact
- org.example.com = unique registry by domain
- namespace/sub-namespace = namespace
- namespace/sub-namespace/repo = repo
- :tag = tag
exaple.com/org/namespace/sub-namespace/repo:tag
- example.com/org = unique registry by namespace

## Dependency Issues
| Operator | Meaning |
| -- | -- |
| == | Exact version |
| <= | Lower than or equal to |
| >= | Greater than or equal to |
| < | Less than |
| > | Greater than |
| != | Not equal to |
| ~= | Any compatible version |

# 4 Docker Compose Usage
## What & Why?
### Docker Compose

> "Docker Compose is a tool that allows you to define and manage multi-container Docker applications. It provides a simple way to orchestrate the running of multiple containers as a single application stack."

- Easier to run (multiple) containers
	- No huge list of paramters
	- Declarative YAML file

![[Pasted image 20231103144745.png]]
- docker-compose.yml
- Running multiple services with one command
- Easy to configure "relations" between containers
	- "depends-on"
	- service name
#### Docker Compose: Version
> version: '3.9'
- Ensures compatibility across different Docker and Docker Compose versions
- Defines syntax and feature support for correct interpretation
- Prevents issues with outdated or incompatible Compose files
- Future-proofs your deployment against changes in Docker Compose

|**Command**|**Meaning**|
|--|--|
|docker compose start | Only starts |
|docker compose up| Create & start|
|docker compose stop|Stop|
|docker compose down|Stop & clean|
|docker compose restart|Restart & apply changes|

## Intermezzo: docker-compose vs. docker compose
- docker-compose = legacy
- docker compose = what you need
	- Integrated in Docker CLI
	- Autocomplete
## Terminology
![[Pasted image 20231103145737.png]]
### Services
- Service names inside Docker-network
```
services:
	api:
	postgres:
```
Docker prepends the Docker Compose context name when naming the container
### Image
> image: eslih/basic-webapp-api:v2.0.0
- The name of the image to pull (or to tag when building)
- Make sure you have the privileges to pull to those images
- No tag means latest: image: eslih/basic-webapp-api(:latest)
### Build
> build: ./web/api
- Requires the build context for the Dockerfile
- Relative to the context of the docker-compose.yml file
	- or explicitly: context: .
- When using 'docker compose up'
	- Automatically builds when there is no build yet
	- --build
### Ports vs. Expose
```
ports:
	-"8080:80"
```
- Maps host ports to Docker **internal** ports
- E.g.: An application that runs internally on port 80, will be accessible through localhost:8080 when mapped with 8080:80
- host-port:service-port
```
expose:
	-"5432"
```
- Exposes a port **inside** the Docker network
- NOT accessible from outside of Docker
- E.g.: An application that runs internally on port 5432, will not be accessible through localhost:5432, but can only be accessed by other services in the Docker Compose network
### Network
- Services inside docker-compose.yml reside in a network by default
- **Important**
	- Services have an internal hostname = service name -> api, postgres
	- Services can call another service with `<hostname>:<internal-port>`
		- response = `requests.get('http://api[:80]')`
		- connection = `mysql.connector.connect(host='postgres', user='username', password='password', database='database_name')`
- Drivers
	- Bridge
		- Isolated network bridge on host
	- Host
		- Share network with host (performance, or bind to specific interfaces)
	- Overlay
		- multi-host -> Docker Swarm / Kubernetes
	- Mcvlan
		- assign MAC-address to container & connect directly to physical network
	- None
		- Disabling network
	- Custom
		- Specialized solution, e.g.: third-party networking solutions
- Internal / External
	- Connect to "other" Compose project
```
services:
	# ...
networks:
	loadbalancer:
		name: loadbalancer
		external
```
#### Ports, expose & networks: common mistake!
![[Pasted image 20231103155156.png]]
### Volumes
```
volumes:
	- ./api:/app
```
- Inject files into a Docker Container
- Allows for persistent storage
- Can be shared by multiple containers
#### Mapping Options
##### Named Volumes
```
version: "3.9"
services:
	app:
		image: myapp
		volumes:
			- mydata: /app/data
volumes:
	mydata:
```
- Directory created within Docker's storage
- Directory on the host, managed by Docker
- Named volumes are recommended for most use cases
##### Host Bind Mounts
```
version: "3.9"
services:
	app:
		image: myapp
		volumes:
			- /path/on/host:/app/data
```
- File or directory on the host is mounted into the container
- Changes made in the container are reflected on the host and vice versa
- Path can be absolute or relative
	- Absolute
		- /home/esli/my_project:/app
		- /home/esli/config.txt:/app/config.txt
	- Relative
		- ./:/app
		- ./config.txt:/app/config.txt
##### Tmpfs Mounts
```
version:"3.9"
services:
	app:
		image: myapp
		volumes:
			- tmpfs:/app/temp
volumes:
	tmpfs:
		driver: local
```
- Create a temporary file system in memory that is mounted inside the container
- Temporary or volatile data that doesn't need to persist across container restarts
##### Anonymous Volumes
```
version: "3.9"
services:
	app:
		image: myapp
		volumes:
			- /app/data
```
- Anonymous volumes are created automatically by Docker and are assigned a random name
- Typically used when you don't need to manage the volume explicitly
- Recommendation: prefer Named Volumes
#### Volumes vs. Image
> "But sir, I can also COPY or ADD files, why shouldn't I do that?"

- Volumes:
	- Allow you to **separate data from** the image (separating **application code**)
	- Data can be **shared** between containers
	- Handy to **manage data** that changes
	- More "**production** ready"
- Be careful with private files & secrets!
	- Should not be included in an image
	- Volumes can be a solution, but ...
### Environments
```
envrionment:
	- POSTGRES_USER=student_user
	- POSTGRES_PASSWORD=student_password
	- POSTGRES_DATABASE=labo
	- POSTGRES_PORT=5432
	- POSTGRES_HOST=postgres
	- PORT=80
env_file:
	- .env
```
- Allows to inject environment variables that can be used to override or set settings
- Work with a .env file for more security or sharing variables with other containers
- Typical tasks
	- Set connection settings
	- Port overrides
	- Production mode / Developer mode
#### Example Nginx
```
web:
	image: nginx
	volumes:
		- ./templates:/etc/nginx/templates
	ports:
		- "8080:80"
	environment:
		- NGINX_HOST=foobar.com
		- NGINX_PORT=80
```
- By default, this function reads template files in `/etc/nginx/templates/*.template*` and ouputs the result of executing `envsubst` to `/etc/nginx/conf.d`
- So if you place `tamplates/default.conf.template` file, which contains variable references like this:
	- `listen     ${NGINX_PORT};`
- outputs to `/etc/nginx/conf.d/default.conf` like this:
```
COPY nginx.conf /etc/nginx/nginx.conf
user nginx;
worker_processes   1;
error_log   /var/log/nginx/error.log warn;
pid         /var/run/nginx.pid;
events {
worker_connections1024;
}
http {
include            /etc/nginx/mime.types;
default_type       application/octet-stream;
access_log         /var/log/nginx/access.log main;
sendfile           on;
keepalive_timeout  65;
include            /etc/nginx/conf.d/server.conf;
}
```
```
COPY server.conf.template
/etc/nginx/templates/server.conf.template
server {
		listen        ${NGINX_PORT};
		server_name   localhost;
	location / {
		root          /app;
		index         index.html;
	try_files $uri $uri/ /index.html;
	}
	error_page 500 502 503 504 /50x.html;
	location = /50x.html {
		root /usr/share/nginx/html;
	}
}
```

### Secrets
```
	app:
		image: myapp
		secrets:
			- my_secret
secrets:
	mysecret:
		external: true
```
- You need Docker Swarm... -> Not very common -> Use environment vars!
- Secrets in Kubernetes are more common
- Use thrid-party
### Depends_on
```
api:
	depends_on:
		postgres:
```
- Override the order in which to startup services
	- In this case API waits for Postgres to start up
- Is necessary if you require certain connections to be started upfront
	- Waits until the service is "running" -> but may not be ready yet
	- (In the past it worked somewhat different -> not the microservice way)
### Entrypoint
Default Docker entrypoint: /bin/sh -c
- The program that is started when the container starts
- The actual command (CMD) is executed after the entrypoint
- Just wait, sleep (handy when debugging):
	- `entrypoint: [ "sh", "-c", "sleep 3600" ]`
- Example shell script: entrypoint.sh
```
#! /bin/sh
# ... do some setup ...
# then run the CMD passed as command-line arguments
# $@ --> passthrough which then runs the Docker command (CMD)

exec "$@"
```
- Example command: `CMD ["python", "main.py"`]
### Healthcheck
```
services:
	postgres:
		image: postgres
		env_file:
			-.env
		healthcheck:
			%% Built-in check: database is ready to accept connections %%
			test: ["CMD-SHELL","pg_isready"]
			interval: 10s
			timeout: 5s
			retries: 5
			start_period: 10s
api:
	# ...
	%% Wait until service (postgres) is ready =/= database is ready %%
	depends_on:
		postgres:
			%% = database is ready to accept connections, API will work %%
			condition: service_healthy
```
- Check the health of a service
	- Best to combine with depends_on
	- A better alternative (in most cases) for custom entrypoint
- Still not perfect given microservice architecture
	- Database goes offline -> Unhealthy = API is down
	- Databaase comes back online -> Healthy = API is up
	- API is down? No error, should "catch" from front-end application
- Maybe better to check connection health in application instead of in Docker (Compose)
### Restart
```
services:
	myservice:
		image: myimage:latest
		restart: always
```
1. no
	= no automatic restart
2. always
	= restart whatever happened
3. on-failure[:max-retries]
	= restart on non-zero exit code*
1. unless-stopped
	= similar to always, just don't restart when explicitly stopped

> * Exit codes
> 	= numeric value indicating the success or failure of a program
> 	0 typically means success, while non-zero values indicate errors
> 	Different codes have specific meanings, aiding in troubleshooting and automation
> 	They are useful for conditional branching and error handling in scripts
> 	``` 
> 	import sys
> 	def some_function():
> 		# Your code logic here
> 		# Set an exit code
> 		exit_code = 1
> 		sys.exit(exit_code)
> 	```
### Interacting & logs
```
docker compose logs
docker compose logs <service>
docker compose logs -f <service>
```

| Argument| Meaning|
| -- | -- |
| -f| Follow log output|
|--no-color| Produce monochrome output|
|--no-log-prefix|Don't print prefix in logs|
|--since|Show logs since tymestamp|
|--tail|Number of lines to show from the end of the logs for each container|
|-t|Show timestamps|
|--until|Show logs before a timestamp|
|-d|Detached mode: Run command in background|
|-e|Set environment variables|
|--index|Index of the container if there are multiple instances of a service (default: 1|
|-i|Keep STDIN open even if not attached|
|-T|Disable pseudo-TTY allocation|
|--privileged|Give extended privileges to the process|
|--tty|Allocate a pseudo-TTY|
|-u|Run the command as this user|
|-w|Path to workdir directory for this command|

### Best practices / Recommendations
- No hardcoding
	- Don't put configuration in Dockerfile
		- Hard to override
		- Hard to refactor
	- Configuration in config files / docker-compose.yml
## Intermezzo: Gitignore
- If repo contains config file with passwords:
	- make 2 config files:
		- config_example.py with placeholders
		- config.py with passwords and added to .gitignore
## Advanced
### Fragments & Extensions
```
version: '3.9'
services:
  frontend:
    image: frontend-image
    labels:
      - "com.example.project=Demo Project Esli"
      - "com.example.env=production"
      - "com.example.team=team-esli"
      - "com.example.component=frontend"
  backend:
    image: backend-image
    labels:
      - "com.example.project=Demo Project Esli"
      - "com.example.env=production"
      - "com.example.team=team-esli"
      - "com.example.component=backend"
  database:
    image: mysql:5.7
    labels:
      - "com.example.project=Demo Project Esli"
      - "com.example.env=production"
      - "com.example.team=team-esli"
      - "com.example.component=database"
```
- Repeating ourselves...
- & = variable declarations
- * = variable usage
- x = starting with x, will be ignored
```
version: '3.9'
x-common-labels: &common-labels
  labels:
    - "com.example.project=Demo Project Esli"
    - "com.example.env=production"
    - "com.example.team=team-esli"
services:
  frontend:
    image: frontend-image
    <<: *common-labels
    labels:
      - "com.example.component=frontend"
  backend:
    image: backend-image
    <<: *common-labels
    labels:
      - "com.example.component=backend"
  database:
    image: mysql:5.7
    <<: *common-labels
    labels:
      - "com.example.component=database"
```
- Recommendation: use multiple Docker Compose projects & share the network
	- Separate .yml file for frontend, backend and docker-compose.yml
frontend.yml:
```
version: '3.9'
services:
  frontend:
    build:
      context: ./frontend
      dockerfile: Dockerfile
    ports:
      - 80:80
    networks:
      - mynetwork
```
backend.yml:
```
version: '3.9'
services:
  backend:
    build:
      context: ./backend
      dockerfile: Dockerfile
    ports:
      - "8080:8080"
    networks:
      - mynetwork
  database:
    image: mysql:5.7
    environment:
      MYSQL_ROOT_PASSWORD: mysecretpassword
      MYSQL_DATABASE: mydatabase
    networks:
      - mynetwork
networks:
  mynetwork:
```
docker-compose.yml:
```
version: '3.9'
services:
	frontend:
		<< : *frontend
	backend:
		<< : *backend
```
# 5 Kubernetes Basics
## Introduction
- Using Kubernetes to deploy a microservices API
- Introduction to Kubernetes
- Working with Kubernetes
- Configuring Kubernetes to scale services
## Current Problem
- Managing, scaling and updating Docker containers in a production environment
- Giving users access to specific Docker containers running on different machines
- Managing a large amount of resource
	- More CPU and RAM than available onto one machine
	- Big workloads such as data processing or queries can require quite some power
- Quickly deploying applications onto existing hardware
## ~~Current problem~~ Solution? => Kubernetes
- Can manage, organize and scale deployments of Docker containers
- Can deploy Docker containers across multiple (virtual) machines
- Allows users to access certain applications and block access to others
- Can automate deployments
- "Container Orchestration"
## Kubernetes

> *Kubernetes is a **portable**, **extensible**, **open-source** platform for **managing containerized workloads** and **services**, that facilitates both **declarative configuration** and **automation**. It has a large, rapidly growing ecosystem. Kubernetes services, support and tools are widely available.*

- Service discovery and load balancing
- Storage orchestration
- Automated rollouts and rollbacks
- Self-healing
- Auto scaling
![[Pasted image 20231111144947.png]]

### Kubernetes: Architecture

> *A Kubernetes cluster consists of a set of worker machines, called nodes, that run containerized applications.
> Worker nodes host the Pods that are the components of the application workload. The control plane manages the worker nodes and the Pods in the cluster. In production environments, the control plane usually runs across multiple computers and a cluster usually runs multiple nodes, providing fault-tolerance and high availability*
![[Pasted image 20231111145411.png]]
- Control plane / Kubernetes Master
	- Scheduler:
		- Makes sure the number of desired pods is always running
		- Keeps track of capacity and resources of nodes
		- Assigns work to nodes based on availability
	- Controller:
		- Responsible for registering nodes and monitoring health
	- etcd:
		- A persistent and distributed key-value data store
		- Stores the state and configuration data for the entire cluster
	- API-server:
		- Main access point to the control plane and mater node
- Node
	- Kubelet:
		- Manages the state of a node
			- Starting, stopping and maintaining application containers with instructions from the control plane
		- Collects performance and health information of node, pods and containers
			- Shares those with the control plane
	- Kube-Proxy:
		- Network Proxy
		- Manages the Virtual IP addresses of pods and services
		- Also works as a load balancer for services running on a node
	- Pod
### Kubernetes: Objects

> *Kubernetes objects* are persistent entities in the Kubernetes system. Kubernetes uses these entities to represent the state of your cluster. Specifically, they can describe:
> 	- What containerized applications are running (and on which nodes
> 	- The resources available to those applications
> 	- The policies around how those applications behave, such as restart policies, upgrades and fault-tolerance
> A Kubernetes object is a *"**record of intent**"* once you create the object, the Kubernetes system will constantly work to ensure that object exists. By creating an object, you're effectively telling the Kubernetes system what you want your cluster's workload to look like. This is you cluster's *desired state*.

### Kubernetes: Building Blocks
- Pods
- Services and EndPoints
- Deployments
- ReplicaSets
- DaemonSets
- StatefulSets
- Ingress
- Persistent Volumes and Persistent Volume Claims
- ConfigMaps and Secrets
### Kubernetes: Pods
> In Kubernetes, the Pod serves as a kind of basic, functional unit. A pod is a set of containers, along with their shared volumes. 
> As Kubernetes’ scheduler creates and deletes application pods unexpectedly, you should not rely on a particular pod. However, you do need to be able to access your application in a predictable manner. And to do that, Kubernetes provides the simplest form of load balancing traffic, namely a Service.

- Pod = Group of containers working together
	- Usually, group = 1 container
	- More than 1 container?
		- "Main" container and "sidecar" container(s)
			- Good example: <u>database</u> + logging + back-up
			- Bad example: <u>database</u> + <u>nginx</u> + <u>python</u> + ...
			- In practice, you barely see this, except for <u>dapr</u> in Backend Development in Azure
### Kubernetes: Services
> A Kubernetes **Service** is an abstraction which defines **a logical set of Pods** and a policy by which to access them - sometimes called a micro-service. The set of Pods targeted by a Service is (usually) determined by a **Label Selector**.
> **Services** have IP addresses (used internally by Kubernetes) which are relatively stable. When a program element needs to make use of the functions abstracted by the service, it makes **a request to the service**, rather than an individual pod. The service then acts as a dispatcher, assigning a pod to handle the request. Thus, a client never connects to a container, but to a Pod, through a Service.

- Making pods "Available"
	- Networking
	- ClusterIP (internal IP, dev environment) -> c.f.: Docker Expose
	- NodePort (possible for Production purposes) -> c.f.: Docker Ports
	- LoadBalancer (cloud service, usually production)
	- Ingress (entry point on cluster level, not a real service)
### Kubernetes: Deployment and ReplicaSets
> A [deployment](https://kubernetes.io/docs/concepts/workloads/controllers/deployment/) is a YAML object that defines the pods and the number of container instances, called **replicas**, for each pod. You define the number of replicas you want to have running in the cluster via a [ReplicaSet](https://kubernetes.io/docs/concepts/workloads/controllers/replicaset/), which is part of the deployment object. So, for example, if a node running a pod dies, the replica set will ensure that another pod is scheduled on another available node.

- Describing multiple pods:
	- Which pods should be hosted?
	- How many?
	- On which machines?
### Kubernetes: DaemonSets
> A DaemonSet ensures that all (or some) Nodes run a copy of a Pod. As nodes are added to the cluster, Pods are added to them. As nodes are removed from the cluster, those Pods are garbage collected. Deleting a DaemonSet will clean up the Pods it created.

- Some typical uses:
	- Running a cluster storage daemon, such as a glusterd, ceph on each node
	- Running a logs collection daemon on every node, such as fluentd or filebeat
### Kubernetes: StatefulSets
> Like a [Deployment](https://kubernetes.io/docs/concepts/workloads/controllers/deployment/), a StatefulSet manages Pods that are based on an identical container spec. Unlike a Deployment, a StatefulSet maintains a sticky identity for each of their Pods. These pods are created from the same spec, but are not interchangeable: each has a persistent identifier that it maintains across any rescheduling. 
> If you want to use storage volumes to provide persistence for your workload, you can use a StatefulSet as part of the solution. Although individual Pods in a StatefulSet are susceptible to failure, the persistent Pod identifiers make it easier to match existing volumes to the new Pods that replace any that have failed.

### Kubernetes: ConfigMaps and Secrets
- Decouple configurations from hard-coded environment variables
- Separate Kubernetes object to share with pods
- Difference: Secrets hold confidential information
- Example
	- Different configurations for Development, Staging and Production environments, quickly interchangeable
	- Storing passwords and using it in your applications
### Kubernetes: Load Balancer
- **L4 Load Balancing (TCP)**
	- Only available on Kubernetes Cloud Providers (GCP, AWS, Azure, ...)
- **L7 Load Balancing**
	- Can redirect traffic to specific workloads based on request
	- **Ingress**
- Kube-Proxy
	- Load distribution
	- Default: randomly route to IP addresses based on iptables
	- Previously: Round-robin
- Ingress:
	- Routes traffic based on request rules configured
	- Deploy a Controller (like nginx)
	- Deploy Resources
	- Tip: Use Rancher to deploy Ingress Controllers and Resources (UI)
### Kubernetes: Autoscaler
>Kubernetes uses the horizontal pod autoscaler (HPA) to monitor the resource demand and automatically scale the number of replicas. When changes in replica count are required, the number of replicas is increased or decreased accordingly.  
>You define the minimum and maximum number of replicas that can run. You also define the metric to monitor and base any scaling decisions on, such as CPU usage.

![[Pasted image 20231111152518.png]]
### Kubernetes: YAML File

```
apiVersion: apps/v&
kind: Deployment
metadata:
	name: nginx-deployment
spec:
	selector:
		matchLabels:
			app: nginx
	replicas: 2 # tells deployment to run 2 pods
	template:
		metadata:
			labels:
				app: nginx
		spec:
			containers:
				- name: nginx
				image: nginx:1.14.2
				ports:
					- containerPort: 80
```
- apiVersion: 
	- Version of Kubernetes API
- kind:
	- kind of object you want to create
- metadata:
	- Data that helps uniquely identify the object, including the name string, UID and optional namespace
- spec:
	- what state you desire for the object
## Kubernetes clusters are complex
1. Images must already exist
	- Building DockerFile
2. Images must be available
	- Container Registry: Docker Hub, ACR, GCR, GCHR, ...
3. Which containers should run?
	- Deployments
4. How to access those containers?
	- Services
	- Load Balancers
### Kubernetes Dashboard
- Lots of dashboard options from external vendors
- Kubernetes also built one
- Functionalities:
	- View cluster status, deployment options and logs
	- Perform operations directly from browser
	- Create applications by filling in a form
