# Asp.Net 5 StackOverflowException

This is a Bug Reproduction Repository with a PoC for a StackOverflowException bug in Microsoft.AspNet.Loader.IIS.
It occurs when the custom class OverflowManager tries to access the HttpContext's CancelationToken.

This only happens in IIS servers, tested with local IIS Express and also seems to occur on azure web app, but didn't get any response/log.
WebListener is fine and not affected.

It is linked to the Dependency Injection, because this bug only occurs when the OverflowManager is registered as a Singleton.
I guess because the HttpContext is scoped and the OverflowManager will keep a reference to in in a field.

However that this is causing a StackOverflowException is still very bad.


