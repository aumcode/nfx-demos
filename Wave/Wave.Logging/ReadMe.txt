This application demonstrates basics of NFX.Wave loging capabilities.
Logging is configured in 'log' section of *.laconf configuration file.

Start the application and enter one of the following URL:
http://localhost:8080/Test/Index or simply http://localhost:8080.

After the application started log file occurs in the place specified in 
*.laconf configuration file. Log file initially contains some application 
general info and also 'before' and 'after' start page loading events.

You can then enter one on the following URLs:
http://localhost:8080/Test/Another" - to go to another page and log this action.
http://localhost:8080/Test/WrongURL" - to get HTTP request error and log it.

Administrator privileges are required to start the application.
