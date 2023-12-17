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

**Answer:**
- Optimize Layer efficiency
### Working with Basic Docker Commands:
**Answer:** A) docker exec

### How to work with Docker Compose and its usefulness:
**Answer:** D) docker compose up

### Docker Compose terminology and components:
**Answer:** C) Service

### Microservices communication in Docker (Compose):
**Answer:** A) Using environment variables

### Docker (Compose) best practices and recommendations:
**Answer:** A) Separate files for each environment

### Fragments & extensions:
**Answer:** D) To reuse common configurations across multiple Compose files

### Why Kubernetes is useful for microservices:** Answer: A) It enables easier scaling and deployment of microservices across a cluster.

### The Kubernetes Building Blocks:
Answer: A) Pods
### How autoscaling in Kubernetes works:
Answer: C) CPU utilization
### Different kinds of Load Balancing options:
Answer: B) ClusterIP
### How to write a YAML file for a Kubernetes object:
Answer: B) spec
### How the Kubernetes CLI works:
Answer: C) kubectl describe nodes
### How to set up Kubernetes with Docker Desktop:
Answer: D) Kubernetes Settings
### Persistent Volumes and Volume Claims and why they are needed:
Answer: B) It requests a persistent storage volume of a particular type and size.
### Helm charts, how to install and use them:
Answer: B) Creating and managing Kubernetes applications
### NodePorts and ClusterIP differences:
Answer: A) NodePorts provide access to pods from outside the cluster, while ClusterIPs are only internal.
### What Rancher is and why it is more useful than some other Dashboards:
Answer: B) Rancher is a dashboard that simplifies cluster management and provides additional features like multi-cluster management and centralized authentication.
### The Kubernetes Workflow from Software creation to deployment:
Answer: B) Build