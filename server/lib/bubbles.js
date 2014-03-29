var qs = require('querystring');

exports.show = function (db, res) {
  var query = 'SELECT * FROM city';
  db.query(query, 1, function (err, rows) {
  	if (err) throw err;
  	res.end(rows[0].Name);
  });
}