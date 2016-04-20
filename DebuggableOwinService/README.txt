Once the project has been created you will need to run the following command in
the package manager console:

    PM> Update-Package

Alternatively, you can go to Tools menu, select "NuGet Package Manager", then
select "Manage NuGet packages for Solution..." and restore the missing packages
from there.

Now you can run the project; by default (see App.Config) the application
listens on http://localhost:8080; you should see a "Hello world!" when you
browse to http://localhost:8080/api/test (see SampleController.cs).

That's it. Enjoy!