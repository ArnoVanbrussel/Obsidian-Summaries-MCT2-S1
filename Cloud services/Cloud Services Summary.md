# 1 Introduction Azure Cloud

## What is Cloud Computing

> *Cloud computing is a model for enabling ubiquitous, convenient, on-demand network access to a shared pool of configurable computing resources (e.g. networks, servers, storage, applications and services) that can be rapidly provisioned and released with minimal management effort or service provider interaction.*

**Some characteristics:**

- No own hardware
- Unlimited computing power
- Unlimited storage capacity
- Scaling up and down on demand or automatically
- Scaling in and out on demand or automatically
- Geographical distribution
- Pay what you use

![[Pasted image 20231118105910.png]]

### On Premise (dedicated servers)

- IT Department responsible for EVERYTHING
- Backup & recovery
- Hardware purchase
- Scaling...
- Most freedom to work
- Sometimes investing in hardware you only need for limited number of days
- Ex: webshop and Christmas period
- Sometimes required by legistlation
- Medical data
- Financial data
- Lack of trust with public cloud provider (cfr NSA)

### Hybrid Cloud

- Connect own data center to a cloud environment
- Certain services run in a cloud environment, other in their own data center
- Run heavy load on the cloud
- Certain data may NOT be stored in the cloud, e.g. medical
- Can also be used in backup scenarios

### IaaS

- No own hardware
- Rent VMs in Cloud environment
- System admin must configure and secure and update server himself
- Lot of flexibility towards software installation
- Lot of freedom + responsibility
- Scaling must be done by you (sometimes auto scaling possible)
- Widely used for migration existing On Premise to Cloud

### PaaS

- No system admin needed
- Dev creates application and "places" on Cloud platform
- No worries about servers, hosting, backups, scaling => platform will manage it
- Lot of flexibility

### SaaS

- Software usually does not run locally (exception Adobe & Office)
- Pay per month / per user
- Flexible subscriptions, quick to set up
- We should not take into account backups and up time

![[Pasted image 20231118110910.png]]

#### Some Public Cloud Vendors:

- AWS (Amazon)
  - Netflix
  - PlayStation
  - Spotify
  - Airbnb
  - ...
- Google Cloud
  - Coolblue
  - Philips
  - Red Bull
  - P&G
  - ...
- IBM Bluemix
- Microsoft Azure
  - HP
  - BMW
  - Sodexo
  - Pepsi
  - Adobe Creative Cloud
  - ...
- Oracle Cloud
- Alibaba Cloud

## Microsoft Azure

### Waarom?

- Both .NET and Open Source (PHP, Java, Node, Python, Flask, Docker, ...)
- Good tools
- Very low entry for students

### Azure Subscription

- Subscription determines how they invoice
- Different options
- Buy credits in advance
- Pay by use
- In practice: one subscription per customer

### Azure Portal

- Managing your Cloud services and applications
- Log in with your Howest Account
- Choose passw...

### Resource Group

![[Pasted image 20231118111842.png]]

- Logical Container
  - Per project
  - Per service
    - Storage
    - Webservers
    - Fileservers
    - SQL, Blob, ...
  - You can choose
  - Easy to test: you can delete resource group with all content
  - Access rights per resource group are possible
    - Office 365
  - You choose data center location

## Azure Virtual Machines

- Own server on Azure environment
- Mostly on-premise that we virtually move to Azure
- Lot of possibilities
  - File servers
  - Database servers
  - Webservers
  - Application servers
  - ...
- Access resources on server that are not possible via web application
  - e.g.: Communication with older software packages
  - Generation of Word/Excel docs
- When you want full control over your machine
- Full control == full responsibility
  - not to be underestimated
  - security, patching, scaling, ...
- Windows, Linux
- Planned maintenance
  - Azure platform updates
    - Stability
    - Security
    - Performance
- Unplanned maintenance
  - Failure of underlying architecture
    - Disk problems
    - Rack problems
    - Network problems
  - Azure will automatically move VM to working infrastructure
- Keep VM up
  - Availability Set
    - Guarantee of 99.95% up time
    - at least 2 VMs required
    - More expensive

## Azure Web App

- Azure Platform Service
- Allows us to place web apps online
- DON'T need own server
- DON'T need to configure web server
- Click & go
- Easiest way to get your  application online, easy deployment
- Easy to connect to a GitHub Repo
- Autoscale (not free)
- Monitoring
- Staging mode
- Free
  - Shared server with other web apps
  - 1GB storage
  - Limitation on traffic per day (165 MB)
  - Free HTTPS on wildcard domain (azurewebsites.net)
    ![[Pasted image 20231118112825.png]]
- Shared
  - Shared server
  - 1GB storage
  - Possibility of DNS (www.customname.be)
    ![[Pasted image 20231118112832.png]]
- Basic, Premium
  - App Service Plan, Own server, so do not share anything with 3rd parties (you cannot log into that server)
  - SSL
  - Custom domains
  - CPU choice
  - Memory Choice
  - Scaling up to 3 devices
    ![[Pasted image 20231118112941.png]]

### Scaling

#### Scale Up (Vertical scaling)

- Make server more powerful, more memory, more CPU cores, no extra machine
- Pro
  - Less energy required than scale out
  - Easier to implement
- Cons
  - More expensive
  - Only 1 machine => hardware failure

#### Scale Out (Horizontal scaling)

- Multiple machines but less powerful
- Pro
  - Cheaper
  - Better protection in case of hardware failure
- Cons
  - More space in data center
  - More energy
  - More complex network
  - Sometimes customized application

## Azure Static WebApp

- Alternative to Netlify
- Hosting support for
  - VueJS
  - React
  - Angular
  - Blazor Web Assembly
- Security System present via AzureAD (we'll see later)
- Require Github pipelines to use
- Good collaboration with Azure Functions for API

## Azure SQL

- SQL Server Database on Cloud platform
- We don't have to buy any hardware/software ourselves
- System will make backups itself
- Easy scaling at heavy loads
- 3 options
  - Serverless Managed Database (onze voorkeur)
  - SQL Managed Instance
  - SQL Virtual Machine
- SQL Server Cloud Based
  - Compatible with SQL Server 2012
  - Manage via Enterprise Manager
  - Works like a regular SQL Server
  - Connecting is possible via .NET, Node, Python, PHP, ...
  - High Availability
  - Replication across 3 servers (default)
  - Automatic Backups
    ![[Pasted image 20231118114822.png]]
- Azure DTU (Database Transaction Unit)
  - Mixed unit of CPU, Memory, I/O
  - These resources are available to you
  - The more DTU, the more power, the more expensive
    ![[Pasted image 20231118114951.png]]
- Throttling
  - Interrupting database communication because you are using too much resource
  - Take care of retry yourself
    ![[Pasted image 20231118115543.png]]
- Security
  - Allow IP of own network on Azure Firewall

### Azure Database for MySql

- Access via MySql Workbench
- Works like a regular MySQL
- You don't have to set up your own servers, is fully managed
- Automatic backup

## Azure & Internet Of Things

- Why is Azure important for IoT
- Azure Event Hubs:
  - Receiving messages from devices
  - Azure IoT Hub
    - Receiving / Sending messages
  - Azure Streaming Analytics
    - Processing events originating from Event Hubs and IoT Hub
      ![[Pasted image 20231118115834.png]]

## Azure CLI

- Azure Portal
  - Ok for daily use
  - Not easy to automate
  - What if i need 100 sites
  - What if i need 50 servers
- Azure CLI 2.0 Solution
  - Create Commandline Azure resources
  - Easy to control via scripts
  - Ideal for DevOps

## Bash/Powershell

- Bash commandline in portal
- Everything you can do via UI can be done with CLI in portal

## Other Azure Components

![[Pasted image 20231118120611.png]]

## Important from this chapter

- Know what cloud computing is
- Who are the big players
- What species are there and their properties
- What is an Azure Subscription
- What are resource groups
- Scaling
- Pro's and Con's of Azure VMs
- When to use Azure VM
- What is SQL Azure
- What are DTU's
- Throttling
- What is an Azure Web App and when do we use it
- What is an Azure Static Web App and when do we use it

# 2 Back-End Services with Azure Functions

## The Internet of Information

- Technology
- HTML
- CSS
- Javascript
- PHP/ASP/Java

## The Internet of Services

- Connectivity
- Driving factor for mobile applications
- Cross-platform
- Easy data deletion
- Easy invocation of functionality
- Central focus on cloud platforms
- REST-Based

## The Internet of Things

- Connecting hardware
- Linking devices to the internet
- Transmitting info to the cloud
- Devices communicate with eachother
- M2M
- *Internet of Things and Internet of Services overlap*

## The Internet of Value

- "Trading value" via het internet
- Bitcoin
- Crypto
- Underlying tech is much more important
  - Blockchain
  - Distributed ledger
  - Recording transactions
  - Each transaction contains a reference to the previous transactions (chain)
- Blockchain
  - Public
  - Free
  - Open
  - Private blockchain possible
    - Lot of evolution
    - Etherium
    - Smart contracts
- Web3.js
- IoT & Blockchain => lot of potential
  ![[Pasted image 20231118132150.png]]

## Recap: HTTP

![[Pasted image 20231118132230.png]]
![[Pasted image 20231118132250.png]]

- What is HTTP?
  - Hyper Text Transfer Protocol
  - Underlying protocol on which the Internet operates
  - Retrieving text and files from servers
  - Requests are typically made by web browsers but also smartphones and IoT devices
  - HTTP determines how a request and response should appear
  - HTTP includes a set of commands (verbs)
    - GET (retrieve data, select)
    - POST (add data, insert)
    - PUT (idempotent, update)
    - DELETE (idempotent, delete)
  - HTTP is stateless, meaning it does not consider previous requests
  - HTTP is not sessionless, we can use cookies to track data
  - HTTP is relatively straightforward
  - HTTP Response contains, in addition to data (HTML or others), a status code
    - 1xx: Informational
    - 2xx: Success
    - 3xx: Redirection
    - 4xx: Client error
    - 5xx: Server error
- HTTPS
  - Securing transport
  - Not securing data itself
  - De Facto standard
  - Browsers already report this
- HTTP Request
  ![[Pasted image 20231118132852.png]]
  - HTTP GET => HTTP verb
  - Host => server being contacted
  - User-Agent => who makes the request
  - Accept => what type of data can the client receive
- HTTP Response
  ![[Pasted image 20231118133023.png]]
  ![[Pasted image 20231118133041.png]]
  - 200 OK => Status code
  - Content-Type => What type of information being received (e.g.: text/HTML)
  - Resource Content: for example HTML-code

## What are web services?

> Web services are a technology used for enabling communication and data exchange between different software applications over the internet. They allow different systems, often developed in different programming languages and running on various platforms, to interact with each other and share data and functionality seamlessly.

- HTTP/2

  - **Standardized Communication:**
    - Use standardized communication protocols to ensure interoperability
      - HTTP(S)
      - XML
      - SOAP (simple object access protocol)
      - REST (Representational State Transfer)
  - **Platform Independence:**
    - Designed to work across different platforms
      - Possible for applications written in various programming languages to communicate
  - **Language Neutrality:**
    - Can be implemented in different programming languages
    - Can be consumed by applications written in other languages
  - **Interoperability:**
    - Enable disparate systems to exchange data and function calls
      - (without needing to understand the internal workings of eachother)
  - **Loose Coupling:**
    - Changes to one system's implementation are less likely to impact other systems
  - **Discoverability:**
    - Some Web services provide a means for clients to discover available services, making it easier to locate and use them
  - **SOAP**
    - Simple Object Access Protocol
    - XML based
    - WSDL
  - **RESTful**
    - based on principles of REST
    - HTTP methods
    - XML or JSON
  - **JSON-RPC & XML-RPC**
    - Lightweight, protocol-agnostic approaches to remote procedure calls over HTTP
    - JSON or XML
- Webservices

  - Open data
    - Free to use
    - Using webservices
      - Gent
        - https://data.stad.gent/
      - Federale overheid
        - http://data.gov.be/en
  - Cognitive services
    - AI API op Azure
      - https://azure.microsoft.com/en-us/services/cognitive-services/
      - Speech
      - Translation
      - AI
      - ...
    - Native Rest api or SDK available in .NET, Python, ...
  - Formats:
    - XML
    - JSON -> most used (we use this)

![[Pasted image 20231118134542.png]]

- JSON
  - JavaScript Object Notation
  - simple, lightweight
  - enclose in { ... }
  - write keys in lowercase
  - basis is key: value pairs
  - keys are ALWAYS enclosed in quotes " ... "
  - separate with colon "key": value
  - string value: double quotes " ... "
  - separate key value pairs with comma
  - Complex JSON
    - key can have JSON string as value
  - e.g.:

```
{
	"id": 1,
	"name": "Arno Van Brussel",
	"course": "Cloud Services"
	"address": 
	{
		"street": "Graaf Karel De Goedelaan 1",
		"city": "Kortrijk",
		"zipcode": 8500
	}
}
```

- JSON Arrays
  - Multiple JSON objects
  - enclosed in square brackets [ ... ]
  - a key can have an array of json objects
  - e.g.:

```
[
	{
		"id": 1,
		"name": "Arno Van Brussel",
		"course": "MCT"
	},
	{
		"id": 2,
		"name": "Tim Bleuzé",
		"course": "MCT"
	}
]
```

## Azure Functions

### Why?

- Simple concept for creating APIs and more
- Easy to create
- Support for various languages
- We use C#, if you prefer, use Python
- Fast and easy scalability
- No worries about servers / server management
- Cost-effective (especially with consumption plan)

## Security

- Everyone can call the function
  - No control over who does what
  - A hacker can increase the bill by constantly invoking the service
  - Others will experience slower API calls
  - Need to avoid this
- **Anonymous:**
  - Anyone can call function without any authentication or keys
- **Function:**
  - Function key will be provided via URL and callers need to include this key when invoking to gain access
  - Key that can only be used with selected function
- **Admin:**
  - Admin key must be sent via URL to invoke providing higher level of security
  - We can use this key for all functions within the application
- In code: HttpTrigger
  ![[Pasted image 20231118140055.png]]
  ![[Pasted image 20231118140112.png]]
  ![[Pasted image 20231118140125.png]]
  ![[Pasted image 20231118140213.png]]
- Benefits of key-based security:
  - Easy to set up
  - Manageable when not many users
  - Ideal for scenarios where you have control over client
    - e.g.: internal web applications
  - Drawbacks:
    - Key must be embedded in application you distribute
    - Management can be hard with many users
- Solution: https://learn.microsoft.com/en-us/azure/active-directory-b2c/user-flow-overview
- JWT Token (Backend Module)
- Authentication using
  - Facebook
  - Google Account
  - Microsoft Account

## Other Azure Functions

### Timer Trigger

- Executing the function at a specific time using a cron expression
- IoT Hub Trigger
- ...

## What's Next

- New technologies to follow?
  - GraphQL
    - Query language for APIs
  - gRPC
    - Open-source remote procedure framework

## How to call Azure Functions

### Connect Raspberry Pi

- 4 scenarios
  1. HTTP GET to retrieve data from Webservice on Azure
  2. HTTP POST to send data to Webservice on Azure
  3. HTTP PUT to update data
  4. HTTP DELETE to remove data
- Requests library for Python

## What is important from this chapter?

- What types of "Internet" are we talking about?
- What are Web services and their properties?
- When should you use GET, POST, PUT, DELETE?
- Which HTTP verbs are idempotent?
- Which status codes should I return?
- What is JSON, and ensure you can manually write JSON?
- How can you call Azure Functions from Python?
- What types of Azure Functions are there?
- What is a cron expression?

# 3 Azure Storage
## Types of Data
- Unstructured data
	- Video
	- Afbeeldingen
	- PDF, Word, Excel, ...
- Structured data
	- SQL Database
- Semi Structured data
	- JSON
	- XML
## Azure Storage Account
- Storage of data in cloud environment
- Highly flexible in usage and pricing
- Unlimited storage
- Accessible via DNS name:
	- https://nameofthestorageaccount.blob.core.windows.net
	- https://nameofthestorageaccount.file.core.windows.net
- Always 3 copies of the data on multiple racks and disks
- Create in region of your choice
	- As close as possible to the services that will use the storage for low latency
- Resilient storage: storing data in various locations and nodes
### Locally Redundant Storage (LRS)
![[Pasted image 20231123164414.png]]

### Zone Redundant Storage (ZRS)
![[Pasted image 20231123164438.png]]

### Geo Redundant Storage (GRS)
![[Pasted image 20231123164501.png]]

- Types of Storage
	- File (not in this course
	- Disk (not in this course)
	- Blob
	- Queue
	- Table
	- Data Lake (not in this course)

- Foundation for many Azure services:
	- Virtual machines
	- Azure Functions
	- Backups
	- Anything that requires storage

- Block Blob:
	- Used for unstructured data, such as files
	- By default, doesn't have folders, only container
	- Can be addressed by enabling ADLS Gen 2
- Page Blob:
	- Suitable for random read and write operations
	- Often used for VM disks
- Append Blob:
	- Designed for appending blocks, particularly useful for logging
- Table:
	- Stores data as key/value pairs in a table, representing semi-structured data
- Queue
	- A queue where messages are placed
	- Messages are processed asynchronously by various processes such as azure functions
- Files (file share)
	- Supports SMB 2.1 and 3.
	- NFS support
- Encryption at storage level:
	- Data stored in storage account is encrypted
	- Microsoft manages keys by default
	- Option to bring own keys through Azure Key Vault for added control over encryption keys

## Azure Files
- Like a hard disk in the cloud
	- Can be mapped to your own pc (e.g.: Z:\...)
- Convenient for securely copying files between cloud server and on-premises server
- It follows well-known protocols such as SMB 2.1 or higher
- Often used in Hybrid Cloud scenarios
![[Pasted image 20231123165901.png]]
## Azure Managed Disk
- Foundation for Azure VMs
- Allows you to specify the location where the server will be hosted
- Option to create data disks
- High availability
- Low latency and high throughput
- Supports SSD disks
- Disk encryption available
![[Pasted image 20231123170444.png]]

## Azure Blob Storage
- File storage:
	- PDFs, CSS, images, JS files
- Organized into containers, each containing files
- Custom specified name for container
- Replication of the container to other regions is possible for data redundancy
- Access level
	- Public Access Level
	- Private (default): External viewing not allowed
	- Blob: External reading of individual blobs is possible
	- Container: External reading of the entire container is possible
- Uploading files via Storage Explorer (https://azure.microsoft.com/en-us/features/storage-explorer)
	- Connect
	- Account Name/Key
	- Can retrieve files with HTTP request
- Hot Access:
	- Data that is currently in use and subject to frequent read and write operations
	- Data that is ready to be potentially moved to cool storage at a later time
	- Cost-effective for read and write operations
	- Relatively more expensive in terms of storage costs
- Cool Access:
	- Used for long-term backups
	- Data that is not frequently accessed
	- More expensive for read and write operations
	- Cost-effective in terms of storage costs
- Archive:
	- Not immediately accessible
	- Data is moved to Cool or Hot before accessing
	- Requires at least 1 hour to retrieve
- Premium:
	- Extremely fast storage designed for applications that require exceptional speed
	- Does not have different tiers like hot, cool or archive; offers high performance consistently
- Static Website
	- Simple HTML page online
- Shared Access Signature (SAS)
	- Temporarily granting access to files or containers that are private
	- Expiry dates can be set
	- Can be created via Azure Portal, tools or C#
![[Pasted image 20231125160057.png]]

## Azure Storage Queues
### Cloud Queue
- An application places messages on the queue (Sender
- A second application can retrieve and process these messages at a time of its choosing (Retreiver)
- This architecture is referred to as a decoupled application
- The sender and receiver operate independently of eachother
- Can be highly scalable by launching multiple queues
- Resilience is ensured by message buffer on queue, preventing message loss if back-end goes offline
![[Pasted image 20231125160340.png]]
- E.g.:
	- Sender -> webshop, receiver is a piece of software (e.g.: Azure Functions) that will check orders and send them to a new queue
![[Pasted image 20231125160525.png]]
- Load leveling
	- Involves maintaining a constant load on an application that needs to be processed
	- Works as long as the number of messages created does not exceed what the application can handle
	- This helps ensure steady and manageable workload on the application
		- Preventing overwhelming by spikes in demand
![[Pasted image 20231125160724.png]]
- Load balancing
	- Occurs when too many messages to process per hour
	- Scaling processing application
	- Adding new instance of the application can lead to doubling of processing capacity
	- When message load decreases again, an instance can be stopped
	- High availability; if on application crashes, system doesn't go offline
![[Pasted image 20231125160901.png]]
- Temporal Decoupling
	- Separate the timing of data generation from the processing application
	- Flexibility in managing when and how data is processed
	- Scenarios where processing best done during specific time intervals or when resource availability is optimal
![[Pasted image 20231125161035.png]]
## Azure Table Storage
- Extremely large volumes
- Geo-Redundant storage
- Flexible Data Schema
	- Number of columns per row does not have to be the same
- No Relationships, Joins or Stored Procedures
- Ease of Use
![[Pasted image 20231125161340.png]]
- Partitions
	- Dividing a table into partitions
	- Each partition resides on its own server
	- Enhances scalability and load distribution across servers
- Load balancing over 3 servers
	- Azure replicates data across 3 servers
	- Distributes the load

> *Conceptually, partitions are not that different to the alphabetized sections of a phonebook. Rather than just chucking all the numbers randomly into the book, they're distributed into 26 different partitions. Then of course each person is neatly ordered alphabetically within there. It does wonderful things in terms of the time is takes to find what you need.*

![[Pasted image 20231125163543.png]]

- Entities (row):
	- Max 1MB in size
	- 255 properties (columns)
		- 3 required
			- Partition key
			- Row key
			- Timestamp (automatic)
	- Not every row needs same number of columns
- Table Storage Data Access
	- REST API
		- Cross platform HTTP Request
	- Storage client API
	- Libraries for other platforms
- Queries
	- max 1000 items at a time
		- if more, continuation token used to retrieve next set of results
	- Queries taking more than 30s are canceled
	- No indexing possible, query performance relies on other factors
	- Queries based on partition/row key are faster
- Column types:
	- Byte[]
	- Bool
	- DateTime
	- Double
	- Guid
	- Int32 (int)
	- Int64 (long)
	- String
- Where to use?
	- Profile info
	- Device info (E.g.: IMEI numbers of mobile devices within a network)
	- Telemetry data (sensor networks)
	- Data for AI models
	- Any scenario with large amount of relatively static data
## Programming Azure Storage
- When to use?
	- Storing/uploading files to Blob storage
	- Sending messages to queues
	- Writing records to table storage
	- All of the above can be done with C#, Python, JS
### Some Scenarios
1. Post binary file to Azure Functions and save to Azure Blob Storage
![[Pasted image 20231125170238.png]]
- The binary data is sent in the body of the HTTP Request via POSTMAN
![[Pasted image 20231125170311.png]]
- Save file to Blob Storage HTTP trigger example with comments:
![[blob-upload.cs]]

2. Send an email when a blob appears in Azure Blob Storage
![[Pasted image 20231125172048.png]]
**Blob Trigger**
- Execute a function when a Blob file is created in a container
- E.g.: 
	- Uploading photos to Blob for further processing
	- Uploading CSV files for processing
- In settings file we place connection string to our storage account under AzureWebJobStorage
```
{
	"IsEncrypted": false,
	"Values": {
		"AzureWebJobStorage": "DefaultEndpointsProtocol=http...",
		"FUNCTIONS_WORKER_RUNTIME": "dotnet",
		"Storage": "DefaultEnpointsProtocol=..."
	}
}
```

- In the connection string, we fill in the key from the settings file
- In the path, we fill in the name of the container
![[Pasted image 20231125173047.png]]
- What to do with Blob?
	- Send to a queue
	- Send to Deep Learning network for training
	- ...
	- We send an email with a link, we use SendGrid and Mailkit

**SendGrid**
![[Pasted image 20231125173147.png]]
`dotnet add package SendGrid --version 9.28.1`
- Use API key to send message
```
var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY").
var client = new SendGridClient(apiKey);
var from = new EmailAddress("arno.van.brussel@student.howest.be", "Blog upload");
var subject = $"File upload done {name}";
var to = new EmailAddress("arnoprivateexample@gmail.com", "Example User");
var plainTextContent = "Er is een nieuw bestand beschikbaar";
var htmlContent = "<strong>Er is een nieuw bestand beschikbaar</strong>";
var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
var response = await client.SendEmailAsync(msg);
```

**MailKit**
- Alternative for sendgrid library (not a mailservice)
`dotnet add package MailKit --version 4.2.0`

3. We populate the queue for processing by Azure Functions
![[Pasted image 20231125173724.png]]

**Queue Trigger**
- Function will become active upon receiving a message in the queue
	- Ideal for buffering during peaks
- Easy to use
- Specify connection string key in settings
- Specify name of queue from which you want to receive messagesµ
![[Pasted image 20231125173817.png]]
- Handling a message
- Here we need to convert the message from JSON format into an object
```
[FunctionName("ProcessTemperatureMessages")]
public static void Run([QueueTrigger("log-message", Connection="AzureWebJobStorage")]string myQueueItem, Ilogger log)
{
	var message = JsonConvert.DeserializeObject<TemeratureMessage>(myQueueItem);
	log.LogInformation($"C# Queue trigger function processed:       {message.Temperature}");
}
```

**Table Storage**
- We receive a message and write it to Azure Table Storage
`dotnet add package Azure.Data.Tables --version 12.8.1`
- We will write temperature data to Azure Table Storage:
![[table-storage.cs]]
![[sensorlog.cs]]
- Good Practices
	- Each Azure Function has its own task
	- An HTTP Trigger that uploads a file and then sends an email
	- 1 trigger doing everything = not recommended
	- Correct: 
		- HTTP Trigger -> File to Blob -> Blob Trigger -> Message to Queue -> Queue Trigger -> Send Email
	- 3 triggers
	- Scalable
	- Higher performance
## What is important
1. What are the different types of Azure Storage and what is their purpose
2. How does the redundancy system work in Azure Storage
3. What options and settings have we discussed, and what are their purposes
4. What is Azure Blob Storage and when do you use it
5. What is Azure Storage Queues and when do you use it
6. What is Azure Table Storage and when do you use it
7. How do Azure Functions Blob Triggers work
8. What can you use Blob Triggers for
9. What is SendGrid
10. Different Scenarios
11. Use building blocks, don't always try to build everything yourself

# 4 Azure Security + Governance
## Governance
> Process (framework, rules) to manage and monitor you Azure account, applications and resources
### Subscription Management
- Not everyone can create subscriptions (billing management)
- Not everyone is allowed to view the costs
- You can set roles via RBAC to determine who can see what
![[Pasted image 20231125180135.png]]
### Cost Management
- Managing cost
- Predicting costs is possible
- Setting triggers in case costs become too high
- Use Azure Calculator to make an estimate
### Security
- Not everyone should have access to subscription data
- Resource creation should follow a specific process
	- Azure Policy can ensure that rules are applied automatically
- Crucial for compliance
### Resource Consistency
- Consistency in deploying applications
	- e.g.: naming conventions
- Ensures that everyone can navigate within the environment
- Can be enforced through Azure Policy
### Identity Baseline
- Works in conjunction with Security Policy
- Defines authentication and authorization requirements through Azure AD
### Deployment Acceleration
- Deploying resources and services using scripts in a consistent manner
- Bicep:
>Bicep is a language for defining Azure resources that simplifies and streamlines the creation of Azure deployments. It's like a shorthand for writing Azure Resource Manager (ARM) templates, making it easier to describe and deploy cloud infrastructure.

![[Pasted image 20231125180609.png]]
### Azure Blue Prints
- Documentation and scripts to properly implement governance
- https://learn.microsoft.com/nl-nl/azure/governance/blueprints/overview
## Azure KeyVault
- Vault to store confidential information
- Connection strings, service logins, API keys, etc...
- Cloud service
- Access info from our code securely
- 3 components:
	- Secrets Management
	- Key Management
	- Certificate Management
![[Pasted image 20231125180948.png]]
- Hardware Security Module (HSM)
	- Hardware that can manage keys for authentication and cryptographic purposes
	- International standard FIPS 140
	- Only Premium Tier
![[Pasted image 20231125181039.png]]
- Secrets Management
	- API keys, connection strings, etc...
	- Stored encrypted
	- Goal: decouple from application
	- Only those with permissions can read or write them in KeyVault
	- Version Management
	- Always stored in software, not HSM
![[Pasted image 20231125181151.png]]![[Pasted image 20231125181156.png]]
- Keys Management
	- Encryption keys (public/private)
	- Storage account keys with auto sync
	- Key rotation is possible
	- Version management
	- Storage in software or HSM (premium tier)
![[Pasted image 20231125181254.png]]
- Certificates
	- X.509 Certificates
	- Managing the lifecycle of certificates
	- Managing HTTPS certificates 
- How to read KeyVault
`dotnet add package Azure.Security.KeyVault.Secrets -- version 4.3.0`
- We only need a keyvault url
![[Pasted image 20231125181414.png]]
- KeyVault Security
	- Vault Access Policy (legacy system)
	- Azure Role-Based Access Control (RBAC)
	- New
	- Gradual control over permissions
	- One Secret
	- One Key
![[Pasted image 20231125181605.png]]
![[Pasted image 20231125181612.png]]
- Still a problem
	- During debugging, dev's can read values from KeyVault
- Solution:
	- 2 KeyVaults:
		- 1 Development
		- 1 Production
		- Same key name used
		- duplicates for everything, SQL, Sendgrid, Storage ...
![[Pasted image 20231125181731.png]]
## Microsoft Entra ID
> (Azure Active Directory (AzureAD))

### Problem
- Storing login/password combo's is dangerous
- As developer or company, taking on this responsibility is not easy and strongly discouraged
- In the event of a hack or data breach, this reflects negatively on the company (mandatory reporting)
### Entry ID
![[Pasted image 20231125181919.png]]
- What?
	- Multi-tenant service for identity and access management in the cloud
	- Global scale, reliability and availability
	- 99.99% SLA (Service Level Agreement)
- What can you do with it?
	- Centrally manage users (in-/external)
	- Identity
	- Access to resources
	- SSO (Single Sign-On)
	- MFA (Multi-Factor Authentication)
- Who is using this?
	- Office 365
	- Azure Portal
	- SaaS apps (Software As A Service)
- Types:
	- B2B Collaboration
		- Inviting users into your own AD
		- Sharing applications with these users
		- Especially useful in scenarios where external individuals nee access to internal corporate apps
			- E.g.: Consultant need access to company's ERP system or when you want to grand your won employees access to cloud apps
	- B2C
		- Ideal for public web apps, SPAs, etc
			- (Single Page Applications)
		- Supports Microsoft Account, Gmail, Twitter
		- Custom login possible, with data storage in Azure AD, eliminating the need for us t manage it
		- Control over the login flow and screens is possible
		- Mainly used for public applications and for users not in your AD
- Alternatives (No Azure)
	- Okta
	- Auth0
	- AWS IAM Identity Center
	- Google Cloud Identity
## Azure Managed Identity
- Through a "type" of identity, the app must communicate with the database
	- Connection string
	- Keys
![[Pasted image 20231125182528.png]]
- We link the app to Azure AD
- Service Principal will be created (kind of user the app follows)
- When we remove app from Azure, user will disappear
![[Pasted image 20231125182706.png]]
- Can be linked to RBAC roles of the database
- System Assigned Managed Identity
	- Associated with the resource
	- Resource can have only one System Assigned Managed Identity
	- System Assigned Managed Identity can be associated with only one resource
	- Delete resource = delete System Managed Identity
- User Assigned Managed Identity
	- Is a resource itself
	- Not linked with another resource, has own lifecycle
	- We can associate it with multiple other resources along with their roles
![[Pasted image 20231125183110.png]]
- Cannot manage these identities
- Management is handled by Azure AD
## How to implement?
**Azure Keyvault**
`dotnet add package Azure.Identity --version 1.6.1`
- Need to ensure that our system knows who logged-in user is
	- Open cmd:  `az login`
	- Browser will open, log into azure portal

**Azure Managed Identity**
- Locally on your PC
	- Need to add user of Azure Account to the resource you want to use
	- Can tune permissions and grant access on per-user basis
![[Pasted image 20231125183409.png]]
## What is important
1. What is Azure Governance
2. What is KeyVault and why do you use it
3. What are the 3 services included in KeyVault and what problems do they solve
4. What is Azure AD and what are its versions and when do you use them
5. What is System Managed Identity
6. What is User Managed Identity
# 5 Azure CosmosDB
## Relational Databases
- Structured
	- Tables
		- Rows and Columns
	- Normalization
	  Schema
- SELECT, INSERT, UPDATE, DELETE, ...
![[Pasted image 20231125184621.png]]
- Originated in client/server era
- No internet, cloud, mobile data, ...
- Primarily designed to operate on single server, usually centrally within a company
- Only way to scale was through more powerful CPU/Network/Storage -> Scale Up
- Still important
## Why NoSQL Databases
- More Data
- More people
- Horizontal scaling
- Globally Accessible and Responsive
- Different types of data:
	- structured
	- semi-structured
	- unstructured
## NoSQL vs SQL
![[Pasted image 20231125185117.png]]
### Scaling
- With simple hardware, we can scale out by merely adding servers
- Hardware can be inexpensive
- No downtime
- Easy to install and configure
![[Pasted image 20231125185207.png]]
### Availability
- In case of RDBMS
	- Shared storage failure
	- Entire application goes down
![[Pasted image 20231125185243.png]]
- NoSQL
	- Data on different partitions
	- No shared data
	- Written to all storage: high availability
		- (RDBMS: possible, but complex and additional software)
	- Nodes
![[Pasted image 20231125185357.png]]
### Global Deployment
- Database in multiple data centers
- Running as close as possible to customer: low latency
- Automatic replication of data between data centers
![[Pasted image 20231125185442.png]]
### Distributed Systems
- NoSQL is a distributed system
	- Multiple servers (sometimes aka nodes)
	- Nodes/Servers communicate over network
	- Data will be on multiple machines
	- Transparent to application, users may not be aware
## Types of NoSQL Databases
1. Key/Value
2. Document database
3. Column store (not in this course)
4. Graph (not in this course)
### Key-Value (Azure Table Storage)
- Simplest NoSQL database
- Unique key + One value
- Value can be JSON or another document
- Database doesn't know what type of data it is, only stores it
	-  We don't need to specify
- Application that retrieves data based on the key must be able to interpret the value
- When to use?
	- User session info, user profiles, shopping baskets
	- Data where you don't need complex queries
	- Data without relationships
### Document Databases
- Foundation is a document, not a record
- Format usually JSON
	- XML or BSON possible
- Document will self-describe, no schema required as in SQL
- Not every document has to adhere to the same schema
- Query language to retrieve and search data
- When to use it?
	- Real-time analytics data
	- IoT application
	- Web apps
	- Backend API's
### Column Store
- Data storage will not occur on records but on columns
- Much faster for complex queries
- Frequently used in data analysis systems
### Graph Database
- Storage of entities and relationships between different entities
- Entity is kind of node with properties
- Relationship contains properties
- Power lies in relationships you establish between entities
- When to use it?
	- Social networking apps
	- Spatial data apps
	- Routing apps
## From SQL to NoSQL Example
**SQL Example**
![[Pasted image 20231125190236.png]]
- Normalization can be hard
- New things will come up
	- Adjust schema again
- Data is scattered throughout database
- Complex Select and Join operations needed

**NoSQL Example**
![[Pasted image 20231125190335.png]]
- Record will become document
- Easily apply new fields
- Format: JSON
- Data as JSON in database
- No need to read data and build INSERT queries
- Drawback: Duplicate data, no relationships
## CosmosDB
**Why?**
- Managed service on Azure
- No maintencance
- No patching
- Easy to set up
- Pay as you use
- Powerful APIs (Multi-Model Database)
	- Document DB API
	- MongoDB API
	- Gremlin API
	- ...
- Globally distributed database
	- Easily bring data as close to customer as possible
	- Simple activation in data center near user
- Unlimited scalability
	- Data throughput
- Low latency
- SLA of 99.99% in one region, multiple regions = higher SLA

**CosmosDB API**
- Cosmos DB Account
	- Database
	- Group that contains multiple containers
	- Container == Table in SQL
	- Contains a collection of different JSON documents
	- Item == Record in SQL
![[Pasted image 20231125190857.png]]
- API: We use SQL API
- Capacity mode: Serverless, only pay for what we use
- Non-production for testing
- Unique Database name
- Unique container name (similar to table)
- Partition key (similar concept to table storage)
- Add data manually
![[Pasted image 20231125191104.png]]
- Firewall
![[Pasted image 20231125191134.png]]
**Connect to Azure Cosmos DB from Azure Functions**
*Step 1: Establishing  connection with CosmosDB*
- Create a CosmosClient object with parameters from local.settings.json
- Provide the connection string
- Managed Identity is also available
- Set ConnetionMode to Gateway
```
CosmosClientOptions clientOptions = new CosmosClientOptions();
clientOptions.ConnectionMode = Microsoft.Azure.Cosmos.ConnectionMode.Gateway;
cosmosClient = new CosmosClient(Environment.GetEnvironmentVariable("CosmosConnectionString"), clientOptions);
```
*Step 2: Data Model we want to persist*
- Using [JsonProperty] to obtain a lowercase property in the database
- Provide a unique 'Id' property
- Ensure that the "PartitionKey" is also present in the model
```
public class TemperatureLog
{
	[JsonProperty("deviceid")]
	public string DeviceId { get; set; }
	[JsonProperty("temperature")]
	public int Temperatuur { get; set; }
	[JsonProperty("id")]
	public string Id { get; set; }
}
```
*Step 3: Deserialization*
- Already familiar
```
string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
var tempLog = JsonConvert.DeserializeObject<TemperatureLog>(requestBody);
```
*Step 4 : Writing to the database*
- Retrieve the database and the desired container
- Fill in the "Id" with a unique value
- Call CreateItemAsync with the model
```
Database database = cosmosClient.GetDatabase("lesdb");
Container container = database.GetContainer("logs");
tempLog.Id = Guid.NewGuid().ToString();
var todoItemResponse = await container.CreateItemAsync<TemperatureLog>(tempLog, new PartitionKey(tempLog.DeviceId));
```
*Step 5: View data in the Azure Portal*
![[Pasted image 20231128144050.png]]
*When querying data, there are additional options available through SQL queries*
```
QueryDefinition query = new QueryDefinition("SELECT * FROM logs f WHERE f.temperature < @maxtemp*").WithParameter("@maxtemp", maxTemp);

List<TemperatureLog> results = new List<TemperatureLog>();
FeedIterator<TemperatureLog> resultSetIterator = container.GetItemQueryIterator<TemperatureLog>(query, requestOptions: new QueryRequestOptions() { PartitionKey = new PartitionKey(deviceId) });
while (resultSetIterator.HasMoreResults)
{
	FeedResponse<TemperatureLog> response = await resultSetIterator.ReadNextAsync();
	results.AddRange(rresponse);,
	if (response.Diagnostics != null)
	{
		Console.WriteLine($"\nQueryWithSqlParameters Diagnostics: {response.Diagnostics.ToString()}");
	}
}
```
### CosmosDB Extra's
- Azure Search
	- Powerful search engine on top of CosmosDB 
	- Text search
	- Indexing
- Azure Functions
- CosmosDB Trigger
	- Upon adding documents => function activation
- Time To Live
	- Automatic removal of items after a specified time
	- Container level
	- Item level
- Stored Procedures:
	- Functions within the database
	- Writing complex queries
	- Working at the collection level
	- Invokable through API or portal
	- JS
- UDF
	- Functions called from queries
	- E.g.: performing calculations
	- JS
```
var taxUdf = 
{
	id: "tax",
	serverScript: function tax(income)
	{
		if (income == undefined)
			throw 'no input';

		if (income < 1000)
			return income * 0.1;
		else if (income < 1000)
			return income * 0.2;
		else 
			return income * 0.4;
	}
}

var query = 'SELECT * FROM TaxPayers t WHERE udf.tax(t.income) > 20000';
```

## Data Mo deling
### 2 Extremes
![[Pasted image 20231129133014.png]]
![[Pasted image 20231129133028.png]]
### Contoso Restaurant Menu
*Relational modelling:*
- Each menu item has a reference to a category
![[Pasted image 20231129133051.png]]
*Non-relational modeling:*
- Each menu item is a self-contained document
```
{
	"ID": 1,
	"ItemName": "hamburger",
	"ItemDescription": "cheeseburger, no cheese",
	"Category": 
	{
		"Name": "sandwiches",
		"Description": "2 pieces of bread + filling"
	}
}
```
### Embedding vs Referencing
*Embedding:*
```
{
	"menuID": 1,
	"menuName": "Lunch menu",
	"items": [
		{"ID": 1, "ItemName": "hamburger", "ItemDescription":...}
		{"ID": 2, "ItemName": "cheeseburger", "ItemDescription":...}
	]
}
```
*Referencing:*
```
{
	"menuID": 1,
	"menuName": "Lunch menu",
	"items": [
		{"ID": 1}
		{"ID": 2}
	]
}
{
	{"ID": 1, "ItemName": “hamburger", "ItemDescription":...}
	{"ID": 2, "ItemName": “cheeseburger", "ItemDescription":...}
}
```
#### When to embed (examples)
##### When to embed #1
- Data that is queried together, should live together
- E.g.: In a recipe, ingredients are always queried with the item
```
{
	"ID": 1,
	"ItemName": "hamburger",
	"ItemDescription": "cheeseburger, no cheese",
	"Category": "sandwiches",
	"CategoryDescription": "2 pieces of bread + filling",
	"Ingredients": [
		{"ItemName": "bread", "calorieCount": 100, "Qty": "2 slices"},
		{"ItemName": "lettuce", "calorieCount": 10, "Qty": "1 slice"}
		{"ItemName": "tomato","calorieCount": 10, "Qty": "1 slice"}
		{"ItemName": "patty", "calorieCount": 700, "Qty": "1"}
}
```
##### When to embed #2
- Child data is dependent on a parent
- E.g.: Items ordered depends on order
```
{
	"id": "Order1",
	"customer": "Customer1",
	"orderDate": "2018-09-26",
	"itemsOrdered": [
		{"ID": 1, "ItemName": "hamburger", "Price":9.50, "Qty": 1}
		{"ID": 2, "ItemName": "cheeseburger", "Price":9.50, "Qty": 499}
	]
}
```
##### When to embed #3
- 1:1 relationship
- E.g.: All customers have email, phone, loyalty number...
```
{
	"id": "1",
	"name": "Alice",
	"email": "alice@contoso.com",
	“phone": “555-5555"
	“loyaltyNumber": 13838359,
	"addresses": [
		{"street": "1 Contoso Way", "city": "Seattle"},
		{"street": "15 Fabrikam Lane", "city": "Orlando"}
	]
}
```
##### When to embed #4, #5
- Similar rate of updates
	- Does the data change at the same screen
- 1:few relationships
- E.g.: Emails or addresses don't change too often (see [[#When to embed 3]])
#### When to reference (Examples)
##### When to reference #1
- 1:many (unbounded relationship)
```
// Person
{
	"id": "1",
	"name": "Alice",
	"email": "alice@contoso.com",
	"Orders": ["Order1",..“Order100"]
}

// Orders
{
	"id": "Order1",
	"orderDate": "2018-09-18",
	"itemsOrdered": [
		{"ID": 2, “Name": "cheeseburger", "Price":9.50, "Qty": 499}]
},
...
{
	"id": “Order100",
	"orderDate": "2018-09-20",
	"itemsOrdered": [
		{"ID": 1, “Name": "hamburger", "Price":9.50, "Qty": 1}]
}
```
##### When to reference #2
- many:many relationships
- Here, session is referenced by speakers and attendees
	- This allows you to update Session independently
```
{
	"id": "session1",
	"name": "Modelling Data 101",
	"speakers":[
		{"id": "speaker1"},
		{"id": "speaker2"}
	]
}

{
	"id": "speaker1",
	"name": "Alice",
	"email": "alice@contoso.com",
	"sessions":[
		{"id": "session1"},
		{"id": "session2"}
	]
},
{
	"id": “attendee1",
	"name": “Eve",
	"email": “eve@contoso.com",
	“bookmarkedSessions":[
		{"id": "session1"},
		{"id": "session4"}
	]
}
```
## CosmosDB API
- Important concept: Partition Key
- Make a choice in advance, cannot be changed later
- Data with the same partition key will be stored together
- Consider how you will retrieve data later:
	- For Users, customerId?
	- For Orders, orderId or customerId?
- Selecting wrong partitionkey: costly
	- Avoid cross-partition calls
		- (retrieving data from different partitions)
- Use partition key in query for effeciency
## Extra's
- https://www.youtube.com/watch?v=7mOJifoKxvQ
- https://learn.microsoft.com/en-us/azure/cosmos-db/emulator?tabs=ssl-netstd21
- https://learn.microsoft.com/en-us/azure/cosmos-db/emulator?tabs=ssl-netstd21
## What is important for this chapter
- SQL vs NoSQL
- Why and when NoSQL
- What types of NoSQL are there
- Know how to read and write CosmosDB
- Model databases
# 7 IoT Hub
## Internet of Things (examples and basic knowledge)
- Connecting hardware
	- Connect device to the internet
		- Sending information to the cloud
		- Devices communicate with eachother
			- M2M
	- Communication from/to device
		- We can send messages to the device
		- We receive messages from the device in the cloud
- Sensors & Devices
	- Important component to capture live info from environment
	- Can be very simple (temperature)
	- Can be complex (video stream)
- Connectivity
	- Sending the collected data via a network to a cloud environment
	- Two types of communication
		- LAN
		- WAN
- Data Processing
	- When data arrives in the cloud, store it on
		- Blob, Cosmos, SQL, ...
	- Processing
		- Check temperature and then take action (simple)
		- Detect objects in a video (complex)
- User Interface
	- Show device info, send commands
	- Mobile app
- Smart home
	- Thermostats, camera's, speakers, ...
- Connected cars
	- Start heating remote, open/close trunk
## Advantages of IoT implementations
- Monitoring of business processes
- Save money and time
- Increase productivity
- Make better decisions based on the data
## Disadvantages
- additional complexity within the network
- Security must be in order
## Challenges
- Updating hardware (firmware)
- Security
- Privacy
- Increasing complexity of the software
- Ability to process the amount of data
## IoT Hub

> Azure IoT Hub is a fully managed service that enables reliable and secure bidirectional communications between millions of IoT devices and a solution back end

- Managed service:
	- we don't need to install anything in the cloud, just create the service
- Bi-directional Communication
- Millions of devices
- Support for multiple languages
	- C#, Python, C, Node
- HTPPS, AMQP, MQTT protocol support
- Sending telemetry data => Device 2 Cloud
- Receiving commands => Cloud 2 Device
- Management of devices via [[IoT Hub Digital Twin]]
- Queries on devices
- End-to-end security
- Certificaten per device
- TLS support 
- X,509 support
- IP white-/blacklisting van devices
- Firmware/software update support (basic)
### What if device not powerful enough
- Arduino, Mbed Cortex M0, ... (leaf device)
- Inexpensive, but not always directly possible to connect to the internet
- Solution: Field Gateway
	- Can be Raspberry Pi, but also an industrial PC
- Powerful enough to communicate securely with the internet
	- Field Gateway will talk locally to the less powerful device via CoAP, Bluetooth, AllJoyn, ...
![[Pasted image 20231129142210.png]]
![[Pasted image 20231129142228.png]]
## Process data that comes in on IoT Hub
- Streaming Analytics
- Message Queues
- Azure Functions
	- Receiving messages
	- Sending messages (command) to IoT Hub
![[Pasted image 20231129150354.png]]
## [[IoT Hub Digital Twin]]

> Problem: We have 10000 devices connected to Azure IoT Hub. These devices control a motor. The number of RPMs is fixed in the script at 5000. We want to send adjustments to 5000 devices. How???

**Solution: IoT Hub Device Twin**
- Desired Property
- Digital "twin" of the device in the cloud
- Ideal for sending configuration to a device
- Configuration will be saved
	- In the cloud (iot hub)
	- On the device (dev must do this is  Python/.NET)
	- E.g.: we only want to log temp above a certain value
		- Setting threshold in device properties
![[Pasted image 20231129150713.png]]
```
{
// General info, don't change //
    "deviceId": "deva",
    "etag": "AAAAAAAAc=",
    "status": "enagled",
    "statusReason": "provisioned",
    "statusUpdateTime": "0001-01-01T00:00:00",
    "connectionState": "connected",
    "lastActivityTime": "0001-01-01T00:00:00",
    "cloudToDeviceMessageCount": 0,
    "authenticationType": "sas",
    "x509Thumbprint": {
        "primaryThumbprint": null,
        "secondaryThumbprint": null
    },
    "version": 1,
    "tags": {
        "$etag": "123",
        "deploymentLocation": {
            "building": "43",
            "floor": "2"
        }
    },
// Properties to be requested from the device //
    "properties": {
        "desired": {
            "telemetryConfig": {
                "sendFrequency": "5m"
            },
            "$metadata": {},
            "$version": 1
        },
// Properties to report to the cloud //
        "reported": {
            "telemetryConfig": {
                "sendFrequency": "5m",
                "status": "success"
            },
            "batteryLevel": 55,
            "$metadata": {},
            "$version": 4
        }
    }
}
```

> Next problem: We want to restart a device

**Solution: IoT Hub Device Twin**
- Device Methods
	- Activate methods on the device remotely
	- Start Python/.NET method remotely
	- E.g.: reboot device
		- Activate method via portal
		- Activate method via C#
		- Sending parameters is possible
		- You can also send messages C2D
![[Pasted image 20231129152105.png]]

> Next problem: I want all devices with a battery status of 10%

**Solution: IoT Hub Device Twin**
- Reporting Properties
	- Device can report to the cloud
		- Battery status
		- Device status
		- Last device upload to cloud
		- ...
- Saving device info in a JSON document
- Queries possible
	- SELECT all devices where battery status < 10%
![[Pasted image 20231129152302.png]]
- IoT Hub Trigger for Azure Functions
- Specify the connection string from local settings
- Path -> leave as default
- Data is an array of bytes so convert to string (JSON)
![[Pasted image 20231129152350.png]]
## IoT Edge
- IoT Hub issues:
	- Everything must go to the cloud for processing, nothing local
		- lot of data traffic
	- We are dependent on the internet
	- It's difficult to update scripts on a device
	- Script sometimes requires libraries on devices
		- Install problem
	- Version management = challenge
	- Some data not to cloud
- Service on top of IoT Hub
- Main objective:
	- Run cloud workloads locally
	- Do the initial filtering of data on device
	- Do not forward everything to cloud
	- Offline scenario
	- Reduce cloud cost
	- Easily update IoT Edge Device
- Examples:
	- Photo analysis on IoT Edge
		- Don't need to send photo to cloud for analysis
	- Filtering of data on Edge device
	- Local data storage
![[Pasted image 20231129152840.png]]
- IoT Edge Runtime
	- Runs on raspberry pi or pc
	- Installation of workloads  & update on device
	- Securing edge communication
	- Responsible for running the modules
	- Report status health to cloud for remote monitoring
	- Will take care of communication with leave devices
	- Ensures communication between IoT Edge and modules on the device
	- Ensures communication between IoT Edge and cloud
- Modules
	- Adding functionality on the Edge
	- Each module will perform an action
	- We link modules to eachother as a data processing pipeline
	- Write modules in Python, C#, ...
	- Modules are Docker Containers
	- E.g.: a module that filters data before sending it to the cloud
	- E.g.: a module that converts data from XML to JSON before sending it to the cloud
![[Pasted image 20231129153150.png]]
## Cloud vs Edge
### Cloud
- Remote monitoring and control
- Merging remote data from across multiple IoT devices
- Near infinite compute and storage to train machine learning and other AI tools
### Edge
- Low latency tight control loops require near real-time response
- Public internet = unpredictable
- Privacy of data and protection of IP
## Important from this chapter
- What and why IoT
- What and why IoT Hub
- What are digital twins in IoT Hub and what are the advantages
- What are direct methods and when do we use them
- What is IoT Edge
- When do we use IoT Edge or IoT Hub
