# DDHub semantic model
The DDHub semantical model is intended to facilitate semantic interoperability between drilling applications, in particular *drilling automation systems* (DAS). 

There exist several definitions of interoperability. [Wikipedia](https://en.wikipedia.org/wiki/Interoperability) gives the following definition:

>Interoperability is a characteristic of a product or system, whose interfaces are completely understood, to work with other products or systems, at present or in the future, in either implementation or access, without any restrictions.

Distinction is made between *syntactic, semantic and cross-domain* interoperabilities in the same [article](https://en.wikipedia.org/wiki/Interoperability#Types):

>If two or more systems use a common data formats and communication protocols and are capable of communicating with each other, they exhibit syntactic interoperability. XML and SQL are examples of common data formats and protocols. Lower-level data formats also contribute to syntactic interoperability, ensuring that alphabetical characters are stored in the same ASCII or a Unicode format in all the communicating systems.

>Beyond the ability of two or more computer systems to exchange information, semantic interoperability is the ability to automatically interpret the information exchanged meaningfully and accurately in order to produce useful results as defined by the end users of both systems. To achieve semantic interoperability, both sides must refer to a common information exchange reference model. The content of the information exchange requests are unambiguously defined: what is sent is the same as what is understood. The possibility of promoting this result by user-driven convergence of disparate interpretations of the same information has been the object of study by research prototypes such as S3DB.

>Cross-domain interoperability involves multiple social, organizational, political, legal entities working together for a common interest and/or information exchange.

It provides standardized ways of representing the meaning of the various signals involved in drilling operations, enabling DAS to interpret them correctly, without ambiguity. 

It it *signal-centered*, meaning that it **does not** intend to describe the rig, wellbore, fluids or trajectory. 
The role of the DDHub is **not** to store and/or provide the signals themselves. This function is left to existing data exchange technologies such as Wits, WitsML, OPC-UA... There is nevertheless a connection between the DDHub and the real-time data management systems: the DDHub aims to provide contextual information about the data available via those systems, and need to be properly integrated in the real-time data ecosystem. 
