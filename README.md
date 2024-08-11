# assessments-preqin

Hello!
Thank you for taking my candidacy to the next level.
Please see "PreqinAPI" for the backend and "preqin-ui" for the frontend implementation of the assignment.
For e2e testing, please ensure API project is started before running the UI project.

## Backend Setup:
The API is built using .Net 8 as the target framework. Therefore, it is recommended to build and run the project locally using Visual Studio 2022 IDE.

### Architecture:
Onion architecture is followed (using N-layer architecture style).
Outer layer, Presentation is dependent on Service layer which inturn is dependent on the Domain (repository) layer to fetch data from the database.
Dependency Injection pattern is used to inject the dependent objects via constructor.

The solution PreqinAPI has 4 projects:
1. Presentation: to host the API and Swagger page.
2. Service: service layer for business logic (if needed).
3. Repository: persistence layer to fetch required data.
4. Common: this is meant to host commonly used features, helper methods, extension methods, etc which can be used by the above layers. In this case, it is hosting model classes and some hardcoded data.

**DB Scripts:** <br />
The scripts are placed at ./PreqinAPI/Repository/SQL Scripts/
1. Tables.sql: execute this to create tables (with required constraints) in the database.
2. StoredProcedures: execute this to create SPs that can be used to fetch the required data.

**Run:**
1. Build the solution before first run.
2. The application will be listening on port numbers: 37750 (for http), and 7135, 5033 (for https).
Please keep these ports available before starting the API.
Alternatively, these can be changed from launchSettings.json (./PreqinAPI/Presentation/Properties/launchSettings.json).

**Notes:**
1. Since it was advised to not spend more time, I have built the backend that serves hardcoded data. This data can be read/modified from ./PreqinAPI/Common/HardcodedData.cs file.
However, to make it DB compliant, I have also attached SQL scripts that can be executed on relational databases (MS SQL Server preferred). The tables and SPs will serve the same data that is currently being served by the hardcoded objects.

2. There are not much dependencies required for this solution. Thus, separate Startup.cs file is not used.
Configure and ConfigureServices methods have been implemented in the Program.cs file itself.


## Frontend Setup:
Frontend is built leveraging Angular framework. Latest version 18.x is used. <br />
Please setup latest node and Angular on the machine before running the application. <br />
Once setup is completed, please run the application using "ng serve --open" command from ./preqin-ui. The app will be running on 4200 port. Incase this port is changed, please make sure to do subsequent changes in the API as well where CORS policy is defined (./PreqinAPI/Presentation/Program.cs)


## Existing bugs:
1. After displaying the Investors list, if the user clicks on a particular Commitment against that investor, Commitment section opens without displaying any specific data.
Please click on other investor's commitment and then re-click on the first selected investor.
Then it'll display the commitments under "All" tabs correctly.
I think this is because change detection is not working properly. I tried using ChangeDetectorRef and forcing change detection cycle, but no luck.
2. Filtering is not working for selected asset class under commitment.


## Future Enhancements:
1. Fix existing bugs.
2. Unit testing for frontend and backend.
3. Pagination: Server-side preferred while displaying Investor list and for displaying related Commitments.
4. Create CI pipeline with all the necessary checks to make sure things are stable post each commit.
5. Proper documentation.
6. The app supports single currency for an investor at the moment. This can be enhanced if the investor has commitments offshores.