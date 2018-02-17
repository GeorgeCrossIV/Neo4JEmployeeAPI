# Neo4JEmployeeAPI

This repository contains a C# solution that build two Web API web services and a JavaScript web page that calls the two web services.

To run the solution in the Software-as-a-Service (SaaS) implementation:
- open this URI: http://neo4jemployee.azurewebsites.net/
- To test do the following:
  - Test the functionality
    - Get All Employees: refreshing the page will call the API to get all Employees from the Neo4J server
    - Add New Employee: 1) enter an employee id, 2) enter an employee name, and 3) click the Add Employee button
  - View The APIs
    - Click the API menu item on the navigation bar
  - View the Neo4J Server
    - Click the link "Connect to Neo4J Server"
      - Username: neo4j
      - Password: Pass@word1

To run the solution locally, do the following:

- clone the solution to a local repository: https://github.com/GeorgeCrossIV/Neo4JEmployeeAPI.git
- Open the solution in Visual Studio 2017. The free Community edition can be downloaed here: https://www.visualstudio.com/vs/community/
  - Update the web.config file:
    - update the Uri setting to "bolt://localhost:<port>", where port is the port number assigned by Visual Studio
    - update the password; will mostly likely be "neo4j" if its a standard default desktop installation
- Run the Neo4JEmployeeAPI project. By default, a local website should launch. 



