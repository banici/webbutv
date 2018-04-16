# Actor system architecture

* The program starts in the HomeController with a simple Welcoming text, up in the right corner there are two language options (Svenska, Engelska).
  Ive added two actionlinks in the _Layout.cshtml that changes the routing so that it interacts with the resx files so the language changes.
  
  The upper left corner (Actor Registration) gets you to the ActorController and shows you the Index View of it's Controller. It displays
  a list of famous actors and some information about them, such as (Name, Age, FamousMovie, Salary).

* Each Actor on the list has a "Edit" & "Delete" button and there is a "Create New" button on the page as well.
* Delete button Interact with the "Delete" IActionResult on the ActorController and erases selected actor.
* By pressing "Edit" or "Create New" button the (PutOrPost - View) shows and some fields that can be edited. At the bottom of that page
  there is a "submit" button to enter the given fields and there is a "Remove" button to erase the fields.  


# Database

I migrated and updated a database from the properties inside the class "Actor" in the "RESTApi - solution"
and named it "WebutvDB" and its DbContext to "RestApiContext". 