# 0 Doel

- Netwerken / netwerkinfrastructuur
- Besturingssystemen: Windows / Linux
- Security
- Reverse Engineering
- Embedded systems / RTOS / Embedded Linux
  - RTOS = Real Time Operating System
    - An RTOS is an operating system with 2 key features
      1. Predictability
      2. Determinism
    - An RTOS is a type of operating system, but it is vastly different from the kind most consumers are familiar with. Operating systems in phones or personal computers are, comparatively, bloated with apps and features; they must be able to support anything the user might want to do today. An RTOS, on the other hand, is streamlined, meant to execute its tasks quickly and effectively. It is a fraction of the size, sometimes only a few megabytes (vs. more than 20 gigabytes), with a simple graphical interface, and it lacks many familiar features, such as a web browser.
- Elektronica
- HF Technology (ON4DFE)
  - High Frequency Technology

## Doel

- Security Awareness
- Correcte nomenclatuur
- Advies over verantwoordelijkheden
- Inzien v/d consequenties v/h falen van security
- Situeren en herkennen van problemen
- Oplossingen correct implementeren
- Correcte methodieken toepassen

## Evaluatie

Examen over:

- Concepten en nomenclatuur
- Werking van beveiligingstechnologieën
- Kennis van best-practices
- In staat zijn tot het identificeren van problemen
- In staat zijn om verdedigbare tegenmaatregelen te kiezen en correct te implementeren

# 1 Intro

## Introductie

- Niet iedereen heeft even goede bedoelingen
- Veel mensen = Veel potentiële slachtoffers
- Internet:
  - Meer mensen
  - Makkelijk bereikbaar
- Geen magische oplossing
- Vertantwoordelijkheid van iedereen
- Tegenmaatregelen nemen
  - Zijn slechts nuttig indien ze effectief gebruikt worden
  - Lijk vaak in de weg te zitten of lastig, maar noodzakelijk
- Alert en voorzichtig zijn

## Risico

- Bedreiging
- Kwetsbaarheid
- Tegenmaatregelen
  - Reduceren v/d kwetsbaarheid

## Frameworks en Modellen

- CIA - Triad
- NIST CSF
- Lockheed Martin Cyber Kill Chain
- People Process Technology
- ISO/IEC 27001 ISMS

### CIA - Model

![[Pasted image 20231029163924.png]]

- **Confidentiality**:
  - Ensuring that information is only accessible to those who have the proper authorization or clearance.
- **Integrity**:
  - Guaranteeing the accuracy and reliability of data and systems, protecting them from unauthorized alterations or tampering.
- **Availability**:
  - Making sure that information and resources are consistently accessible and usable when needed, and resilient to disruptions or attacks. The CIA Triad is a fundamental framework for information security.

### NIST CSF

![[Pasted image 20231029162705.png]]

- National Institute of Standards and Technology Cybersecurity Framework
- A voluntary framework created by the U.S. government to help organizations manage and reduce cybersecurity risk.
- It provides guidelines, best practices, and a common language for organizations to improving their cybersecurity posture.
- The framework is divided into 5 core functions:

1. Identify
2. Protect
3. Detect
4. Respond
5. Recover

### Lockheed Martin Cyber Kill Chain

![[Pasted image 20231029162748.png]]

- A model that describes the stages of a cyberattack from the perspective of a defender:
  1. Reconnaissance
  2. Weaponization
  3. Delivery
  4. Exploitation
  5. Installation
  6. Command & Control
  7. Actions on Objectives
- The goal is to understand and disrupt the attacker's actions at various points in this 'kill chain'

### People - Process - Technology

![[Pasted image 20231029163027.png]]

- This concept recognizes that effective cybersecurity and information security involve more than just technology
- 3 elements:
  1. People:
     - The human factor, including training, awareness, and the roles and responsibilities of individuals in an organization
  2. Process:
     - The procedures, policies, and best practices that guide how an organization manages and protects its information assets
  3. Technology:
     - The tools, hardware, and software used to implement security measures and protect data

### ISO/IEC 27001 ISMS

- Information Security Management system
- A globally recognized standard for information security management
- It provides a systematic approach to managing sensitive information, ensuring its confidentiality, integrity and availability.
- An ISMS based on ISO/IEC 27001 helps organizations establish and maintain effective information security controls, assess risks, and comply with legal and regulatory requirements. It is a widely adopted framework for information security.

## Bedreiging / Kwetsbaarheid

- Thread
- Vulnerability

### Bedreigde doelen

- Infrastructuur
- Gegevens
- Operationaliteit
  ![[Pasted image 20231029163647.png]]

## Risico

- De mate van bedreiging is niet beheersbaar
- De kwetsbaarheid is te reduceren door implementatie van _tegenmaatregelen_
  ![[Pasted image 20231029163747.png]]
- Bedrijfsimpact van het risico bepaalt de opportuniteit van de beveiligingsinvestering
- Bepalen v/d financiële impact v/e incident is uitermate bedrijfsspecifiek

## Extra Te Lezen

![[Gaining_the_Advantage_Cyber_Kill_Chain.pdf]]
![[NIST.CSWP.04162018.pdf]]

# 2 Threats Risk

## Threats

- Vallen 1 of meerdere 'doelen' aan
- Kunnen zijn:
  - Toevallig
  - Kwaadwillig
- Gaan uit van:
  - Agenten (personen of organisaties)
  - Gebeurtenissen
- Systeemfouten
- Gebeurtenissen
  - Bv.: Brand, Stroomuitval, ...
- Intern
  - Bv.: Diefstal, Wraak, ...
- Extern
  - Bv.: Hackers, Spionage, ...

### Phising

- Fraud
- Personal information
- Impersonation
- Authentication
- Oplichting over email
  - Vaak onwaarschijnlijk verhaal
  - Herkenbaar aan malafide links
  - Soms bijzonder moeilijk herkenbaar
- Meest voorkomende vorm van fraude
- Meest uitgebuite kwetsbaarheid v/e organisatie
- Spear phishing:
  - A highly targeted form of cyberattack in which hackers send personalized and deceptive emails to specific individuals or organizations, posing as trusted sources.
  - It relies on social engineering and extensive research to exploit trust and trick the target into revealing sensitive information or taking harmful actions.
- Double Barrel Attack
  - Double barrel phishing is a [phishing tactic](https://www.privacysense.net/terms/phishing/) that involves two or several emails where the objective is to establish trust and authenticity so the victim is less likely to doubt or [question the attacker](https://www.itsecurityawareness.ie/glossary/double-barrel-attack).
- Examples:
  - Bank card phishing
  - CEO-fraude
  - Factuurfraude

#### Smishing

- Phishing via sms, whatsapp, ...

#### Vishing

- Telefonish Phishing (bellen)

#### Money Mules

![[Pasted image 20231029165812.png]]

## Malware

### Ransomware

- maakt data op PC onbruikbaar
- Enige fix: BACKUP
  ![[Pasted image 20231029165934.png]]

### Trojan Horse

- A type of malicious software (malware) that disguises itself as a legitimate or useful program but, when executed, carries out harmful actions without the user's knowledge or consent.
- It can steal information, damage the system, or provide unauthorized access to a computer or network.

### Spyware

- Malicious software designed to secretly collect information from a computer or device, including keystrokes, browsing habits, personal data, or other sensitive information.
- This data is typically sent to a remote server without the user's consent, often for malicious purposes, such as identity theft or targeted advertising.

### Viruses & Worms

1. **Viruses**:
   - **Definition**: A computer virus is a type of malware that attaches itself to a legitimate program or file, often spread through infected files or software downloads. When the infected program is executed, the virus replicates and can infect other files and programs on the same computer.
   - **Spreading**: Viruses typically require user interaction, such as opening an infected email attachment or running an infected application.
   - **Damage**: Viruses can corrupt data, compromise system performance, and may have malicious payloads, such as deleting files or causing other harmful actions.
2. **Worms**:
   - **Definition**: A computer worm is a standalone self-replicating program that doesn't need to attach itself to another program. Worms spread across networks and systems, exploiting vulnerabilities, and can do so without user intervention.
   - **Spreading**: Worms can spread rapidly and autonomously, often taking advantage of security weaknesses or vulnerabilities in computer networks.
   - **Damage**: Worms can congest networks, disrupt services, and may carry malicious payloads, including data theft, file deletion, or other harmful actions.

In summary, viruses attach themselves to legitimate programs and require user interaction to spread, while worms are self-replicating and spread across networks, often without user interaction. Both can cause significant damage to computer systems and networks.

## Hardware Threats

### Keyloggers

- Hardware devices that record and log every keystroke made on a computer or mobile device. They can capture keyboard inputs, including text, usernames, passwords, and other sensitive information.
- Keyloggers are often used for both legitimate purposes, such as monitoring computer usage by parents or employers, and malicious purposes, such as stealing login credentials or other confidential data.
- Malicious keyloggers are a type of spyware and can be a significant threat to privacy and security.

### Rubber Ducky

- A small USB device that emulates a keyboard.
- It's often used for legitimate purposes in IT and cybersecurity for tasks like automating keystrokes and scripting.
- However, it can also be used for malicious purposes, as it can rapidly input predefined keystrokes, potentially exploiting vulnerabilities or executing harmful commands on a computer, all while appearing as a regular USB drive.

### USB Killer

- A malicious device designed to physically damage computers and electronic devices that are vulnerable to electrical surges.
- When connected to a USB port, it delivers a high-voltage surge, effectively "killing" the device by damaging its internal components.
- USB Killers are not intended for legitimate purposes and are often used in cyberattacks or acts of vandalism.
- They can cause irreversible damage to the targeted devices, rendering them inoperable.

### O.MG Cable

- A type of USB cable that can be used for malicious purposes.
- It appears like a regular USB cable, making it inconspicuous.
- However, it contains embedded hardware designed to perform malicious activities when connected to a computer.
- O.MG cables can be used for unauthorized data exfiltration, keyboard emulation, or other potentially harmful actions.
- They highlight the importance of inspecting USB devices for security and authenticity to prevent potential threats.

### Evil Twin Access Point

- A malicious wireless access point that masquerades as a legitimate and trusted Wi-Fi network.
- It lures users into connecting to it by appearing with a name or SSID (Service Set Identifier) similar to a nearby, known network.
- Once connected, it can intercept and monitor the user's network traffic, potentially capturing sensitive information.
- The attacker can use the gathered data for malicious purposes, such as identity theft or eavesdropping.
- To protect against Evil Twin attacks, users should be cautious when connecting to public Wi-Fi networks and confirm the network's legitimacy.

### Network Implant

- A hardware device used for covert purposes within a network.
- It may be employed for surveillance, data exfiltration, or remote control of a network.
- These hardware implants are designed to remain hidden while collecting information, monitoring communications, or performing specific tasks within the compromised network.
- They can take the form of small physical devices or components that are surreptitiously inserted into the network infrastructure.
- Detection and removal of hardware-based network implants can be challenging, making them a significant cybersecurity concern.

### Social Engineering

- A manipulation technique used to deceive individuals into divulging confidential information or performing actions that compromise security.
- It exploits psychological and emotional factors to gain the trust and cooperation of the target.
- Common forms of social engineering include phishing, pretexting, baiting, and tailgating.
- Targets can include individuals, employees, or even organizations, and the attackers often impersonate trusted entities to achieve their objectives.
- Vigilance, awareness, and security training are essential for preventing and mitigating social engineering attacks.

## Bedreigingen "Agenten"

- Entiteiten waarvan de bedreiging uitgaat
- In- of Extern aan het bedrijf
- Kwetsbaarheid voor een agent wordt bepaald door:

  - toegangsniveau
  - kennis
  - motivatie

- "De ontslagen werknemer"

  - heeft (nog steeds) toegang tot de organisatie
  - heeft kennis over werking v/d organisatie
  - heeft sterke negatieve motivatie

- "De Hacker"

  - blueprint opgevoerd door media
  - gebaseerd op reële figuren
  - vormt een rolmodel voor bepaalde subcultuur
  - hacker vs cracker
    - script kiddies / wannabee
  - L337 h4xOr 700I$ (Leet Hacker Tools)
  - bedreiging door grote aantallen
  - Hackers met veel kennis
  - hacker "ethics"
    - **Black Hat**:
      - Black Hat refers to malicious hackers or cybercriminals who engage in illegal and unethical activities, such as hacking for personal gain, stealing data, spreading malware, or causing harm to systems or networks.
    - **White Hat**:
      - White Hat denotes ethical hackers and cybersecurity professionals who use their skills to protect systems, networks, and data. They work to uncover vulnerabilities, perform security assessments, and help organizations secure their digital assets.
    - **Gray Hat**:
      - Gray Hat hackers operate in a middle ground between black hat and white hat hackers. They may engage in activities that could be considered illegal but claim to do so in pursuit of security research or to expose vulnerabilities. Their intentions may not always be clear-cut.
  - Ethical hacker
    - goed of slecht voor security
      - security by obscurity
        - vele malen slecht idee gebleken
      - Penetration testing
        - verificatie van beveiliging
        - ongevraagd?
      - Bug Bounty program
        - security-contacts / disclosure programma's van firma zelf
    - bottom line: a fine line / grijze zone

- "Gebeurtenissen"

  - Brand, stroomuitval, overstroming, diefstal, ...

## Threat Intelligence

- Know your enemy
- Noodzakelijk om risico in te schatten
- Bijgevolg elementair om te beslissen over opportuniteit van **_tegenmaatregelen_**

# 3 Vulnerability

## Software Vulnerabilities

- Logical errors
- Programming mistakes
- Lacking QA (quality assurance)
- Vulnerabilities in external libraries

## Technological Evolution

    - Today's technology is the best
    - It is broken

- MiTM Attack
  - Man in The Middle Attack
- Oversharing on social media
- Metadata
  - Files may contain extra information
- Wireless devices
  - Wireless protocols contain vulnerabilities too
  - Easy to exploit from a distance
- Unsafe links
  - Homoglyphs
    ![[Pasted image 20231030153519.png]]
- Baseless trust in HTTPS
- Cloud Services
  - Usage of multiple cloud services can leak confidential information
- Mobile devices
  - everything eventually breaks
- Data retention
- Future crime

## Countermeasures

### Risk coping strategies

- risk acceptance
- risk avoidance
- risk mitigation
- risk transferance
- ignore it
  => Risk management

### Usability / Security Tradeoff

"in any implementation of security controls all three factors - Security, Functionality and Ease of Use, are to be carefully considered; searching for the balanced trade-off for all stakeholders."

### End-to-end encryption

- encrypt all data in transit
- certificates can provide a level of trust

### Backups

- 3 copies
  - Original + 2 copies
- 2 different formats
  - In case one fails
- 1 off site
  - One copy is safe in a disaster

### Software updates

### System Security Tools

- Firewall
- Anti-virus
- Commercial software is not necessarily better
- these can be vulnerable too

### Authentication =/= Authorization

- Authentication:
  - confirms users are who they say they are
  - factors:
    - Something you know
      - Password
        - must be "strong"
        - strength = entropy
        - entropy = length
        - No longer considered secure
          - no password is secure
          - can be phised
          - social engineerd
          - logged
      - PIN code
      - Swipe pattern
    - Something you have
    - Something you are
- Authorization
  - Gives users permission to access a resource
- Multi Factor Authentication
  - phones as second factor are a bad idea
  - FIDO U2F
  - Third party authentication
    - OAuth
    - Ofter more secure
    - Also, social engineering risk

### Physical security

- Storage encryption
- Mitigation against data leaks
  - all data that is available will leak
    - no system ever conceived has proven to be secure
    - once leaked or compromised, data remains in the open

### Awareness

- most important countermeasure is user awareness of the threats

# 4 Access

## Beveiligen van toegang

### Wachtwoorden

- meest gebruikte vorm van authenticatie
- moet sterk zijn
  - 12 tekens
  - verschillende soorten tekens
  - geen bestaande woorden of logische sequenties
- Vaak gebruikte wachtwoorden zijn gekent
  - enorme lijsten beschikbaar
- Mijd hergebruik
- Wijzig regelmatig
- Leen nooit uit
- Gebruik 2FA
- Wachtwoordkluis

### Beveiliging op hebben-basis

- Smartcard
- Dongle
- Transponder
- Digipass
- Google authenticator
- RSA SecurID

### Beveiliging op zijn-basis

- Iris scanner
- Vingerafdruk
- Stem

### Combinatie

- Verhoogt veiligheid
- bij voorkeur methodes op verschillende werkingsbasis

## SSO Sytems

- Single Sign-On
  - Google, Facebook, ...
- SAML
  - Security Access Markup Language
  - Exchange of identification information
- OAuth
  - Open Authorization
  - Encrypted exchange of identification information
- OIDC
  - OpenID Connect
  - Extension of OAuth 2.0
  - Allow single session across multiple applications

## Fysische toegang

- Onvergrendelde scharmen
- Toegangscontrole serverroom
- Hardware aanpassingen of diefstal
  - Asset Management software
- Toegang tot het netwerk
- Introductie van vreemde software
- Opstarten vanaf andere media

## Privilege Escalation

- Zichzelf een ander gebruikersniveau
- Horizontale escalation
  - Session hijacking van een andere gebruiker
- Verticale escalation
  - Meer machtigingen verwerven

# 5 Frameworks

## Regels

- Vermijd security incidenten zo veel mogelijk

## Enforcement vs Policies

### Enforcement

- Technische maatregelen om dingen onmogelijk te maken of om dingen af te dwingen
- VB.:
  - Firewall blokkeert IP-adres, poortnummer
  - Wachtwoord moet 12 tekens zijn, ...
  - MFA verplicht, ...

### Policies

- Afspraken die beschrijven wat wel en niet mag
- BV.:
  - Elke dienst die vanaf internet bereikbaar is, mag enkel gebruik maken van versleuteld verkeer en moet beveiligd zijn met MFA
  - Elke 2 jaar moet een penetration test gebeurd

## Frameworks

- A supporting structure around which something can be built
- De ideëen, informatie en principes die de structuur vormen voor een organisatie of plan
- BV.:
  - In computer programming, a software framework is an abstraction in which software, providing generic functionality, can be slectively changed by additional user-written code, thus providing application-specific software
  - web framework:
    - ASP.NET Core
    - Vue.js
    - React.js
  - Security frameworks
    - ISO 27001
    - NIST CSF
      - National Institute of Standards an Technology Cyber Security Framework
    - CMMC
      - Cybersecurity Maturity Model Certification
    - SWIFT CSCF
      - Society for Worldwide Interbank Financial Telecommunication Customer Security Controls Framework
    - CIS CSC
      - Center for Internet Security Critical Security Controls
- Elk framework:
  - eigen invalshoek
  - eigen benaming
  - eigen weging
  - eigen nummering
  - eigen versies
  - eigen manier van compliance
  - Concepten zijn overal zeer gelijklopend
  - Ken je er één, dan ken je ze allemaal
  - Wij beperken ons tot NIST CSF
    •[https://www.nist.gov/cyberframework](https://www.nist.gov/cyberframework)
    •[https://en.wikipedia.org/wiki/NIST_Cybersecurity_Framework](https://en.wikipedia.org/wiki/NIST_Cybersecurity_Framework)

## Cyberincident

- Prevent - Detect - Respond
- NIST CSF
  - Prevent:
    - Identify
    - Protect
  - Detect
  - Respond:
    - Respond
    - Recover
      ![[Pasted image 20231030162308.png]]
- Safety vs Security

### Identify

- Identify function = fundering van cybersecurity programma
- "Je kan niet beveiligen wat je niet kent" => Asset Inventory
  - Hardware and Software asset inverntory
- Plaats in de supply chain kennen
- Spelregels bepalen in lijn met de risicos
- Kwetsbaarheden bepalen
- Bedreigingen identificeren
- Risico's identificeren

### Protect

- Identity Management & Access Control
  - Logische toegang
  - Fysieke toegang
  - Remote toegang
- Identity Management
  - Beheer:
    - Aanmaken
    - Wijzigen
    - Verwijderen
    - Periodiek controleren
  - Persoon wordt gekoppeld aan een "Identity"
  - kan 1 of meerdere rollen krijgen
  - rol krijgt rechten
- Security Awareness Training
- Technologie invoeren om Confidentiality, Integrity en Availability van info te beschermen
  - in lijn met risico strategie uit 'Identify'
- Processen en procedures invoeren om bescherming op peil te houden
- Onderhoud
- Goed beheer van technologie

### Detect

- Detecteer mogelijke security incidenten binnen aanvaardbare tijd
  - IBM Cost of Data Breach Report
    - Gemiddeld 212 dagen om breach te ontdekken
  - Verizon Data Breach Investigation Report (DBIR)
    - 60% within days
    - 20% months or more
- Hoe meer tijd tussen incident en detectie
  - hoe groter de impact
- Zorg dat je de impact kan bepalen
  - Asset Inventory
- Voorzie continue monitoring
  - People - Process - Technology
  - Network Intrusion Detection Systems (NIDS)
  - Host Intrusion Detection Systems (HIDS)
  - Security Incident and Event Management (SIEM)

### Respond

- PICERL
  - (Prepare)
    - Ken je risicos
    - weet wie je vijanden zijn
    - beschrijf wie je moet contacteren
    - zorg dat de betrokkenne op de hoogte zijn
    - oefen het Security Incident Response Plan
  - (Identify)
    - Gelijklpend aan "Detect" van NIST CSF, maar met toevoegingen
      - bepaal impact
      - zorg voor juiste afhandeling volgens impact
  - ==Contain==
    - Neem maatregelen om verdere schade te verhinderen
      - isoleer, schakel uit, zet machines af, ...
    - Denk aan "Forensic readiness"
  - ==Eradicate==
    - Stel nodig bewijsmateriaal veilig
    - verwijder alle processen die gelinkt zijn aan het incident
    - roei het uit
      - wis accounts, zet firewall poorten dicht, deny-regels, ...
    - Nog steeds downtime
  - (Recover)
  - (Lessons Learned)

### Recover

- Recover and Lessons Learned from PICERL
- Herinstalleer systemen
- restore van backup
- Herstel dienstverlening
- Root cause analysis + forensic analysis
  - hoe zijn ze binnen geraakt
  - wat is aangeraakt
- wat kunnen we eruit leren
- hoe vermijden in toekomst
- wat anders doen

# 6 Crypto

## Encryptie

- Geheimhouding
- Authenticatie
- Integriteit
- Nonrepudation
- Traditionele cryptografie
  - Subsitutie
  - Transpositie
  - One-time pad

## Symmetrische Encryptie

- Geheimhouding
- GEEN authenticatie
- Eenvoudig
- SNEL
- voorbeeld: DES (Data Encryption Standard)
  - Block-cipher van 64 bit
  - 16 encryptiecycli met telkens andere subkey
  - Bitlengte van sleutel is bepalend, 56bit = te laag
- Tripple DES, 2 of 3 sleutels
  - verhoogde veiligheid
  - kan in hardware
- AES / Rijndael
  - Advanced Encryption Standard
- IDEA
  - International Data Encryption Algorithm
- CAST-128
  - Carlisle Adams and Stafford Tavares
- Blowfish
  - variabele sleutellengte

## Assymetrische Encryptie

- Public key encryptie
  - RSA, ECC
- Geheimhouding
- Authenticatie
- Werkt met sleutelPAREN
  - private en publieke sleutel
- Zeer berekeningsintensief

## Hashing

- Message Digest
  - MD5, SHA2
- Variabele inputlengte
- Vaste outputlengte
- Kleine inputvariatie resulteert in grote outputvariatie
- Niet reversibel

## Diffie-Hellman Exchange

- Uitwisselen van een shared secret (key)
  ![[Pasted image 20231030170555.png]]
  ![[Pasted image 20231030170850.png]]

## PKI

- Public Key Infrastructure
  - Encryption of data in transit
    - Key exchange
  - Authentication of client
  - Authentication of server
  - Confidentiality
  - Integrity
- PKI - Certificates
  - Trusted root Certificate Authority (CA)
    - This is a solution
    - if and only if, CA can be trusted
      - provides an authenticated end-to-end secure channel
        - privacy
        - confidentiality
        - integrity
    - This is a problem
      - prevents use of for example: deep packet inspection
      - device and network security solutions
      - government surveillance
      - Compromise of CA
  - Server needs to be known and verified by CA
  - CA is trusted by all clients
  - Validity (date)
    - necessary
    - a problem (device, obsoleted, availability)
    - CA / Root certificate acceptance
  - Revocation
    - CRL ( certificate revocation list)
- PKI - Implementation
  - CA has public and private key
  - CA client has public and private key
  - public key of client is signed by CA
  - Certificated server is trusted by client as client trusts CA
- Signing
  - Assymetric Cryptography + Hashing = Signing
  - Content is hashed
  - hash is encrypted with private key of CA
  - hash value can be decrypted by anyone using public key of CA
  - certain that hash was authentic as only private key of CA could have encrypted hash that can be decrypted by public key of CA
  - content is hashed, hash is compared with decrypted hash value
    ![[Pasted image 20231030171715.png]]
- PKI - Procedure
  - Generate own public and private key
  - keep private key secure
  - Have public key signed by CA
    - Generate CSR ( Certificate Signing Request)
  - Publish public key signed by CA
    - ="Certificate"
      ![[Pasted image 20231030171853.png]]
      ![[Pasted image 20231030171923.png]]

## Certificate properties

- Serial number
  - Distinguishes certificate from others
- Algorithm information
  - issuer uses algorithm to sign certificate
- Issuer
  - name of CA
- Validity period
  - Start and end dates
- Subject distinguished name
  - Name of identity to which certificate is issued
- Subject public key info
  - public key associated with identity
    ![[Pasted image 20231030172137.png]]

## Crypto Algoritmes

- Shneier's Law:
  “Anyone, from the most clueless amateur to the best cryptographer, can create an algorithm that he himself can't break. It's not even hard. What is hard is creating an algorithm that no one else can break, even after years of analysis. And the only way to prove that is to subject the algorithm to years of analysis by the best cryptographers around.”
- •http://www.moserware.com/2009/09/stick-figure-guide-to-advanced.html

## Veilige websites

- HTTPS
  - veilige verbindingen (SSL)
- HTTP
  - onveilige verbindingen
- Ook kwaadwillige sites kunnen https gebruiken
- SSL beteknd dat gegevens niet kunnen worden afgeluisterd

### Praktisch gebruik

- SSL certificaten
- email versleutelen
- email afzender identificatie
- webistes
- API's
- gebruik steeds een correct algoritme voor de toepassing
- checksum <> hashing
- CRC is OK voor foutcontrole, niet voor authenticatie
- vb: check op rekeningnummers

# 7 Availability

- High availability op netwerkniveau
- High availability systemen
- Clusters
- Redundante servers
- Redundante server ruimte (disaster center)
- Virtualisatie

## Externe netwerk bedreigingen

### Denial of Service (DoS)

- E-mail bommen
- Repetitive login
- SYN-Flood
- UDP-flodding
- Ping of death

### Disitrubuted DoS (DDoS)

- DoS simultaan vanuit verschillende locaties
- Zeer moeilijk tegen te houden
- Meestal zijn de "drones" geïnfecteerde thuis-PC's
  ![[Pasted image 20231130152043.png]]

### Spoofing

> Vervalsen van informatie in de header

- IP Spoofing
- MAC Spoofing
- Email Spoofing
- ...

### Availability

- Uptime <> availability
- 99.9% = 3 nines = 8.76u/yr down
- 99.999% = 5 nines = 5.26min/yr down

# 8 Backup

- Essentieel voor het beschermen van data
- Concrete back-up policy
- Disaster recovery plan

## Eigenschappen van een correcte back-up

- Offline
- Beveiligd tegen aanpassing (integer)
- Betrouwbaar
- Beschikbaar (available)
- Veilig opgeslagen (confidential)

## 123 methode

![[Pasted image 20231130153255.png]]

## Back-up media

- Tape
- Harddisk
- USB-stick
- Cloud-backup
- RAID IS GEEN BACKUP

### LTO Tapes

![[Pasted image 20231130153110.png]]
![[Pasted image 20231130153117.png]]
![[Pasted image 20231130153121.png]]

## Cloud Back-up?

- Wat met aansprakelijkheid
- Wat met beschikbaarheid
- Wat met vertrouwelijkheid
  => Wetgeving?
- Wel zeer eenvoudig en gemakkelijk

## Back-up policy

- Back-up frequentie
- Back-up strategie
- Type back-up
- Opslag van back-up
  - Dicht bij server voor snelle toegang
  - Ver weg van server voor veiligheid
- Controle van integriteit back-up
- Testen van disaster-recovery plan
- Grootvader-vader-zoon systeem: [[GvVz]]
- Backup-rotatie
- Archivering
- Backup moet:
  - Actueel zijn
  - Voldoende teruggaan in de
- [[#CIA - Model]] over de gehele lijn
- Moet worden getest
- Moet effectief worden uitgevoerd

# 9 Web Security

- Belangrijke attack surface / point of entry
- Belangrijk naar reputatie
- CMS-systemen (wordpress, drupal, joomla, ...)
- SQL-injection
- Authenticatie / escalation
- Cross site scripting
- OWASP [https://www.owasp.org]

## Vaak voorkomende problemen

- SQL-injection
- Cookie stealing
- URL modification
- XXS (Cross site scripting)
- ...
  **Scannen:**
- Nessus, Nikto, OpenVAS
  **Testen:**
- OWASP Mantra, Burp
  **Risico's:**
- Defacement
- Lek van credentials
- Reputatie
- Diefstal
- Total PWN van alle servers & systemen

## Remediation

- Don't be stupid
- Sanitation LIB's (no DIY)
- Update site framework, plugins & libs
- Prepared statements
- Authenticatie frameworks

# 10 OT Security
## 1e Industriële Revolutie
- Stoommachine
- Ijzer en Staal
- Mechanisatie
- Fabrieken
## 2e Industriële Revolutie
- Staal
- Spoorwegen
- Elektriciteit
	- Radio, gloeilamp, ...
- Chemicaliën
- Massaproductie
## 3e Industriële Revolutie
- Computers
- Automatisatie
- Digitalisering
- Globalisering
- Internet
## 4e Industriële Revolutie
- Digitalisering
- Innovatieve technologie
- Snelle verandering en disruptie
- Ethiek en privacy
- Slimme systemen en connectiviteit
### STUXnet
> Stuxnet is een zeer geavanceerd computervirus en een van de meest complexe malware die bekend is geworden vanwege zijn gerichte aanval op industriële controlesystemen, met name op kerncentrales en nucleaire installaties. Het virus werd ontdekt in 2010 en wordt algemeen beschouwd als een van de eerste cyberwapens.

#### Kenmerken STUXnet
1. **Gerichte aanval:**
> Stuxnet was gericht op specifieke Siemens SCADA (Supervisory Control and Data Acquisition) systemen die worden gebruikt in industriële omgevingen, met een focus op Iran's nucleaire programma.

2. **Complexiteit:**
> Het virus was buitengewoon geavanceerd en complex, met meerdere zero-day kwetsbaarheden en exploits om systemen binnen te dringen zonder gedetecteerd te worden

3. **Modulaire structuur:**
> Stuxnet bestond uit verschillende modules, waaronder code om zichzelf te verspreiden via USB-dirves en LAD, en code om de controle van SCADA-systemen te manipuleren

4. **Specifieke doelen:**
> Het doel van Stuxnet was om centrifuges te verstoren die worden gebruikt voor de verrijking van uranium in Iran, waarbij de snelheid van deze centrifuges veranderede zonder dat de operators dat merkten

#### Voorbeelden
**DEC 2014: German Steelmill**
![[Pasted image 20231209103056.png]]
**MAR 2019: Cyber-attack on Hydro**
>*"It is still unclear how extensive the damage is from the cyber attack. According to the spokesperson, the comany's focus is now on ensuring staff safety."*

**JAN 2020: Picanol**
- General ransomware, presumably through China factory
- Worldwide IT systems and productions systems victim
- Impact: no production possible for more than a week
## IACS
### What is IACS
- Industrial Automation and Control Systems
- The collection of:
	- Sensors
	- Motors
	- PLC's (Programmable Logic Controllers)
	- Scanners
	- HMI's (Human Machine Interfaces)
- **OT = Operational Technology**
![[Pasted image 20231209104226.png]]
## Where is IACS used
![[Pasted image 20231209104327.png]]
![[Pasted image 20231209104337.png]]
![[Pasted image 20231209104348.png]]
![[Pasted image 20231209104400.png]]

## A risky story
*Imagine you live in Norway and are looking to buy a new car, lots of snow and ice. You could crash on the slippery road or you car could be snowed in*
- Better tires
- Assistance
- Insurance
- ...
![[Pasted image 20231209104516.png]]

## Why do cyber criminals do what they do?
- Almost always: MONEY
- 1,5 trillion $/yr
### Why now?
- OT+IT merging
- Attacks increasing
- Targeted malware against OT
- Legislation
- Business enabler

> The convergence of these factors has created a climate where cybercrime is not only profitable but also relatively easier to execute due to the increasing connectivity and dependence on digital systems. This makes cybersecurity a critical concern for individuals, businesses, and governments alike.

## What is OT security

> OT (Operational Technology) security refers to the practices, measures, and protocols designed to protect industrial control systems (ICS), critical infrastructure, and operational technology environments from cyber threats and vulnerabilities. OT systems are used in sectors like manufacturing, energy, transportation, and utilities to monitor and control physical devices and processes.

**Key aspects of OT security include:**
1. Securing Industrial Control Systems
2. Physical Security
3. Network Segmentation
4. Vulnerability Management
5. Incident Response and Recovery
6. Training and Awareness

> OT security measures often differ from traditional IT security due to the unique characteristics of industrial systems, such as legacy devices, longer operational lifecycles, and prioritization of safety and reliability over regular updates, which can pose challenges in maintaining security without disrupting operations. As OT and IT systems increasingly converge, the importance of robust OT security practices becomes even more crucial to protect critical infrastructure from cyber threats.

### Information Technology vs. Operational Technology (IT vs OT)
![[Pasted image 20231209105326.png]]
![[Pasted image 20231209105340.png]]
### How to cope with cyber risks in OT
**Balance between:**
- Extensive and thorough approach
- Pragmatic approach with best-practices

**4 phases in OT security improvement**
1. Assessment
	- What is the current situation and what must we improve
2. Development and Implementation
	- Define and prioritize tasks. 
	- Implement improvements
3. Maintenance
	- Make sure your earlier efforts don't go to waste
4. Continuous improvement
	- Kaizen (=Change for better in japanese)
	- Every experience is a learning experience
![[Pasted image 20231209105727.png]]

#### 1. Assessment
> *One cannot protect what one does not know*

1. Assemble team
2. Determine scope
3. Map the system
	- Architecture diagrams
	- Network diagrams
	- HW asset inventory
	- SW asset inventory
4. Vulnerability assessment
5. Create zones & conduits
6. Perform security risk assessment

#### 2. Development and Implementation
> Experience shows common steps. Independent from chosen approach (extensive <> pragmatic)

0. Separation between IT and OT
	- OT only reachable from IT in strictly-controlled way
	- Firewall, deny-by-default, allow-by-exception
1. Zones & Conduits
![[Pasted image 20231209110506.png]]
2. Asset inventory
	- *"Can this happen to us?"*
	- Start manually
	- Communicate usage
	- Automate
3. Do NOT use standard passwords
	- SCADAPASS
	- ABB
	- Beckhoff
	- Digi
	- eWon
	- ...
4. Secure Remote Access
	- IEC 62443
		- Asset owner
		- System integrator
		- Product supplier
	- Be careful with "industrial remote access" devices
	- Focus = functionality
	- Focus =/= security
	- Not secure-by-design
	- Can be secure, but requires effort and expertise
	- [[#Purdue Model]]
5. Patching
	- IT: security patch -> install quickly
		- Test environment / snapshot / backup / ...
		- Install
		- Reboot
	- OT: availability takes precedence
		- Only 1 machine of that kind
		- What if functionality breaks
		- Reboot = downtime = no go
	- Now - Next - Never strategy
		- Now : exposure is large
			- Install ASAP
		- Next : exposure is small
			- Plan for next maintenance window
		- Never : no exposure or unimportant
			- Never install
		- (This needs to be personalized)
#### Maintenance
*Gaat hij niet dieper op in*
#### Continuous Improvement
*Gaat hij niet dieper op in*

## Where to start
### 1 Asset Inventory
- Hardware verbonden met je OT netwerk
	- PLCs, HMIs, ....
- IP address, asset name, MAC address, hardware version, firmware version, owner/responsible, ...
- Pitfalls:
	- TCP/IP stack not fully RFC-compliant
	- Port scan
	- Ping of death
	- Fingerprinting
- Unknowns
	- You may find unknown hardware connected
		- Don't panic
			- Determine MAC address
			- Determine vendor ID
			- Physically locate asset
			- Managed switches?
				- Yes: Determine connected switch
				- No: IP range? vendor? ...
- Start with HW, add SW
![[Pasted image 20231209114903.png]]
### 2 Separate IT and OT
- Deny-by-default
- Allow-by-exception
### 3 Secure Remote Access
- [[#Purdue Model]]
### 4 No default passwords
![[Pasted image 20231209115145.png]]
### 5 Segmentation
![[Pasted image 20231209115239.png]]
## Purdue Model
>   The Purdue Enterprise Reference Architecture (PERA), also known as the Purdue Model, is a reference model used in industrial control systems (ICS) and manufacturing environments to organize and secure network architectures. It provides a framework for designing and implementing secure and segmented networks within industrial environments.

**Level 0: Process**
> Lowest level, where physical processes occur. It includes sensors, actuators and other devices that interact directly with the physical process, such as manufacturing machinery, pumps, sensors and motors.

**Level 1: Basic Control**
> At this level, basic control functions occur. It involves devices like PLCs and RTUs (Remote Terminal Units) that monitor and control the physical processes in real time.

**Level 2: Supervisory Control**
> Supervisory control occurs at this level, where SCADA systems and HMI systems are located. These systems provide operators with a view of the processes and allow them to control and manage operations.

**Level 3: Manufacturing Operations**
> This level involves functions related to production control, manufacturing operations and data collection for performance monitoring. Functions like MES (Manufacturing Execution Systems) and ERP (Enterprise Resource Planning) systems are typically found here.

**Level 4: Business Planning and Logistics**
> At the highest level, business planning and logistics systems are located. It involves enterprise-level systems for resource planning, inventory management and business analytics

**Level 5: Enterprise Network**
> This level represents the integration of the ICS (Industrial Control System) networks with the corporate IT network or the enterprise level network. This level signifies the connection between the OT environment and the IT environment

![[Pasted image 20231209112532.png]]
## Summary
- What is IACS
	- Industrial Automation and Control Systems
- Where is it being used
	- Everywhere
- IT vs OT
	- IT: Confidentiality prevails
	- OT: Availability prevails
- How to approach improvement plans
	- Based on risk appetite
- 4 phases
	- Assess, Develop & Implement, Maintain, Improve
- 5 (or 6?) Common steps for all OT improvement plans

# 11 Privacy & Ethics
## Deel 1: Privacy
### GDPR: General Data Protection Regulation
*Algemene Verordening Gegevensbescherming (AVG)*
- Vorige EU wetgeving inzake data protection dateerde van 1995
- Waarom Security?
	- 2 Redenen
		- Moeten (Compliance)
		- Willen (Risico)
#### Wat is de GDPR
- Europese regelgeving om databeveiliging te versterken en te uniformiseren doorheed de EU

##### Europese Unie

| EU | 27 | Lidstaten |  
| -------- | -------- | -------- |  
| België | Bulgarije | Cyprus |  
| Denemarken | Duitsland | Estland |
| Finland | Frankrijk | Griekenland |
| Hongarije | Ierland | Italië |
| Kroatië | Letland | Litouwen |
| Luxemburg | Malta | Nederland |
| Oostenrijk | Polen | Portugal |
| Roemenië | Slovenië | Slowakije |
| Spanje | Tsjechië | Zweden |

- Timing:
	- Gestart in 2012
	- Finale tekst aanvaard op 15/12/2015 door "De Drie"
		- Europese Commissie
		- Europees Parlement
		- Europese Raad
	- Veralingen klaar op 24/05/2016
	- Overgangsperiode van 2 jaar
	- Van kracht vanaf 25/05/2018
##### Doel van GDPR
![[Pasted image 20231209131257.png]]
##### Persoonsgegevens

> Gegevens aan de hand waarvan een persoon direct of indirect kan worden geïdentificeerd

*Voorbeelden:*
- Naam
- Adres
- GSM-nummer
- Geboortedatum
- Foto
- E-mail
- Posts op Sociale Media
- IP-adres
##### Principes van GDPR
![[Pasted image 20231209131534.png]]

##### 3 Rollen van de GDPR
1. **Data Subjects:**
	- EU burgers waarover persoonsgegevens worden verzameld
1. **Data Controllers:**
	- Bedrijven of instanties die persoonsgegevens opslaan
2. **Data Processors:**
	- Bedrijven of instanties die persoonsgegevens gebruiken om te verwerken
![[Pasted image 20231209131804.png]]

**Rechten van Data Subjects:**
- Recht op correcties
- Strengere goedkeuringsvereisten
- Het recht om vergeten te worden
- Mogelijkheid tot draagbaarheid van gegevens
- Verwittiging bij gegevens in gevaar
- 'Privacy By Default'

**Verntwoordelijkheden van Data Controllers en Processors:**
- Verantwoordelijkheid voor schendingen en inbreuken
- Harde sancties bij niet-naleving
- Ingebouwde beveiligingsmaatregelen
- Transparantie in gegevensstroom
- Gegarandeerde E2E-beveiliging (exchange to exchange)

**Data Protection Officer (DPO) Rollen**
- Informeer en Adviseer bedrijven over data protection
- Monitor databeheer en verwerking
- Schat in de impact van bescherming en risiconiveau
- Verwittig data subjects over schendingen
- Werk mee met de toezichthoudende entiteiten
#### 3 Stragegieën voor bescherming
1. **Anonimiesatie**
> Anoniem maken door delen van de informatie te veranderen of weg te laten

2. **Pseudoniemisatie**
> De informatie splitsen waardoor de persoon niet identificeerbaar is met slechts 1 deel vd informatie
![[Pasted image 20231209132951.png]]

3. **Toegangscontrole**
> Toegang tot de informatie controleren en verhinderen met behulp van technische maatregelen

**Pseudoniemisatie vs. Anoniemisatie**
- Pseudo: Je behoudt de mogelijkheid om personen te identificeren
- Anon: Je verliest die mogelijkheid (in theorie)

#### Te nemen stappen als bedrijf
- Register aanleggen van opgeslagen persoonsgegevens
	- Welke gegevens opgeslagen
	- Hoe worden die verzameld
	- Waar bijgehouden
	- Wat wordt ermee gedaan
	- Hoelang nodig
	- Met wie gedeeld
- Individuen inlichten over opslag en verwerking van persoonsgegevens
- Persoonsgegevens adequaat beschermen
	- Technische hulpmiddelen
- Register up-to-date houden
- Logboek van inbreuken bijhouden
![[Pasted image 20231209133325.png]]
1. Breng data in kaart
	- Register volgens artikel 30
2. Gap analysis
	- Hoe groot is de 'gap' tussen GDPR-compliant en huidige situatie
3. Voorstellingen tot aanpassingen
	- DPO aanstellen
	- Register aanleggen
	- Beveiligingsmaatregelen oplijsten
4. Implementatie
	- Tijdslijn
	- Multidisciplinair team
	- Ondersteuning van directie
	- Budget
#### GDPR en software development
- Hou rekening met nieuwe rechten van data subjects
- Probeer rol van Data Processor te vermijden
#### Recht op vergetelheid
- Volgens letter vd wet
> Meer bepaald moeten betrokkenen het recht hebben hun persoonsgegevens te laten wissen en niet verder te laten verwerken … wanneer de betrokkenen hun toestemming hebben ingetrokken of bezwaar maken tegen de verwerking van hun persoonsgegevens, …
- Wat met backups?
#### GDPR-Compliancy = multidisciplinaire activiteit
- Wet en regelgeving
	- Juridische dienst
- Persoonsgegevens bij verschillende afdelingen verzameld, bewaard, gebruikt
	- Business processen
- Toegangscontrole van in-kaart-gebrachte persoonsgegevens
	- IT-dienst
#### Technische Hulpmiddelen
- **Firewall**
	- Data Loss Prevention (gateway)
- **MFA**
	- Bescherming van inloggegevens
- **Audit rapporten**
	- Bescherming van inloggegevens
	- Active Directory
	- Wie deed wat, wanneer, waar, ...
- **Centraal beheerd anti-virus en -malware systeem**
- **Full disk encryption**
	- Laptop verloren of gestolen
- **Centraal Patch beheer**
- **Mobile Device Management**
	- Beveiligde omgeving voor bedrijfsgegevens
	- Selective wipe
- **Fileserver**
	- Encryptie van fileserver
	- Principle of least privilege
- **Email**
	- Advanced Threat Protection
		- Onderscheppen van bv.: phising
- **Veilig en gecontroleerd bestanden delen**
	- Bv.: Citrix, sharefile
- **Document Encryption**
	- Azure Information Protection
#### Straffe uitspraken
***Certified GDPR Compliant***
- *awarded the ISO 17024-accredited EU GDPR Practitioner (EU GDPR P) qualification by IBITGQ*
	- Bullshit: nog geen officiële certificatie in BE
## Deel 2: Ethics
### Wat is Ethiek
- èthos = grieks: gewoonte of zedelijke handeling
- Wat is de uiteindelijke norm voor het menselijk handelen?
	- In context: Wat is geoorloofd gedrag voor wat betreft persoonsgegevens
### Acceptable Use Policy (AUP)
- Document met regels wat je als werkgever aanvaardbaar vindt
- Geeft vaak de indruk de gebruiker te willen beperken
- Probeert een balans te vinden tussen acceptabel risico en bruikbaarheid
- Is noodzakelijk om de systemen beheerbaar te houden
- Dient steeds strikt te worden opgevolgd
### Frameworks
- Maak gebruik van frameworks (zoals [[#NIST CSF]]) om de inhoud van AUP te bepalen
	- Voldoende breed
	- Voldoende diepgaand

### NIST CSF
![[Pasted image 20231209135458.png]]
- Prevent
	- Identify
		- Asset Management (ID.AM)
		- Business Environment (ID.BE)
		- Governance (ID.GV)
		- Risk Assessment (ID.RA)
		- Risk Management Strategy (ID.RM)
	- Protect
		- Awareness Control (PR.AC)
		- Awareness and Training (PR.AT)
		- Data Security (PR.DS)
		- Info Protection and Procedures (PR.IP)
		- Maintenance (PR.MA)
		- Protective Technologies (PR.PT)
- Detect
	- Detect
		- Anomalies and Events (DE.AE)
		- Security Continuous Monitoring (DE.CM)
		- Detection Process (DE.DP)
- Respond
	- Respond
		- Response Planning (RS.RP)
		- Communications (RS.CO)
		- Analysis (RS.AN)
		- Mitigation (RS.MI)
		- Improvements (RS.IM)
	- Recover
		- Recover Planning (RE.RP)
		- Improvements (RE.IM)
		- Communications (RE.CO)
#### Wat mag een beheerder doen?
- CAO 81: *"Controle van internet- en e-mailgebruik op het werk"*
- Controle moet een gerechtvaardigd doel nastreven:
	- Voorkomen van ongeoorloofde of lasterlijke feiten
	- Bescherming van economische belangen van de onderneming
	- Veiligheid en/of goede technische werking van de IT-netwerksystemen v/d onderneming
	- Te goeder trouw naleven van de in de onderneming geldende beginselen en regels
- Controle moet transparant zijn
- Werknemers moeten voldoende ingelicht zijn over alle aspecten v/d controle
- Controle mag geen inmenging in het privéleven v/d werknemer tot gevolg hebben
- Alleen globale gegevens mogen worden verzameld
- Individualisering van gegevens in principe niet toegestaan
	- Uitzonderingen:
		- Na vaststellingen van een onregelmatigheid
# 12 Examenvragen
## Something you know + something you have + something you are
- 3 different types of authentication factors to verify a user's identity

**Something you know**
> This authentication factor relies on information that only the user should know, such as a password, PIN, or a specific piece of knowledge like the name of your first pet or your mother's maiden name. It's something stored in your memory.

**Something you have**
> This factor involves possessing a physical item that grants access, such as a key, a security token, a smart card, or a mobile device. This physical item adds an extra layer of security as it's not easily replicable without possession.

**Something you are**
> This factor relates to biometric data unique to an individual, such as fingerprints, retina scans, facial/voice recognition

**Two-factor authentication (2FA)**
> Combining  two factors creates what's known as two-factor authentication (2FA). By using both something the user knows (like a password) and something they have (like a phone or a security token), it significantly enhances security. Even if one factor is compromised, the other adds an additional barrier, making it more challenging for unauthorized users to gain access.

**Multi-factor authentication (MFA)**
> 2FA but more than 2 authentication factors
## Authenticatie vs. Authorisatie
- 2 critical concepts in security
- Often used together
	- Addressing different aspects of access control

**Authentication**
> This process involves verifying the identity of a user or system. It ensures that the person or entity attempting to access a system or resource is who or what they claim to be. Authentication is typically achieved through credentials like passwords, biometrics, security tokens, or two-factor authentication. Once a user's identity is confirmed, they are granted access to the system.

**Authorization**
> This refers to the process of determining what a user or system can access or do after they have been authenticated. It involves defining and enforcing access rights and permissions based on the verified identity. Authorization often works by associating certain permissions or privileges with specific user roles, groups, or individual users. For example, a user might be authorized to view certain files or execute particular actions within a system based on their assigned permissions.

**In essence**
> Authentication verifies a user's identity, while authorization determines what that authenticated user is allowed to do or access within a system. Both are crucial components of a robust security framework: authentication ensures only legitimate users gain access, and authorization controls what those users can do or see once they're inside the system.

## Privilege escalation
- Security vulnerability or attack where an unauthorized user or a malicious actor gains higher levels of access or privileges than intended

**Vertical Privilege Escalation**
> This involves gaining higher levels of access within the same hierarchy. For example, a standard user gaining administrative privileges.

**Horizontal Privilege Escalation**
> Here, an attacker with a certain level of access attempts to gain access to another user's account at the same privilege level, often to perform malicious actions or access sensitive data.

**Examples:**
- **Exploiting Software Vulnerabilities**: 
> Attackers might exploit weaknesses in software or operating systems to gain higher access levels. This could involve exploiting a bug or flaw in the code to execute commands with elevated privileges.

- **Weak Configuration**: 
> Misconfigurations in systems or applications might inadvertently grant excessive privileges, allowing unauthorized users to gain access to restricted areas.

- **Social Engineering**: 
> Tricking authorized users or system administrators into providing access or credentials can also lead to privilege escalation. This can happen through phishing attacks or manipulating individuals to divulge sensitive information.

## Back-Up
**Cloud Back-up**
- Pro's:
	1. Accessibility and Convenience
	2. Scalability
	3. Automated Backups
	4. Redundancy and Reliability
	5. Cost Efficiency
- Con's:
	1. Security and Privacy Concerns
	2. Internet Dependency
	3. Costs Over Time
	4. Vendor Reliability and Lock-In
	5. Regulatory Compliance

**RPO = Recovery Point Objective**
- Data loss tolerance, specifying how much data a business can afford to lose.
**RTO = Recovery Time Objective**
- Time frame within which systems or services must be restored after an incident to minimize downtime.

**Grootvader-Vader-Zoon systeem**
> Een methode voor het organiseren van back-ups die historische gegevens bewaart op basis van verschillende retentieperioden: dagelijks (zoon), wekelijks (vader) en maandelijks (grootvader). Het is ontworpen om een systematische en efficiënte manier te bieden om gegevens te behouden voor verschillende tijdsperioden.

- Grootvader back-ups:
	- Dit zijn de oudste back-ups die doorgaans maandelijks worden uitgevoerd. Ze zijn bedoeld voor langetermijnbehoud en vertegenwoordigen een historische momentopname van gegevens op grotere tijdschalen.
- Vader back-ups:
	- Dit zijn oudere back-ups die typisch wekelijks worden gemaakt. Ze vertegenwoordigen een iets langere termijn dan de zoon-back-ups en dienen als een tussenstap tussen recente en oudere gegevens.
- Zoon back-ups:
	- Dit zijn recente back-ups die meestal dagelijks worden uitgevoerd. Ze zijn bedoeld voor korte termijnbehoud en dienen om snel toegang te bieden tot recente gegevens in het geval van kleine incidenten of verlies.

- In essence:
> Door dit systeem te gebruiken, behoudt een organisatie recente gegevens voor snelle toegang, terwijl het ook oudere gegevens behoudt voor langere termijn en historische doeleinden. Het biedt een balans tussen opslagvereisten en het behouden van verschillende niveaus van gegevenshistorie die nuttig kunnen zijn voor herstel, analyse of wettelijke naleving.

## Risk Coping Strategies
1. **Risk Acceptance:** 
> Acknowledging the existence of a risk and deciding to tolerate or absorb its potential consequences. This strategy is viable when the cost of mitigating the risk outweighs the potential impact.

2. Risk Avoidance
> Identifying a risk and taking actions to eliminate or avoid it entirely. This might involve altering plans, processes, or operations to steer clear of the risk and its potential negative outcomes.

3. **Risk Mitigation:** 
> Involves taking proactive measures to reduce the probability or impact of a risk. This can include implementing safeguards, contingency plans, or enhancing security measures to minimize the risk's adverse effects.

4. **Risk Transference:** 
> Shifting the responsibility of managing a risk to another party, usually through contracts, insurance, or outsourcing. This strategy doesn't eliminate the risk but shares the burden of potential losses or impacts.

5. **Ignore It: (don't do this)** 
> While not a recommended strategy, sometimes risks with minimal impact or probability might be consciously ignored if the cost of managing them outweighs their potential impact on the project or business

## Countermeasures
**Layered security**
1. **Backups**
> Regularly backing up data ensures that even if there's a breach or data loss, there's a copy available for recovery, reducing the impact of potential data loss.

2. **User training**
> Educating users about security best practices helps in reducing the chances of falling victim to social engineering attacks, phishing attempts, or unknowingly compromising security.

3. **Updates**
> Keeping systems and software updated with the latest patches and security fixes helps to address vulnerabilities and weaknesses that could be exploited by attackers.

4. **Antivirus**
> Antivirus software helps in detecting, quarantining, or removing malicious software, providing a layer of defense against various types of malware threats.

5. **Permissions**
> Implementing proper access controls and permissions ensures that users have only the necessary access to data and systems, reducing the risk of unauthorized access or accidental data exposure.

6. **NAC (Network Access Control)**
> NAC systems monitor and control access to networks, ensuring that only authorized devices and users can access the network, enhancing overall network security.

7. **IDS/IPS (Intrusion Detection/Prevention Systems)**
> These systems monitor network traffic for suspicious activities or known attack patterns. IDS detects potential threats, while IPS can actively prevent or block identified threats.

8. **Firewall**
> Firewalls establish a barrier between trusted internal networks and untrusted external networks, controlling incoming and outgoing traffic based on predefined security rules, thus preventing unauthorized access and attacks.
## Risk
- 3 factors to a risk
	1. Threat
	2. Vulnerability
	3. Countermeasure
- Risico = Bedreiging * Ketsbaarheid / Tegenmaatregelen
- You cannot control the threat
	- Risk can only be diminished by reducing the vulnerability by taking countermeasures

## CIA - model
- Fundamental framework used to guide and assess the security of information systems and data.

1. **Confidentiality (Vertrouwelijkheid):**
> This focuses on ensuring that information is accessible only to those authorized to access it. It involves measures to prevent unauthorized access, disclosure, or exposure of sensitive data. Encryption, access controls, and secure authentication methods are often used to maintain confidentiality.

2. **Integrity (Integriteit):** 
> Integrity refers to maintaining the accuracy, consistency, and trustworthiness of data over its entire lifecycle. It involves safeguarding data from unauthorized alteration, ensuring that it remains complete, accurate, and uncorrupted. Techniques like data hashing, digital signatures, and version control help in maintaining data integrity.

3. **Availability (Beschikbaarheid):** 
> Availability ensures that information and systems are accessible and usable when needed by authorized users. It involves implementing measures to prevent and minimize disruptions, ensuring that systems remain operational despite potential threats like hardware failures, cyber attacks, or natural disasters. Redundancy, backups, and disaster recovery plans contribute to ensuring availability.

**In essence**
> The CIA model serves as a guideline for designing, implementing, and evaluating security measures within an organization's information systems. It helps in prioritizing and addressing various security concerns to protect sensitive information and maintain the functionality of systems and data.

**Law of conservation of entropy**
> Try to improve one aspect and another will suffer
> E.g.: Make a backup of your data to improve availability, confidentiality will be lessened: now the backup can be hacked too.

**Example: Bank accounts**
- Confidentiality hurt:
> You still have all your money (and or debts), but everyone else knows how much is on your account
- Integrity hurt:
> Only you can see the amount on your account, but it isn't correct
- Availability correct
> You can see the correct amount of money on your account, but cannot access it

## Threats
**Can be:**
- Coincidentally
- Malicious
**Stems from:**
- Agents (person or organisations)
- Events
**Example**
- A threat can be something that breaks

## Phishing
**Spear Phishing**
> Targeted form of phishing attack that focuses on specific individuals, groups or organizations. Unlike traditional phishing, which typically casts a wide net hoping to catch any victim, spear phishing involves tailoring the attack to a particular target

- **Personalization:** Attackers gather information about the target(s), such as their name, position, company details, or interests, to create highly personalized and convincing messages.
    
- **Delivery:** They then craft deceptive emails, messages, or communications that appear legitimate, often impersonating someone trusted or using official-looking content to trick the target into taking a specific action, such as clicking a malicious link, downloading malware, or divulging sensitive information.

**Double barrel attack**
> Sophisticated attack that combines 2 or more attack methods simultaneously to maximize the chances of success
> E.g.: You send a very obvious phishing email and follow it up with another email pretending to be the bank (maybe even warning them for phishing)

## Ransomware
> Malicious software that locks access to files or systems until a ransom is paid. It's delivered through phishing or vulnerabilities, causing data loss and financial harm. Prevention involves backups, updates, and user education.
> E.g.: Wannacry:
> WannaCry was a major global ransomware attack in 2017. It spread fast, locking computers and demanding ransom for access. It exploited a Windows vulnerability and affected organizations worldwide, stressing the importance of timely system updates and backups. (Not only computers, but billboards, kiosks, medical devices, ...)

## Trojan Horse
> Piece of software which conceals as a different piece of software, or hides in other software.

## Spyware
> Software made to spy on you, gather data and report it to the attacker

## Viruses vs Worms
**Viruses:**
> Need files to spread

**Worms:**
> Spread independently across networks

## The "Hacker"
**Stereotype:**
- Blueprint brought up by media
- Based on real figures
- forms a role model for a certain subculture

> Traditionally, a hacker is someone highly skilled in computer systems and software. They might use their expertise to understand, modify, or improve systems. However, the term has evolved to include different types:

1. **White Hat Hackers:** Ethical hackers who use their skills to enhance security, finding vulnerabilities to help organizations improve their defenses.
2. **Black Hat Hackers:** Typically associated with malicious intent, they break into systems for personal gain, to steal data, disrupt services, or create chaos.
3. **Grey Hat Hackers:** Fall between white and black hat hackers, sometimes breaking into systems without permission but not necessarily for malicious purposes. They might disclose vulnerabilities to the public or demand payment for revealing flaws.
# 13 Vragen Hans
- PKI belangrijke elementen te onderscheiden
- diffy hellman protocol
- is wpa2 veilig
- Wpa enterprise veiliger dan personal?
- waarvoor staat GDPR
- 3 rollen GDPR
- wie voldoen aan GDPR
- in welke industriele revolutie zitten we????
	- antwoord: 4e

**CIA Termen:**
- Confidentiality (Vertrouwelijkheid)
- Integrity (Integriteit)
- Availability (Beschikbaarheid)
**2 Beveiligingsprincipes:**
- Something you have
- Something you are
- Something you know

**Beveligingsrisico wordt bepaald door:**
- Vulnerability
- Threat
- Counter Measure Score
- Valuation

**Risico verlagen:**
- Increase Counter measure score
- Decrease Vulnerability
![[Pasted image 20231029163747.png]]

**Goeie backup:**
*3-2-1 Regel:*
- **3 kopieën van de gegevens**
	- 3 afzonderlijke exemplaren van je gegevens
	- 1 origineel + 2 backups
- **2 verschillende opslagmedia**
	- De 2 backups op 2 verschillende media
	- B.v.: 1 Externe harde schijf + 1 Cloudopslag
- **1 offsite backup**
	- 1 van de 2 backups moet zich op een andere locatie bevinden.


**Uitvoeren pentest logische volgorde:**
1. **Reconnaissance**: Verzamelen van info over het doelwit
2. **Weaponization**: Ontwikkelen v/d tools of methoden gebruikt om binnen te dringen
3. **Delivery**: Afleveren v/d kwaadaardige payload
4. **Exploitation**: Daadwerkelijk misbruiken v kwetsbaarheden in het systeem om toegang te krijgen
5. **Installation**: Installeren van malware of backdoors op het systeem om toegang te behouden
6. **Command & Control**: Opzetten van een mechanisme waarmee de aanvaller toegang kan krijgen tot het systeem
7. **Actions on Objectives**: Uitvoeren van specifieke acties die de aanvaller wil bereiken

**Geen functie van NIST CSF:**
*Onderstaande zijn WEL functies:*
1. **Risicobeheer**: Het CSF helpt organisaties bij het identificeren, beoordelen en beheren van cybersecurityrisico's door middel van een risicogebaseerde aanpak. Het moedigt organisaties aan om risico's te begrijpen, te prioriteren en erop te reageren om de beveiliging te versterken.
2. **Cybersecurityframework**: Het framework biedt een structuur van kernactiviteiten, categorieën en subcategorieën die organisaties kunnen gebruiken als leidraad om hun cybersecurity te verbeteren. Het is flexibel en aanpasbaar aan verschillende bedrijfs- en sectorale behoeften.
3. **Inzicht in cybersecurity**: Het CSF helpt organisaties om een beter begrip te krijgen van hun huidige cybersecuritypositie door hen in staat te stellen hun activiteiten te evalueren en te meten aan de hand van de kernfuncties, categorieën en subcategorieën.
4. **Communicatie en samenwerking**: Het framework vergemakkelijkt de communicatie tussen interne en externe belanghebbenden over cybersecuritykwesties door een gemeenschappelijke taal en referentiepunt te bieden. Dit stimuleert ook samenwerking binnen en tussen organisaties om cyberdreigingen effectiever aan te pakken.
5. **Continue verbetering**: Het CSF moedigt organisaties aan om een proces van continue verbetering van hun cybersecurity in te voeren door regelmatige evaluaties, aanpassingen en updates uit te voeren op basis van veranderende risico's en bedreigingslandschappen.

**Welk versleutelingsalgoritme:**
*Minst naar meest veilig (1: minst - 12: meest):*
1. MD5
2. SHA2
3. DES
4. IDEA
5. CAST-128
6. Blowfish
7. Triple DES
8. RSA
9. ECC
10. AES / Rijndael
11. Diffie-Hellman
12. PKI

**Wat kenmerkt een goed paswoord:**
- strength = entropy = length
- complexity = letters, symbols, capitals, numbers, ...
- No longer considered secure
  - no password is secure
  - can be phised
  - social engineerd
  - logged

**Vertrouwelijke site: HTTPS:**
- Niet waar, iedereen kan een HTTPS certificaat aanvragen

**Diff-Helman Key Exchange:**
- Mathmatical method of securely exchanging cryptographic keys over a public channel.
> The process begins by having the two parties, [Alice and Bob](https://en.wikipedia.org/wiki/Alice_and_Bob "Alice and Bob"), publicly agree on an arbitrary starting color that does not need to be kept secret. In this example, the color is yellow. Each person also selects a secret color that they keep to themselves – in this case, red and cyan. The crucial part of the process is that Alice and Bob each mix their own secret color together with their mutually shared color, resulting in orange-tan and light-blue mixtures respectively, and then publicly exchange the two mixed colors. Finally, each of them mixes the color they received from the partner with their own private color. The result is a final color mixture (yellow-brown in this case) that is identical to their partner's final color mixture.
![[Pasted image 20231209093656.png]]

![[Pasted image 20231209093251.png]]

**Web-beveiliging makkelijk te kraken:**
*IDK, someone else?*

**wpa2 veilig?:**
- Niet waar, niets is veilig

**Waarvoor staat GDPR:**
- General Data Protection Regulation

**3 rollen GDPR:**
- **Data Controller (Gegevensbeheerder)**
> Dit is de entiteit die het doel en de middelen van de verwerking van persoonsgegevens bepaalt. Deze rol is verantwoordelijk voor het naleven van de GDPR-voorschriften, het verkrijgen van toestemming van individuen voor gegevensverwerking, het waarborgen van de veilige verwerking van gegevens en het faciliteren van de rechten van betrokkenen.
- **Data Processor (Gegevensverwerker)**
> Dit is een partij die namens de gegevensbeheerder persoonsgegevens verwerkt. Ze moeten strikte richtlijnen volgen, zoals vastgelegd door de gegevensbeheerder, en mogen de gegevens alleen verwerken binnen de vastgestelde grenzen. De gegevensverwerker is verantwoordelijk voor het waarborgen van de veiligheid van de gegevens en moet de gegevens alleen verwerken zoals overeengekomen met de gegevensbeheerder.
- **Supervisory Authority (Toezichthoudende autoriteit)**
> Dit is een onafhankelijk orgaan dat verantwoordelijk is voor het handhaven van de GDPR en toezicht houdt op de naleving ervan. Elke EU-lidstaat heeft zijn eigen toezichthoudende autoriteit. Deze autoriteiten hebben de bevoegdheid om boetes op te leggen bij inbreuken op de GDPR en kunnen advies en begeleiding bieden aan zowel gegevensbeheerders als gegevensverwerkers.

**In welke industiële revolutie zitten we:**
- 4e IR
> Deze revolutie wordt gekenmerkt door de convergentie van digitale, fysieke en biologische systemen, wat leidt tot een enorme verandering in de manier waarop we leven, werken en communiceren.