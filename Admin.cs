
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Admin {

    public Admin() {
    }

    private int id;

    private string email;

    private string username;

    private string password;

    private string company;

    private bool isLoggedIn;

    public void login() {
        // TODO implement here
    }

    public void register() {
        // TODO implement here
    }

    public void browseApplications() {
        // TODO implement here
    }

    /// <summary>
    /// @param application
    /// </summary>
    public void acceptApplication(Application application) {
        // TODO implement here
    }

    /// <summary>
    /// @param application 
    /// @param notify
    /// </summary>
    public void rejectApplication(Application application, boolean notify) {
        // TODO implement here
    }

    /// <summary>
    /// @param application
    /// </summary>
    public void archiveApplication(Application application) {
        // TODO implement here
    }

}