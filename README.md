Below is employee data of a small company.
It represents the hierarchical relationship among employees. CEO of the company doesn't
have a manager.
Employee
Name
id Manager id
Alan 100 150
Martin 220 100
Jamie 150
Alex 275 100
Steve 400 150
David 190 400
Design a suitable representation of this data. Feel free to choose any database (RDBMS, inmemory database etc), file system or even a data structure like List or Map. Then write code
(in any language and framework) that displays the organisation hierarchy as below:
Jamie
Alan
Matin
Alex
Steve
David
The result can be simply displayed on the console, or HTML page or even a file; whatever
suits you.
Try to cover all the possible scenarios, for example an employee with no manager, a
manager who is not valid employee; etc.
Pay more attention on writing the actual logic of representing the employee tabular data into
the hierarchical format.