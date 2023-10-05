using FP.Patterns.State;

ServerContext context = new ServerContext();

context.State = new AvailableServerState();

context.Response();

context.State = new OverloadedServerState();

context.Response();
context.Response();

context.State = new SuperOverloadedServerState();

context.Response();
context.Response();

context.State = new CrashServerState();

context.Response();
context.Response();