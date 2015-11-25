# nfx-demos

<h3>NFX Demo Apps and Use-cases</h3>

Here you can find different demo projects that cover basics and some advanced scenarios of <a href="https://github.com/aumcode/nfx">NFX</a> library using. With <a href="https://github.com/aumcode/nfx">NFX</a> you can develop any web or desktop application with minimal effort. For more on <a href="https://github.com/aumcode/nfx">NFX</a> please see
<br/>
<ul>
<li><a href="https://github.com/aumcode/nfx">https://github.com/aumcode/nfx</a> - the latest public version of the library.</li>
<li><a href="https://www.youtube.com/channel/UCDNMtzPd0lCXgfeMZvTeN8Q">https://www.youtube.com/user/itadapterinc</a> - related videos.</li>
<li><a href="https://github.com/aumcode/serbench">https://github.com/aumcode/serbench</a> - NFX ultra-fast serializer benchmarks.</li>
</ul>

<h4>
NFX.Wave Demos
</h4>

You can find <a href="https://github.com/aumcode/nfx/tree/master/Source/NFX.Wave">NFX.Wave</a> demo projects in \Wave solution folder.

<a href="https://github.com/aumcode/nfx-demos/tree/master/Wave/Wave.HelloWorld">Wave.HelloWorld</a> - the simplest <b>NFX.Wave</b> application that outputs "Hello WAVE!" message to your browser. MVC approach is used.

<a href="https://github.com/aumcode/nfx-demos/tree/master/Wave/Wave.HelloWorldNoMVC">Wave.HelloWorldNoMVC</a> - the simplest <b>NFX.Wave</b> application that outputs "Hello WAVE!" message to your browser. No MVC (no controllers) approach is used.

<a href="https://github.com/aumcode/nfx-demos/tree/master/Wave/Wave.FilteringAndHandling">Wave.FilteringAndHandling</a> - the application demonstrates advanced scenarios of HTTP requests filtering and handling. Filters and handlers are configured in *.laconf configuration file.

<a href="https://github.com/aumcode/nfx-demos/tree/master/Wave/Wave.Logging">Wave.Logging</a> - the application demonstrates basics of <b>NFX.Wave</b> loging capabilities. Logging is configured in *.laconf configuration file.

<a href="https://github.com/aumcode/nfx-demos/tree/master/Wave/Wave.Resources">Wave.Resources</a> - the application demonstrates how you can address different resources such as css, javascripts, flat files, images etc.

<a href="https://github.com/aumcode/nfx-demos/tree/master/Wave/Wave.ViewEngine">Wave.ViewEngine</a> - the application demonstrates different capabilities of <b>NFX.Wave</b> html templatization engine. You can embed any code in your html template pages, which then will be rendered by server into a valid html. You can also embed a piece of html into another views for reusability purposes (partial views).

<a href="https://github.com/aumcode/nfx-demos/tree/master/Wave/Wave.DbApplication">Wave.DbApplication</a> - a simple web application with MySQL database backend. The application demonstrates working with simple CRUD operations over MySQL database.

<h4>
NFX.Glue Demos
</h4>


NFX.Glue technology allows to develop distributed, service-oriented applications in a simple and efficient manner with minimal effort. You can find <a href="https://github.com/aumcode/nfx/tree/master/Source/NFX/Glue">NFX.Glue</a> demo projects in \Glue solution folder.

Basic demo solution includes three projects:

<a href="https://github.com/aumcode/nfx-demos/tree/master/Glue/Glue.Contracts">Glue.Contracts</a> - contains contracts shared between server- and client-side such as service contracts and data contracts.

<a href="https://github.com/aumcode/nfx-demos/tree/master/Glue/Glue.Server">Glue.Server</a> - contains implementation of service contracts and also provides console host for them.

<a href="https://github.com/aumcode/nfx-demos/tree/master/Glue/Glue.Client">Glue.Client</a> - contains auto generated clients for the services and a simple WindowsForms application that demonstrates some basic capabilities of <a href="https://github.com/aumcode/nfx/tree/master/Source/NFX/Glue">NFX.Glue</a> technology.

Run <a href="https://github.com/aumcode/nfx-demos/tree/master/Glue/Glue.Server">Glue.Server</a> and <a href="https://github.com/aumcode/nfx-demos/tree/master/Glue/Glue.Client">Glue.Client</a> projects.
Tabs in the client application contain some examples of <a href="https://github.com/aumcode/nfx/tree/master/Source/NFX/Glue">NFX.Glue</a> techology usage:

<ul>
<li>
<b>Echo Test</b> - A simple echo server. Type any text in the textbox and press 'Send' button. You should see server response below.
</li>
<li>
<b>Stateful Test</b> - Stateful server stores its state for each client.Client should call method decorated with [Constructor] attribute before any other. Press 'Init' button to do it. Then press 'Add' button to change integer state of the server.You can get current state of the server by pressing 'Result' button.After you press 'Done' button the server will become inavailable for current client. You can verify it by pressing 'Add' or 'Result' buttons after 'Done'.
</li>
<li>
<b>Data Contract Test</b> - The demonstration of non-elementary types transferring. Fill some person's data below and press 'Add' to send it to the server. Enter some text in right textbox and then press 'Find' to find stored persons by name.
</li>
<li>
<b>High Load Test</b> - The imitation of high-load server. Enter iterations number and press 'Start'. You can also choose between parallel and syncronous version of the test.
</li>
</ul>
