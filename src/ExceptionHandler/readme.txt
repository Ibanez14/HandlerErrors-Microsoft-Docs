Exception Handling

1) ExceptionHandlerPage :=> 
		Handle exception in app.UseExceptionHandler() (Startup.cs & ErrorController.cs)

2) Access the Exception :=> 
		Getting info about exception in HttpContext.Features.Get<T> (ErrorController/Index action)

3) ExceptionHandlerLambda :=>
		Step 3 in Startup.cs