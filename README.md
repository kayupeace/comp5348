# comp5348

Ahmad Chakhachiro 312038984
Kaiban Yu 440171810
Tk Tang 430378261

Step by Step guide to run this application:

1. Import database
	1.1 Click on Tools -> Sql server -> new query 
	1.2 Exapand Local and select MSSQLLocalDB connection
	1.3 run following sql code to build up database:
		
		CREATE DATABASE Videos;
		CREATE DATABASE Bank;
		CREATE DATABASE Deliveries;
		
	1.4 Compiler database entity fro videos, banck, and deliveryco
	
2. Run following application 
	Bank.Application in debug mode
	DeliveryCo in debug mode
	EmailService in debug mode
	VideoStore in debug mode
	
3. Run following presentation level
	VideoStore.Presentation
	
4. Login with account number and password
	username: Account
	password: Account