# ToDoListWebApp
Automating [Angular ToDoMVC](https://todomvc.com/examples/angular2) website


Given below are some positive and negative scenarios: <hr />

## Positive Scenarios

1. Verify URL https://todomvc.com/examples/angular2/ is working, Verify window title is **'Angular.TodoMVC'**<br />

2. Verify availability of controls on the home page <br />
	<i>a. Header 'todos' </i><br />
	<i>b. Input TextBox 'What needs to be done?' </i><br />

3.  Verify footers information is present on angular2 home page <br />
      <ul>
	<li><i>Double-click to edit a todo</i> </li>
	<li><i>Created by Sam Saccone and Colin Eberhardt using Angular2</i> </li>
	<li><i>Part of TodoMVC</i></li>
      </ul>
4.  Verify after clicking on footer hyperlink **'Sam Saccone'** user is navigated to "http://github.com/samccone" <br />

5.  Verify after clicking on footer hyperlink **'Colin Eberhardt'** user is navigated to "http://github.com/samccone" <br />

6.  Verify after clicking on footer hyperlink **'Angular2'** user is navigated to "http://angular.io" <br />

7.  Verify user is able to add their todo items from Input TextBox by pressing 'Enter' key from keyboard <br />
    e.g add following todo items <br />
      <i>a. Yoga Class </i><br />
      <i> b. Visit leh ladakh</i> <br />
      <i> c. Create accessibility app to help blind people </i><br />

    Verify list contains following todo items with radio button unchecked <br />
      <i> a. Yoga Class </i><br />
      <i> b. Visit leh ladakh </i><br />
      <i> c. Create accessibility app to help blind people </i><br />

8.  Verify existing todo item name is ~stikethough~ from the todo list after clicking on radio button <br />

9.  Verify todo item name is removed from the todo list when 'Clear Completed' is clicked <br />

10. Verify todo item name is removed from the todo list when 'remove' button is clicked <br />

11. Verify count of 'N Items left' increased by one when new todo item is added in the list <br />

12. Verify count of 'N Items left' decreased by one when radio button is checked for any existing todo item. <br />


## Negative Scenarios

1. Check radio button for any existing todo item and verify count of 'item left' is decreased by one, again uncheck same radio button and verify count of 'item left' is increased by one. <br />
2. Verify user is able to add todo item name conatins special character **e.g.#$%^%^##&^*^&*** <br />
3. Verify todo item can not be added with **blank** name <br />
4. Verify todo item cannot be added with name which contains only **spaces** and **no characters** <br />
5. Verify number of **character limit** for todo item name e.g (Consider maximum char limit 100 char). The user should not be able to add more than **100 characters** in ToDo list <br />
6. Verify todo items **data persists** when user hits **Refresh** on the web page or closes and launches the page again <br />
7. Verify **verticle scroll bar** is added to right corner of the page when user add more than **6 todo items** <br />
8. Verify todo item with **duplicate name** cannot be added <br />
