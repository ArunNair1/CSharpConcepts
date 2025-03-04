<b> Installing swagger: </b>
Based on : https://aka.ms/aspnetcore/swashbuckle
Main changes are made to program.cs apart from adding the required nuget package for swashbuckle

<b> Generics </b>
<p>
This can be found inside SampleController inside api call for GenericsExample
The callingClass.callMyGenericClass can take arguments of different type and do a console.log and return the same type.
Usually generics are used for such operations, another example is return type of rest apis makred with a <T>
</p>

<b> Async/Await</b>
<p>
This is another way to implement multithreading. async keyword makes the method asynchronous inside it we are using Task.Run to implement multithreading. This is not the traditional way of implelmenting it.
</p>

<B> Task class </b>
<p>
Task class can also be used for multithreading.
Ref: https://www.geeksforgeeks.org/c-sharp-multithreading/
</p>
	
	