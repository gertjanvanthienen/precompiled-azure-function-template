# precompiled-azure-function-template
A template for precompiled azure functions with C#, ARM, Unit tests


The template consists of 4 projects:

1. a **Class Library** project: this contains the actual logic for the Azure Functions. This is compiled into a `.dll` that is copied to the Function App project.
2. a **Function App** project: this provides the necessary configuration files to wrap the logic of the Class Library project as Azure Functions.
3. a **Unit Test** project: used for unit testing of the logic in the Class Library project.
4. an **ARM** project: contains the ARM scripts to create the necessary resources in Azure.
