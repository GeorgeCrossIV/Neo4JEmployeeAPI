# Neo4JEmployeeAPI

This repository contains a C# solution that build two Web API web services and a JavaScript web page that calls the two web services.
The following tasks were completed:
  - Create an :Employee node with parameters: 1) String name; and 2) int emp_Id
  - Return all :Employee nodes
  - Develop a UI using plain HTML form. Can be viewed here: http://neo4jemployee.azurewebsites.net/index.html
  - Deploy app and Neo4J instance to a cloud instance. Implemented in Azure, would have been a similar install in AWS EC2.
    - The Neo4J Server is here: http://neo4j-gmc.eastus.cloudapp.azure.com:7474/browser/; Password: Pass@word1

To run the solution in the Software-as-a-Service (SaaS) implementation:
- open this URI: http://neo4jemployee.azurewebsites.net/
- Do the following:
  - Test the functionality
    - Get All Employees: refreshing the page will call the API to get all Employees from the Neo4J server
    - Add New Employee: 1) enter an employee id, 2) enter an employee name, and 3) click the Add Employee button
  - View The APIs
    - Click the API menu item on the navigation bar
  - View the Neo4J Server
    - Click the link "Connect to Neo4J Server"
      - Username: neo4j
      - Password: Pass@word1
- Notes on SaaS implementation
  - Azure VM running Neo4J server edition
  - Azure Web App running the C# solution that contains the Web APIs and the JavaScript html page
  - Used the Neo4J .NET Drivers

To run the solution locally, do the following:

- clone the solution to a local repository: https://github.com/GeorgeCrossIV/Neo4JEmployeeAPI.git
- Open the solution in Visual Studio 2017. The free Community edition can be downloaed here: https://www.visualstudio.com/vs/community/
  - Update the web.config file:
    - update the Uri setting to "bolt://localhost:<port>", where port is the port number assigned by Visual Studio
    - update the password; will mostly likely be "neo4j" if its a standard default desktop installation
- Run the Neo4JEmployeeAPI project. By default, a local website should launch. 
- Notes on local implementation
  - Install and run Neo4J desktop edition.
  - Use the IIS Express that's deployed with Visual Studio, unless greater control of the web server is desired
  
The Java version of the Web API web services is located here: https://github.com/GeorgeCrossIV/Neo4JEmployeeAPI-Java.



