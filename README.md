# Overview

This is a Task List application with several broken or incomplete features.  Complete the issues in order to restore the application functionality.

## Issues

1. When I start my app, I get an error that reads: `InvalidOperationException: Unable to resolve
   service for type 'TaskListApp.Services.TaskListService' while attempting to activate
   'TaskListApp.Controllers.TaskListController'.`
   Please fix this so that the application will work.

2. When I post `{"name": "My Task List"}` to `/tasklist` to try to create a new `TaskList`, the name
   field isn't coming through, please help me with this.

3. The GET mapping of `/tasklist/{id}` isn't working.  When I invoke this method with `/tasklist/1`,
   the `id` variable is null.  Please correct this method such that it gets the correct value from
   the request.

4. Also, on the GET mapping of `/tasklist/{id}` if there is not a record found, I get a 500 response.
   Can you make this return the proper HTTP response code?

5. I can create and get a TaskList, but I'd like to be able to update it too. I'm not sure how to 
   implement this.  Could you add an endpoint that would allow me to update an existing `TaskList`? 

6. There's a test in `TaskListServiceTest` that partially covers the `TaskListService.findById` method.
   Extend the test to cover the other possible branches.
   
7. `TaskListControllerTest.TestCreateTaskList` is failing, and I don't know why. Fix the code so
   the test no longer fails.
