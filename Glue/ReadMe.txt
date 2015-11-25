NFX.Glue technology allows to develop distributed, service-oriented applications 
in a simple and efficient manner with minimal effort.

Basic demo solution includes three projects:

Glue.Contracts - contains contracts shared between server- and client-side such as
                 service contracts and data contracts.

Glue.Server    - contains implementation of service contracts and also provides 
                 console host for them.

Glue.Client    - contains auto generated clients for the services and a simple 
                 WindowsForms application that demonstrates some basic capabilities 
                 of NFX.Glue technology.

Run Glue.Server and Glue.Client projects.
Tabs in the client application contain some examples of NFX.Glue techology usage:

1. Echo Test -          A simple echo server. Type any text in the textbox and press 
                        'Send' button. You should see server responce below.

2. Stateful Test -      Stateful server stores its state for each client.
                        Client should call method decorated with [Constructor] attribute 
                        before any other. Press 'Init' button to do it. 
                        Then press 'Add' button to change integer state of the server.
                        You can get current state of the server by pressing 'Result' button.
                        After you press 'Done' button the server will become inavailable for current client. 
                        You can verify it by pressing 'Add' or 'Result' buttons after 'Done'.

3. Data Contract Test - The demonstration of non-elementary types transferring.
                        Fill some person's data below and press 'Add' to send it to the server.
                        Enter some text in right textbox and then press 'Find' to find stored persons by name.

4. High Load Test -     The imitation of hight-load server.
                        Enter iterations number and press 'Start'. 
                        You can also choose between parallel and syncronous version of the test.