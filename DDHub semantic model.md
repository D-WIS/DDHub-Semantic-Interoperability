# DDHub semantic model
The DDHub semantical model is intended to facilitate semantic interoperability between drilling applications, in particular *drilling automation systems* (DAS). 
It provides standardized ways of representing the meaning of the various signals involved in drilling operations, enabling DAS to interpret them correctly, without ambiguity. 

It it *signal-centered*, meaning that it **does not** intend to describe the rig, wellbore, fluids or trajectory. 
The role of the DDHub is **not** to store and/or provide the signals themselves. This function is left to existing data exchange technologies such as Wits, WitsML, OPC-UA... There is nevertheless a connection between the DDHub and the real-time data management systems: the DDHub aims to provide contextual information about the data available via those systems, and need to be properly integrated in the real-time data ecosystem. 
