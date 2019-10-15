const express = require("express");
const app = express();

// Folders on Server
app.use(express.static('public'));

// Connect to Server
var server = app.listen(8080, function() {
	var PORT = server.address().port;
	console.log("Server started at http://localhost:%s", PORT);
})