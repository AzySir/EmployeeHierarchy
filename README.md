<h1>Code Challenge - Scope Of Project</h1>
Below is employee data of a small company.<br />
It represents the hierarchical relationship among employees. CEO of the company doesn't have a manager. <br />
<table>
  <tr><th style="font-weight:bold;">Employee</th><th style="font-weight:bold;">NameId</th><th style="font-weight:bold;">ManagerId</th></tr>
  <tr><td>Alan</td><td>100</td><td>150</td>
  <tr><td>Martin</td><td>220</td><td>100</td>
  <tr><td>Jamie</td><td>150</td><td> </td>
  <tr><td>Alex</td><td>275</td><td>100</td>
  <tr><td>Steve</td><td>400</td><td>150</td>
  <tr><td>David</td><td>190</td><td>400</td>
</table>
<p>Design a suitable representation of this data. Feel free to choose any database (RDBMS, inmemory database etc), file system or even a data structure like List or Map. Then write code (in any language and framework) that displays the organisation hierarchy as below:</p>
<table>
  <tr><td>Jamie</td><td> </td><td> </td></tr>
  <tr><td> </td><td>Alan</td><td> </td></tr>
  <tr><td> </td><td> </td><td>Matin</td></tr>
  <tr><td> </td><td> </td><td>Alex</td></tr>
  <tr><td> </td><td>Steve</td><td> </td></tr>
  <tr><td> </td><td> </td><td>David</td></tr>
</table>

The result can be simply displayed on the console, or HTML page or even a file; whatever
suits you.<br/>
Try to cover all the possible scenarios, for example an employee with no manager, a
manager who is not valid employee; etc.<br />
Pay more attention on writing the actual logic of representing the employee tabular data into
the hierarchical format.

<hr /> 
<h2>Run Project</h2>
The project was built using C#. The <span style="font-weight:bold">Main.cs</span> is the beginning of the project. 
