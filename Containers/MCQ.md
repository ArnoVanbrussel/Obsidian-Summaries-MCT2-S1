### What is a container, why do we need it?
**Question:** What is a container, and what purpose does it primarily serve?
	- A) A container is a lightweight, portable, and isolated environment used to run applications, ensuring consistency across different computing environments.
	- B) A container is a hardware-based virtual machine for running multiple operating systems simultaneously.
	- C) A container is a physical storage unit for data on a server.
	- D) A container is a high-level programming construct used in software development.
### What is Docker, the Docker Engine (daemon)?
**Question:** What is Docker, and what does the Docker Engine (daemon) do?
	- A) Docker is a container orchestration tool used for automating deployment, scaling, and management of containers. The Docker Engine manages clusters of containers.
	- B) Docker is an operating system that specializes in containerization, and the Docker Engine is the central management system for containers.
	- C) Docker is a specific container image format, and the Docker Engine helps in compressing and decompressing these images.
	- D) Docker is a programming language for building containerized applications, and the Docker Engine interprets and runs these applications.

### What are microservices?
**Question:** What characterizes microservices in software architecture?
- A) Microservices are large, monolithic applications with tightly coupled components.
- B) Microservices are a way of structuring applications as a collection of loosely coupled services, each responsible for a specific function.
- C) Microservices are solely used in frontend development to handle user interfaces.
- D) Microservices refer to the process of minimizing the number of services in an application to improve efficiency.

### Virtualization vs. Containerization?
**Question:** What is a key difference between virtualization and containerization?
	- A) Virtualization allows running multiple operating systems on a single physical machine, while containerization virtualizes the operating system itself.
	- B) Containerization uses containers to encapsulate applications and their dependencies, while virtualization utilizes hypervisors to create virtual machines.
	- C) Virtualization is less secure than containerization due to the lack of isolation between instances.
	- D) Containerization doesn't allow sharing resources among multiple containers.

### What is a kernel? What about features like cgroups & namespaces?
**Question:** What role does the kernel play in the context of containers, and what do features like cgroups and namespaces do?
	- A) The kernel is the central component of an operating system, providing low-level functionalities. Cgroups and namespaces are kernel features that control resource allocation and isolation for processes and their resources.
	- B) The kernel refers to a specific type of container used in Linux systems. Cgroups and namespaces are user interfaces for interacting with containers.
	- C) The kernel manages only hardware-related functions in a system. Cgroups and namespaces are unrelated to containerization.
	- D) The kernel controls network settings within containers. Cgroups and namespaces regulate container image sizes.
### Linux / Ubuntu landscape?
**Question:** What describes the Linux/Ubuntu landscape in the context of containers?
	- A) Linux/Ubuntu provides extensive support for containerization, with various tools and technologies like Docker, Kubernetes, and container-specific OS distributions.
	- B) Linux/Ubuntu is not suitable for containerization due to its complex architecture.
	- C) Linux/Ubuntu solely relies on virtualization for software deployment, neglecting container technologies.
	- D) Linux/Ubuntu offers containerization only for specific programming languages.

### Finding, Pulling, Tagging, and Pushing Images:
**Question:** What command is used to download a Docker image from a registry?
	- A) docker copy
	- B) docker fetch 
	- C) docker pull 
	- D) docker download
### Optimizing a Dockerfile:
**Question:** What practice can help optimize a Dockerfile for smaller image sizes?
- A) Including unnecessary files and dependencies 
- B) Using multiple base images for different components 
- C) Consolidating commands and reducing layer count 
- D) Avoiding the use of caching mechanisms

### Working with Basic Docker Commands:
**Question:** Which command allows you to execute a command in a running container?
- A) docker exec 
- B) docker run 
- C) docker command 
- D) docker execute
### How to work with Docker Compose and its usefulness:
**Question:** What command allows you to start and run services defined in a Docker Compose file?
    - A) `docker up`
    - B) `docker run`
    - C) `docker-compose start`
    - D) `docker-compose up`
### Docker Compose terminology and components:
**Question:** Which term in Docker Compose refers to a single container running a specific image?
    - A) Module
    - B) Block
    - C) Service
    - D) Section
### Microservices communication in Docker (Compose):
**Question:** What is a common way for microservices to communicate in Docker Compose?
    - A) Using environment variables
    - B) Utilizing only HTTP requests
    - C) Directly accessing each other's file systems
    - D) Broadcasting messages over the network
### Docker (Compose) best practices and recommendations:
**Question:** What's a recommended approach to define multiple environments in a Docker Compose file?
    - A) Separate files for each environment
    - B) Use single, monolithic configuration files
    - C) Avoid defining environments in Compose files
    - D) Rely solely on environment variables
### Fragments & extensions:
**Question:** What is the purpose of using fragments and extensions in Docker Compose?
    - A) To create isolated containers
    - B) To simplify container deployment
    - C) To break down services into smaller components
    - D) To reuse common configurations across multiple Compose files

# Answers
### What is a container, why do we need it?
**Answer:** A) A container is a lightweight, portable, and isolated environment used to run applications, ensuring consistency across different computing environments.

### What is Docker, the Docker Engine (daemon)?
**Answer:** A) Docker is a container orchestration tool used for automating deployment, scaling, and management of containers. The Docker Engine manages clusters of containers.

### What are microservices?
**Answer:** B) Microservices are a way of structuring applications as a collection of loosely coupled services, each responsible for a specific function.

### Virtualization vs. Containerization?
**Answer:** B) Containerization uses containers to encapsulate applications and their dependencies, while virtualization utilizes hypervisors to create virtual machines.

### What is a kernel? What about features like cgroups & namespaces?
**Answer:** A) The kernel is the central component of an operating system, providing low-level functionalities. Cgroups and namespaces are kernel features that control resource allocation and isolation for processes and their resources.

### Linux / Ubuntu landscape?
**Answer:** A) Linux/Ubuntu provides extensive support for containerization, with various tools and technologies like Docker, Kubernetes, and container-specific OS distributions.

### Finding, Pulling, Tagging, and Pushing Images:
**Answer:** C) docker pull

### Optimizing a Dockerfile:
**Answer:** C) Consolidating commands and reducing layer count

### Working with Basic Docker Commands:
**Answer:** A) docker exec

### How to work with Docker Compose and its usefulness:
**Answer:** D) docker-compose up

### Docker Compose terminology and components:
**Answer:** C) Service

### Microservices communication in Docker (Compose):
**Answer:** A) Using environment variables

### Docker (Compose) best practices and recommendations:
**Answer:** A) Separate files for each environment

### Fragments & extensions:
**Answer:** D) To reuse common configurations across multiple Compose files