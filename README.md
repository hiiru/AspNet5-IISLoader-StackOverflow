# Microsoft.AspNet.Loader.IIS StackOverflowException

This is a Bug Reproduction Repository with a PoC for a StackOverflowException bug in Microsoft.AspNet.Loader.IIS.
It occurs when the custom class OverflowManager tries to access the HttpContext's CancelationToken.

This only happens in IIS servers, tested with local IIS Express and also seems to occur on azure web app, but didn't get any response/log.
WebListener is fine and not affected.

It might be linked to the Dependency Injection, because this bug only occurs when the OverflowManager is registered as a Singleton.
Even though it's bad to use scoped instances in a singleton constructor and cache them, this shouldn't cause a StackOverflowException

My guess is that the bug is related to Microsoft.AspNet.Loader.IIS.Infrastructure.ClientDisconnectedTokenUtil.

Related Issue: https://github.com/aspnet/Home/issues/815
