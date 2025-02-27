const http = require('http');
const port = process.env.PORT || 3000;
const fs = require("fs") // node module 


//fuunction that serves static files 

function serveStaticFile(res, path, contentType,
  responseCode = 200) {
  fs.readFile(__dirname + path, (err, data) => {
    if (err) {
      res.writeHead(500, { 'Content-Type': 'text/plain' })
      return res.end('500 - Internal Error')
    }
    res.writeHead(responseCode, {
      'Content-Type':
        contentType
    })
    res.end(data)
  })
}


// the createServer method takes a function as an argument 
// the funcion will be invoked evry time an HTTP request is made 
const server = http.createServer((req, res) => {
  // normalize url by removing querystring, optional
  //trailing slash, and
  // making lowercase
  const path = req.url.replace(/\/?(?:\?.*)?$/,
    '').toLowerCase()
  switch (path) {
    case '':
      serveStaticFile(res, '/public/home.html', 'text/html')
      break
    case '/about':
      serveStaticFile(res, '/public/about.html',
        'text/html')
      break
    case '/home':
      serveStaticFile(res, '/public/img/logo.png','image/png')
      break
    default:
      serveStaticFile(res, '/public/404.html', 'text/html',
        404)
      break
  }
})
server.listen(port, () => console.log(`server started on
  port ${port}; ` +
  'press Ctrl-C to terminate....'))



