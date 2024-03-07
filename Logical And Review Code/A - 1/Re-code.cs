if (application == null)
    return null; // or throw an exception
if (application.protected == null)
    return null; // or throw an exception

return application.protected.shieldLastRun;
