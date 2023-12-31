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

**Question:** Give 5 ways to optimize a Dockerfile.

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
    - C) `docker compose start`
    - D) `docker compose up`
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
    - D) Rely on environment variables
### Fragments & extensions:
**Question:** What is the purpose of using fragments and extensions in Docker Compose?
    - A) To create isolated containers
    - B) To simplify container deployment
    - C) To break down services into smaller components
    - D) To reuse common configurations across multiple Compose files
### Why Kubernetes is useful for microservices:
**Question:** Which of the following describes a key advantage of Kubernetes in managing microservices?
	- A) It enables easier scaling and deployment of microservices across a cluster.
	- B) It primarily focuses on monolithic architecture.
	- C) It restricts the number of programming languages used in microservices.
	- D) It doesn't support service discovery.

### The Kubernetes Building Blocks:
**Question:** What component in Kubernetes is responsible for managing and maintaining containers within a node?
	- A) Pods
	- B) Services
	- C) Ingress
	- D) Kubelet

### How autoscaling in Kubernetes works:
**Question:** Which factor triggers autoscaling of pods in Kubernetes?
	- A) Memory usage
	- B) Number of deployments
	- C) CPU utilization
	- D) Network bandwidth

### Different kinds of Load Balancing options:
**Question:** Which Kubernetes service type provides load balancing within a cluster using the round-robin algorithm?
	- A) NodePort
	- B) ClusterIP
	- C) ExternalName
	- D) LoadBalancer

### How to write a YAML file for a Kubernetes object:
**Question:** Which section of a Kubernetes YAML file specifies the desired state of the resource?
	- A) metadata
	- B) spec
	- C) apiVersion
	- D) kind

### How the Kubernetes CLI works:
**Question:** Which command is used to view the current nodes in a Kubernetes cluster?
	- A) kubectl nodes
	- B) kubectl get pods
	- C) kubectl describe nodes
	- D) kubectl cluster-info

### How to set up Kubernetes with Docker Desktop:
**Question:** Which feature in Docker Desktop allows users to easily enable Kubernetes?
	- A) Container Registry
	- B) Kubernetes Dashboard
	- C) Docker Compose
	- D) Kubernetes Settings

### Persistent Volumes and Volume Claims and why they are needed:
**Question:** In Kubernetes, what is the purpose of a PersistentVolumeClaim (PVC)?
	- A) It defines storage classes for persistent volumes.
	- B) It requests a persistent storage volume of a particular type and size.
	- C) It creates a snapshot of a persistent volume.
	- D) It manages access control for volumes.

### Helm charts, how to install and use them:
**Question:** What is the primary function of Helm in Kubernetes?
	- A) Managing persistent volumes
	- B) Creating and managing Kubernetes applications
	- C) Setting up load balancers
	- D) Configuring container registries

### NodePorts and ClusterIP differences:
**Question:** What is a key distinction between NodePorts and ClusterIPs in Kubernetes networking? 
	- A) NodePorts provide access to pods from outside the cluster, while ClusterIPs are only internal. 
	- B) NodePorts are used for intra-cluster communication, while ClusterIPs are for inter-cluster communication. 
	- C) NodePorts offer higher security compared to ClusterIPs. 
	- D) ClusterIPs are used exclusively for load balancing.

### What Rancher is and why it is more useful than some other Dashboards:
**Question:** Which statement best describes Rancher in Kubernetes ecosystem? 
	- A) Rancher is a container orchestration tool similar to Kubernetes. 
	- B) Rancher is a dashboard that simplifies cluster management and provides additional features like multi-cluster management and centralized authentication.
	- C) Rancher is a built-in Kubernetes service available only in specific cloud providers. 
	- D) Rancher is a monitoring tool specifically designed for Kubernetes clusters.

### The Kubernetes Workflow from Software creation to deployment:
**Question:** Which phase of the Kubernetes workflow involves packaging an application, its dependencies, and metadata into a portable container image? 
- A) Deployment 
- B) Build 
- C) Testing 
- D) Monitoring
