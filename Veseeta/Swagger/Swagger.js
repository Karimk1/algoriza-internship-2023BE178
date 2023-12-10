$(function () {
    // Retrieve the token from wherever you store it (localStorage, etc.)
    var token = "your-access-token-here";

    // Add the token to the "Authorize" button in Swagger UI
    if (token) {
        var bearerToken = 'Bearer ' + token;
        swaggerUi = window.ui;

        // Set the authorization token
        window.ui.preauthorizeApiKey('Bearer', bearerToken);

        // Force the Swagger UI to refresh and display the "Authorize" button
        window.ui.preAuthorizeCallback();
    }
});