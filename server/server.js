var http = require('http'),
    mysql = require('mysql');

var db = mysql.createConnection({
  host: '127.0.0.1',
  user: 'root',
  password: '5217',
  database: 'world'
});

var bubbles = require('./lib/bubbles');

var server = http.createServer(function (req, res) {
  bubbles.show(db, res);
}).listen(8080, '127.0.0.1');

console.log('Server running at http://127.0.0.1:8080');